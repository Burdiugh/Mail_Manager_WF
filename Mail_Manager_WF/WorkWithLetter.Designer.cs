
namespace Mail_Manager_WF
{
    partial class WorkWithLetter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkWithLetter));
            this.label1 = new System.Windows.Forms.Label();
            this.fromTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.changeFont = new System.Windows.Forms.ToolStripButton();
            this.undoBtn = new System.Windows.Forms.ToolStripButton();
            this.RedoBtn = new System.Windows.Forms.ToolStripButton();
            this.markBtn = new System.Windows.Forms.ToolStripButton();
            this.changeColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.smileEmoji = new System.Windows.Forms.ToolStripButton();
            this.sadEmoji = new System.Windows.Forms.ToolStripButton();
            this.doneEmoji = new System.Windows.Forms.ToolStripButton();
            this.subjTB = new System.Windows.Forms.TextBox();
            this.createBTN = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "From: ";
            // 
            // fromTB
            // 
            this.fromTB.Location = new System.Drawing.Point(63, 62);
            this.fromTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fromTB.Name = "fromTB";
            this.fromTB.Size = new System.Drawing.Size(402, 20);
            this.fromTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(22, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "To: ";
            // 
            // toTB
            // 
            this.toTB.Location = new System.Drawing.Point(63, 107);
            this.toTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toTB.Name = "toTB";
            this.toTB.Size = new System.Drawing.Size(402, 20);
            this.toTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(6, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Subject: ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 187);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(456, 100);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeFont,
            this.undoBtn,
            this.RedoBtn,
            this.markBtn,
            this.changeColor,
            this.toolStripSeparator1,
            this.smileEmoji,
            this.sadEmoji,
            this.doneEmoji});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.toolStrip1.Size = new System.Drawing.Size(482, 57);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // changeFont
            // 
            this.changeFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.changeFont.Image = ((System.Drawing.Image)(resources.GetObject("changeFont.Image")));
            this.changeFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.changeFont.Name = "changeFont";
            this.changeFont.Size = new System.Drawing.Size(54, 54);
            this.changeFont.Text = "Change font";
            this.changeFont.Click += new System.EventHandler(this.changeFont_Click);
            // 
            // undoBtn
            // 
            this.undoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoBtn.Image = ((System.Drawing.Image)(resources.GetObject("undoBtn.Image")));
            this.undoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(54, 54);
            this.undoBtn.Text = "Undo";
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // RedoBtn
            // 
            this.RedoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RedoBtn.Image = ((System.Drawing.Image)(resources.GetObject("RedoBtn.Image")));
            this.RedoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RedoBtn.Name = "RedoBtn";
            this.RedoBtn.Size = new System.Drawing.Size(54, 54);
            this.RedoBtn.Text = "Redo";
            this.RedoBtn.Click += new System.EventHandler(this.RedoBtn_Click);
            // 
            // markBtn
            // 
            this.markBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.markBtn.Image = ((System.Drawing.Image)(resources.GetObject("markBtn.Image")));
            this.markBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.markBtn.Name = "markBtn";
            this.markBtn.Size = new System.Drawing.Size(54, 54);
            this.markBtn.Text = "Mark text";
            this.markBtn.Click += new System.EventHandler(this.markBtn_Click);
            // 
            // changeColor
            // 
            this.changeColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.changeColor.Image = ((System.Drawing.Image)(resources.GetObject("changeColor.Image")));
            this.changeColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.changeColor.Name = "changeColor";
            this.changeColor.Size = new System.Drawing.Size(54, 54);
            this.changeColor.Text = "Change color";
            this.changeColor.Click += new System.EventHandler(this.changeColor_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // smileEmoji
            // 
            this.smileEmoji.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.smileEmoji.Image = ((System.Drawing.Image)(resources.GetObject("smileEmoji.Image")));
            this.smileEmoji.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.smileEmoji.Name = "smileEmoji";
            this.smileEmoji.Size = new System.Drawing.Size(54, 54);
            this.smileEmoji.Text = "smile";
            this.smileEmoji.Click += new System.EventHandler(this.smileEmoji_Click);
            // 
            // sadEmoji
            // 
            this.sadEmoji.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sadEmoji.Image = ((System.Drawing.Image)(resources.GetObject("sadEmoji.Image")));
            this.sadEmoji.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sadEmoji.Name = "sadEmoji";
            this.sadEmoji.Size = new System.Drawing.Size(54, 54);
            this.sadEmoji.Text = "sad";
            this.sadEmoji.Click += new System.EventHandler(this.sadEmoji_Click);
            // 
            // doneEmoji
            // 
            this.doneEmoji.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.doneEmoji.Image = ((System.Drawing.Image)(resources.GetObject("doneEmoji.Image")));
            this.doneEmoji.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.doneEmoji.Name = "doneEmoji";
            this.doneEmoji.Size = new System.Drawing.Size(54, 54);
            this.doneEmoji.Text = "Done";
            this.doneEmoji.Click += new System.EventHandler(this.doneEmoji_Click);
            // 
            // subjTB
            // 
            this.subjTB.Location = new System.Drawing.Point(82, 141);
            this.subjTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subjTB.Name = "subjTB";
            this.subjTB.Size = new System.Drawing.Size(383, 20);
            this.subjTB.TabIndex = 7;
            // 
            // createBTN
            // 
            this.createBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.createBTN.Location = new System.Drawing.Point(10, 341);
            this.createBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createBTN.Name = "createBTN";
            this.createBTN.Size = new System.Drawing.Size(454, 31);
            this.createBTN.TabIndex = 8;
            this.createBTN.Text = "Done";
            this.createBTN.UseVisualStyleBackColor = true;
            this.createBTN.Click += new System.EventHandler(this.createBTN_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(10, 292);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(454, 43);
            this.listBox1.TabIndex = 9;
       
            // 
            // WorkWithLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 379);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.createBTN);
            this.Controls.Add(this.subjTB);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fromTB);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WorkWithLetter";
            this.Text = "WorkWithLetter";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fromTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox toTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton changeFont;
        private System.Windows.Forms.ToolStripButton undoBtn;
        private System.Windows.Forms.ToolStripButton RedoBtn;
        private System.Windows.Forms.ToolStripButton markBtn;
        private System.Windows.Forms.TextBox subjTB;
        private System.Windows.Forms.Button createBTN;
        private System.Windows.Forms.ToolStripButton changeColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton smileEmoji;
        private System.Windows.Forms.ToolStripButton sadEmoji;
        private System.Windows.Forms.ToolStripButton doneEmoji;
        private System.Windows.Forms.ListBox listBox1;
    }
}