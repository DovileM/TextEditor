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
    public partial class InsertTable : Form
    {
        public int rowSize;
        public int columnSize;
        private List<Label> _label;
        private List<TextBox> _textBox;
        private bool _prevColumn;
        public List<string> columnInfo;
        public InsertTable()
        {
            InitializeComponent();
            for (int i = 1; i <= 15; i++)
            {
                column.Items.Add(i);
                row.Items.Add(i);
            }
            _prevColumn = false;
            column.SelectedItem = 1;
            row.SelectedItem = 1;
            columnInfo = new List<string>();
            //_textBox = new List<TextBox>();

        }

        private void column_SelectedItemChanged(object sender, EventArgs e)
        {
            int k = 0;
            int y = 27;
            int lineNumber = 1;
            int columnSize = int.Parse(column.SelectedItem.ToString());
            if (_prevColumn)
            {
                for (int i = 0; i < _label.Count; i++)
                {
                    Controls.Remove(_label[i]);
                    this.Controls.Remove(_textBox[i]);
                    _textBox[i].Clear();

                }
                _label.Clear();
                columnInfo.Clear();
            }
            _label = new List<Label>();
            _textBox = new List<TextBox>();

            for (int i = 0; i < columnSize; i++)
            {
                _label.Add(new Label());
                _label[i].Text = lineNumber.ToString() + ".";
                _label[i].Size = new Size(22, 13);
                _label[i].Location = new Point(27, 168 + k);
                _label[i].Visible = true;
                _label[i].Show();

                _textBox.Add(new TextBox());
                _textBox[i].Size = new Size(205,12);
                _textBox[i].Location = new Point(49,163+k);
                _textBox[i].Visible = true;
                _textBox[i].Show();

                _textBox[i].Leave += getInfo;

                if (i > 2)
                {
                    cancel.Location = new Point(148, 251+y);
                    ok.Location = new Point(53, 251+y);
                    this.Height = 325+y;
                    y += 27;
                }
                Controls.Add(_label[i]);
                Controls.Add(_textBox[i]);
                lineNumber++;
                k += 27;
                _prevColumn = true;
            }
        }

        private void row_SelectedItemChanged(object sender, EventArgs e)
        {
            try
            {
                rowSize = int.Parse(row.Text);
            }
            catch(FormatException)
            {
                Console.WriteLine("Netinkamas formatas");
            }
        }
        private void getInfo(object sender, EventArgs e)
        {
            string str = (sender as TextBox).Text;
            columnInfo.Add(str);
        }

        private void ok_Click(object sender, EventArgs e)
        {
            foreach (var item in columnInfo)
            {
                Console.WriteLine(item);
            }
            Table window3 = new MainWindow.Table(columnInfo, columnSize, rowSize);
            this.Hide();
            window3.Show();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
