using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Manager_WF
{
    public partial class Form1 : Form
    {
        string path = @"C:\Users\burdi\Documents\mailtest";
        List<Letter> letters = new List<Letter>();
        BinaryFormatter objBinaryFormatter = new BinaryFormatter();
        public Form1()
        {
            InitializeComponent();
        }
        private void createLetterBtn_Click(object sender, EventArgs e)
        {
            Letter letter = new Letter();
            WorkWithLetter work = new WorkWithLetter(letter,false);
            if (work.ShowDialog() == DialogResult.OK)
            {
                letters.Add(letter);
                Update();
            }
        }
        private void Update()
        {
            listBox.DataSource = null;
            listBox.DataSource = letters;
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            Letter let = listBox.SelectedItem as Letter;
            WorkWithLetter work = new WorkWithLetter(let,true);
            work.Size = new Size(950,900);
            work.ShowDialog();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex==-1)
            {
                return;
            }
            letters.Remove((Letter)listBox.SelectedItem);
            Update();
        }

       
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (Stream obj = new FileStream(path, FileMode.OpenOrCreate))
            {
                objBinaryFormatter.Serialize(obj, letters);
            }
            Update();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {

                    letters = (List<Letter>)objBinaryFormatter.Deserialize(fs);
                }
            }
            catch (Exception)
            {

            }
           
            Update();
        }

        private void saveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();

            if (sd.ShowDialog()==DialogResult.Cancel)
            {
                return;
            }

            string filename = sd.FileName;
            using (Stream obj = new FileStream(filename, FileMode.OpenOrCreate))
            {
                objBinaryFormatter.Serialize(obj, letters);
            }
            Update();
        }

        private void loadFrom_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog()==DialogResult.Cancel)
            {
                return;
            }
            string filename = open.FileName;
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                letters = (List<Letter>)objBinaryFormatter.Deserialize(fs);
            }
            Update();

        }
    }

}
