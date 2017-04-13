using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindow
{
    public partial class SelectCells : Form
    {
        private string _str;
        public static string[] str;
        public SelectCells()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            try
            {
                str = _str.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                for (int i = 0; i < str.Length; i++)
                {
                    Console.WriteLine(str[i]);
                }
            }
            catch (NullReferenceException exp)
            {
                Console.WriteLine(exp.Message);
            }
            finally { this.Close(); }

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            _str = textBox.Text;
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Enter_Click(sender, e);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
