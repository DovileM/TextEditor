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
    public partial class AddCells : Form
    {
        public static string name;
        public AddCells()
        {
            InitializeComponent();
            name = string.Empty;
            textBox.Leave += getInfo;
        }

        private void getInfo(object sender, EventArgs e)
        {
            name = (sender as TextBox).Text;
            Console.WriteLine("---    " + name);
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
