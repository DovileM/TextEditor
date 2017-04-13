using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindow
{
    public partial class YesOrNo : Form
    {
        private RichTextBox richTextBox;
        public YesOrNo(RichTextBox richTextBox)
        {
            InitializeComponent();
            this.richTextBox = richTextBox;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                richTextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void DontSave_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
