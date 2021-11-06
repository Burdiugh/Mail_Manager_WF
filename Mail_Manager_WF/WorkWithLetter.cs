using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Manager_WF
{
    public partial class WorkWithLetter : Form
    {
        Letter letter;
        List<string> filePaths = new List<string>();
        FontDialog fd = new FontDialog();
        ColorDialog cd = new ColorDialog();
        
        bool check=false;

        public WorkWithLetter()
        {
            InitializeComponent();
        }
         public WorkWithLetter(Letter let,bool isRead)
        {
            InitializeComponent();
            letter = let;
            check = isRead;
            this.fromTB.Text = letter.From;
            this.toTB.Text = letter.To;
            this.subjTB.Text = letter.Subject;
            this.richTextBox1.Text = letter.Message;
            this.listBox1.DataSource =letter.files;
            richTextBox1.AllowDrop = true;
            richTextBox1.DragDrop+=(sender, e)=>{

                if (e.Data.GetDataPresent(DataFormats.Text))
                {
                    richTextBox1.Text += e.Data.GetData(DataFormats.Text).ToString();
                }
                else if (e.Data.GetDataPresent(DataFormats.FileDrop))
                    foreach (var item in (string[])e.Data.GetData(DataFormats.FileDrop))
                    {
                        filePaths.Add(item.ToString());
                    }
                Update();
            };
            if (isRead)
            {
                this.fromTB.ReadOnly = true;
                this.toTB.ReadOnly = true;
                this.subjTB.ReadOnly = true;
                this.richTextBox1.ReadOnly = true;
                richTextBox1.AllowDrop = false;
            }
        }

        private void richTextBox1_DragEnter(object sender,DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void richTextBox1_DragDrop(object sender,DragEventArgs e)
        {

        }

        void Update()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = filePaths;
        }
            
        private void createBTN_Click(object sender, EventArgs e)
        {
            letter.From = fromTB.Text;
            letter.To = toTB.Text;
            letter.Subject = subjTB.Text;
            letter.Message = richTextBox1.Text;
            letter.files = filePaths;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void changeFont_Click(object sender, EventArgs e)
        {
            if (check != true)
            {
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionFont = fd.Font;
                }
            }
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void RedoBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void changeColor_Click(object sender, EventArgs e)
        {
            if (check != true)
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionColor = cd.Color;
                }
            }
        }

        private void markBtn_Click(object sender, EventArgs e)
        {
            if (check!=true)
            {
                richTextBox1.SelectionBullet = true;
            }
        }

        private void smileEmoji_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "☺";
        }

        private void sadEmoji_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "☹️";
        }

        private void doneEmoji_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "✓";
        }

        
    }
}
