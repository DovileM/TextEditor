using System.Collections.Generic;

namespace MainWindow
{
    using System;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public partial class Table : Form
    {
        private Panel buttonPanel = new Panel();
        private DataGridView tableDataGridView = new DataGridView();
        private Button addNewRowButton = new Button();
        private Button addNewCellButton = new Button();
        private Button deleteRowButton = new Button();
        private ComboBox addFunction = new ComboBox();
        private Button showChar = new Button();
        private List<string> _info = new List<string>();
        private int _columnSize;
        private int _rowSize;
        private List<List<string>> _tableData = new List<List<string>>();
        public string[] str;

        public Table(List<string> info, int cSize, int rSize)
        {
            this._info = info;
            _columnSize = cSize;
            _rowSize = rSize;
            InitializeComponent();

        }

        private void Form1_Load(System.Object sender, System.EventArgs e)
        {
            SetupLayout();
            SetupDataGridView();
            for (int i = 0; i < _rowSize; i++)
                tableDataGridView.Rows.Add();
        }

        private void addNewRowButton_Click(object sender, EventArgs e)
        {
            this.tableDataGridView.Rows.Add();
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            if (this.tableDataGridView.SelectedRows.Count > 0 &&
                this.tableDataGridView.SelectedRows[0].Index !=
                this.tableDataGridView.Rows.Count - 1)
            {
                this.tableDataGridView.Rows.RemoveAt(
                    this.tableDataGridView.SelectedRows[0].Index);
            }
        }

        private void SetupLayout()
        {
            this.Size = new Size(600, 500);

            addNewRowButton.Text = "Add Row";
            addNewRowButton.Location = new Point(10, 10);
            addNewRowButton.Click += new EventHandler(addNewRowButton_Click);

            deleteRowButton.Text = "Delete Row";
            deleteRowButton.Location = new Point(100, 10);
            deleteRowButton.Click += new EventHandler(deleteRowButton_Click);

            addNewCellButton.Text = "Add Cell";
            addNewCellButton.Location = new Point(190, 10);
            addNewCellButton.Click += new EventHandler(addNewCellButton_Click);

            addFunction.Text = "Add Function";
            addFunction.Location = new Point(395, 10);
            addFunction.Click += new EventHandler(addFunction_Click);
            addFunction.AutoSize = true;
            addFunction.Items.Add("SUM");
            addFunction.Items.Add("AVG");
            addFunction.Items.Add("COUNT");
            addFunction.Items.Add("MIN");
            addFunction.Items.Add("MAX");

            buttonPanel.Controls.Add(addNewRowButton);
            buttonPanel.Controls.Add(deleteRowButton);
            buttonPanel.Controls.Add(addNewCellButton);
            buttonPanel.Controls.Add(showChar);
            buttonPanel.Controls.Add(addFunction);
            buttonPanel.Height = 50;
            buttonPanel.Dock = DockStyle.Bottom;

            this.Controls.Add(this.buttonPanel);
        }

        private void addNewCellButton_Click(object sender, EventArgs e)
        {
            AddCells add = new AddCells();
            add.ShowDialog();

            if (!string.IsNullOrEmpty(AddCells.name))
            {
                int i = tableDataGridView.ColumnCount++;
                tableDataGridView.Columns[i].Name = AddCells.name;
            }
        }

        private void SetupDataGridView()
        {
            this.Controls.Add(tableDataGridView);

            tableDataGridView.ColumnCount = _info.Count;

            tableDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            tableDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tableDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(tableDataGridView.Font, FontStyle.Bold);

            tableDataGridView.Name = "Table";
            tableDataGridView.Location = new Point(8, 8);
            tableDataGridView.Size = new Size(500, 250);
            tableDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            tableDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            tableDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            tableDataGridView.GridColor = Color.Black;
            tableDataGridView.RowHeadersVisible = false;
            tableDataGridView.AllowUserToAddRows = false;

            for (int i = 0; i < _info.Count; i++)
            {
                tableDataGridView.Columns[i].Name = _info[i];
            }

            tableDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableDataGridView.MultiSelect = false;
            tableDataGridView.Dock = DockStyle.Fill;

        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            _tableData.Clear();
            List<List<string>> str2 = new List<List<string>>();

            for (int i = 0; i < tableDataGridView.Rows.Count; i++)
            {
                List<string> str1 = new List<string>();
                for (int j = 0; j < tableDataGridView.Rows[i].Cells.Count; j++)
                {
                    string value;
                    if (string.IsNullOrEmpty(tableDataGridView.Rows[i].Cells[j].Value as string))
                    {
                        tableDataGridView.Rows[i].Cells[j].Value = "NULL";
                        tableDataGridView.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                        value = "null";
                    }
                    else
                    {
                        value = tableDataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                    str1.Add(value);
                }
                str2.Add(str1);
            }
            int k = 0;
            for (int j = 0; j < str2[k].Count; j++, k++)
            {
                _tableData.Add(new List<string>());
                for (int i = 0; i < str2.Count; i++)
                {
                    _tableData[j].Add(str2[i][j]);
                }
                if (k == str2.Count - 1)
                    break;
            }
        }

        private void addFunction_Click(object sender, EventArgs e)
        {
            string selectedItem = addFunction.SelectedText;
            int[] c = new int[15];
            int k;
            LoadData_Click(sender, e);
            Regex reg = new Regex(@"^[0-9]+(\.[0-9]+)?$");
            if (selectedItem.Equals("SUM"))
            {
                getColumnIndexes(c, out k);
                for (int i = 0; i < _tableData[0].Count; i++)
                {
                    double[] db = new double[k];

                    for (int j = 0; j < k; j++)
                    {
                        if (reg.IsMatch(_tableData[c[j]][i]))
                            db[j] = double.Parse(_tableData[c[j]][i]);
                    }
                    tableDataGridView.Rows[i].Cells[tableDataGridView.Columns.Count - 1].Value = sumFunc(db);
                    tableDataGridView.Rows[i].Cells[tableDataGridView.Columns.Count - 1].Style.ForeColor = Color.Black;
                }

            }
            else if (selectedItem.Equals("AVG"))
            {
                getColumnIndexes(c, out k);
                for (int i = 0; i < _tableData[0].Count; i++)
                {
                    double[] db = new double[k];

                    for (int j = 0; j < k; j++)
                    {
                        if (reg.IsMatch(_tableData[c[j]][i]))
                            db[j] = double.Parse(_tableData[c[j]][i]);
                    }
                    string str = string.Format("{0,2}", (double.Parse(sumFunc(db)) / k).ToString());
                    tableDataGridView.Rows[i].Cells[tableDataGridView.Columns.Count - 1].Value = str;
                    tableDataGridView.Rows[i].Cells[tableDataGridView.Columns.Count - 1].Style.ForeColor = Color.Black;
                }
            }
            else if (selectedItem.Equals("COUNT"))
            {
                getColumnIndexes(c, out k);
                for (int i = 0; i < _tableData[0].Count; i++)
                {
                    string[] db = new string[k];
                    for (int j = 0; j < k; j++)
                    {
                        db[j] = _tableData[c[j]][i];
                    }
                    tableDataGridView.Rows[i].Cells[tableDataGridView.Columns.Count - 1].Value = countFunc(db);
                    tableDataGridView.Rows[i].Cells[tableDataGridView.Columns.Count - 1].Style.ForeColor = Color.Black;
                }
            }
            else if (selectedItem.Equals("MIN"))
            {
                getColumnIndexes(c, out k);
                for (int i = 0; i < _tableData[0].Count; i++)
                {
                    double[] db = new double[k];

                    for (int j = 0; j < k; j++)
                    {
                        if (reg.IsMatch(_tableData[c[j]][i]))
                            db[j] = double.Parse(_tableData[c[j]][i]);
                    }
                    tableDataGridView.Rows[i].Cells[tableDataGridView.Columns.Count - 1].Value = minFunc(db);
                    tableDataGridView.Rows[i].Cells[tableDataGridView.Columns.Count - 1].Style.ForeColor = Color.Black;
                }
            }
            else if (selectedItem.Equals("MAX"))
            {
                getColumnIndexes(c, out k);
                for (int i = 0; i < _tableData[0].Count; i++)
                {
                    double[] db = new double[k];

                    for (int j = 0; j < k; j++)
                    {
                        if (reg.IsMatch(_tableData[c[j]][i]))
                            db[j] = double.Parse(_tableData[c[j]][i]);
                    }
                    tableDataGridView.Rows[i].Cells[tableDataGridView.Columns.Count - 1].Value = maxFunc(db);
                    tableDataGridView.Rows[i].Cells[tableDataGridView.Columns.Count - 1].Style.ForeColor = Color.Black;
                }
            }
        }

        private void getColumnIndexes(int[] c, out int k)
        {
            k = 0;
            SelectCells window = new SelectCells();
            window.ShowDialog();
            str = SelectCells.str;
            try
            {
                for (int j = 0; j < str.Length; j++)
                {
                    for (int i = 0; i < tableDataGridView.Columns.Count; i++)
                    {
                        if (str[j].Equals(tableDataGridView.Columns[i].Name))
                        {
                            c[k] = i;
                            k++;
                        }
                    }
                }
            }
            catch (NullReferenceException exp)
            {
                Console.WriteLine(exp.Message);
                MessageBox.Show("No cells matched with entered name.\nMaybe You forgot to press enter after last word.");
            }
        }

        #region Anonime Functions
        Func<double[], string> sumFunc = (num) =>
        {
            double sum = 0;
            for (int i = 0; i < num.Length; i++)
                sum += num[i];
            return string.Format("{0}", sum);
        };

        Func<double[], string> maxFunc = (num) =>
        {
            double max = num[0];
            for (int i = 1; i < num.Length; i++)
                if (num[i] > max)
                    max = num[i];
            return string.Format("{0}", max);
        };

        Func<double[], string> minFunc = (num) =>
        {
            double min = num[0];
            for (int i = 1; i < num.Length; i++)
                if (num[i] < min)
                    min = num[i];
            return string.Format("{0}", min);
        };

        Func<string[], string> countFunc = (word) =>
        {
            int count = 0;
            Regex reg = new Regex(@"^[0-9]+(\.[0-9]+)?$");
            for (int i = 0; i < word.Length; i++)
                if (reg.IsMatch(word[i]))
                    count++;
            return string.Format("{0}", count);
        };

        #endregion


    }
}
