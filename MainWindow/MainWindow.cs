using MainWindow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public delegate void ClearDelegate();
    public partial class TextEditor : Form
    {
        private event EventHandler NumberingEvent;
        public Dictionary<string, Dictionary> _dictionary;
        private bool _select1;
        private bool _select2;
        private FontFamily _font;
        private string _text;
        private System.Drawing.Printing.PrintDocument _docToPrint =
        new System.Drawing.Printing.PrintDocument();
        IChecker wordID;
        IChecker wordMissedLetters;
        private bool _checkMissed;
        private bool _checkIfContains;
        private List<string> _matchedWords;
        private ClearDelegate _clear;


        public TextEditor(Dictionary<string, Dictionary> dictionary, IChecker checker1, IChecker checker2)
        {
            InitializeComponent();
            _select1 = false;
            _select2 = false;
            _font = new FontFamily("Microsoft Sans Serif");
            this._dictionary = dictionary;
            fontComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            fontComboBox.DrawItem += fontComboBox_DrawItem;
            fontComboBox.Items.AddRange(FontFamily.Families.Select(s => s.Name).ToArray());

            wordID = checker1;
            wordMissedLetters = checker2;

            _checkMissed = false;
            _checkIfContains = false;
            _matchedWords = new List<string>();

            _clear = wordList.Items.Clear;
            _clear += _matchedWords.Clear;

            NumberingEvent += CheckNumbering;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            string text;
            var pos = richTextBox.GetLineFromCharIndex(this.richTextBox.SelectionStart);
            if (richTextBox.Text.Length > 0)
            {
                if (richTextBox.Lines[pos].Contains(" "))
                    text = richTextBox.Lines[pos].Substring(richTextBox.Lines[pos].LastIndexOf(" ") + 1);
                else
                    text = richTextBox.Lines[pos];

                //wordList.Items.Clear();
                //_matchedWords.Clear();
                _clear();

                Point position = richTextBox.GetPositionFromCharIndex(richTextBox.SelectionStart);
                position.Offset(richTextBox.Left, richTextBox.Top + richTextBox.Font.Height);
                wordList.Location = position;
                wordList.Visible = false;

                if (_checkIfContains || _checkMissed)
                {

                    if (_checkIfContains)
                    {
                        Task t1 = Task.Factory.StartNew(() => Check(text, wordID));
                        t1.Wait();
                    }
                    if (_checkMissed)
                    {
                        Task t2 = Task.Factory.StartNew(() => Check(text, wordMissedLetters));
                        t2.Wait();
                    }

                    if (_matchedWords != null && _matchedWords.Count > 0)
                    {
                        wordList.Visible = true;
                        wordList.Items.AddRange(_matchedWords.ToArray());
                    }
                }
            }
        }

        private void Check(string text, IChecker checker)
        {
            try
            {
                List<string> newList = new List<string>();
                newList.AddRange(checker.findWords(_matchedWords, text));
                _matchedWords.Clear();
                //_clear();
                _matchedWords.AddRange(newList);
                newList.Clear();
            }
            catch (KeyNotFoundException exp) { Console.WriteLine(exp.Message); }
            catch (ArgumentNullException exp) { Console.WriteLine(exp.Message); }
        }


        #region Font
        private void fontComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font font = new System.Drawing.Font(fontComboBox.Items[e.Index].ToString(), 12);
            string text = fontComboBox.Items[e.Index].ToString();

            e.Graphics.DrawString(text, font, Brushes.Black, e.Bounds);
        }

        private void Font_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
                richTextBox.Font = fd.Font;
        }

        private void Font_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = fontComboBox.SelectedIndex;
            richTextBox.Font = new System.Drawing.Font(FontFamily.Families[selected], richTextBox.Font.Size);
            _font = FontFamily.Families[selected];
        }
        #endregion

        #region Table
        private void InsertTable_Click(object sender, EventArgs e)
        {
            Lazy<InsertTable> lazyTableWindow = new Lazy<InsertTable>();
            InsertTable insertTableWindow = lazyTableWindow.Value;
            insertTableWindow.Show();
        }
        #endregion

        #region Font Style
        private void ClearAllFormating_Click(object sender, EventArgs e)
        {
            richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            int index = fontComboBox.Items.IndexOf("Microsoft Sans Serif");
            fontComboBox.SelectedItem = fontComboBox.Items[index];
            index = fontSize.Items.IndexOf("12");
            fontSize.SelectedItem = fontSize.Items[index];
        }

        private void Bold_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(richTextBox.Font, richTextBox.Font.Style | FontStyle.Bold);

        }

        private void Italic_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(richTextBox.Font, richTextBox.Font.Style | FontStyle.Italic);

        }

        private void Strikeout_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(richTextBox.Font, richTextBox.Font.Style | FontStyle.Strikeout);

        }

        private void Underline_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(richTextBox.Font, richTextBox.Font.Style | FontStyle.Underline);

        }

        private void Regular_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Regular);

        }
        #endregion

        #region Coloring methods
        private void BackgroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.ShowHelp = true;
            MyDialog.Color = richTextBox.ForeColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                richTextBox.BackColor = MyDialog.Color;
        }
        private void TextBrush_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.ShowHelp = true;
            MyDialog.Color = richTextBox.ForeColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                richTextBox.ForeColor = MyDialog.Color;
        }
        private void ColorLetter_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.ShowHelp = true;
            MyDialog.Color = richTextBox.ForeColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                richTextBox.SelectionColor = MyDialog.Color;
        }
        private void HighlightLetter_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.ShowHelp = true;
            MyDialog.Color = richTextBox.ForeColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                richTextBox.SelectionBackColor = MyDialog.Color;
        }
        #endregion

        #region Sricpts
        private void Subscript_Click(object sender, EventArgs e)
        {
            if (!_select1)
            {
                richTextBox.SelectionCharOffset = -5;
                richTextBox.SelectionFont = new System.Drawing.Font(richTextBox.Font.Name, richTextBox.Font.Size / 2, richTextBox.Font.Style);
                _select1 = true;
            }
            else
            {
                richTextBox.SelectionCharOffset = 0;
                _select1 = false;
            }

        }

        private void Superscript_Click(object sender, EventArgs e)
        {
            if (!_select2)
            {
                richTextBox.SelectionCharOffset = +5;
                richTextBox.SelectionFont = new System.Drawing.Font(richTextBox.Font.Name, richTextBox.Font.Size / 2, richTextBox.Font.Style);
                _select2 = true;
            }
            else
            {
                richTextBox.SelectionCharOffset = 0;
                _select2 = false;
            }
        }
        #endregion

        #region All / Small Caps 
        private void AllCaps_Click(object sender, EventArgs e)
        {
            richTextBox.SelectedText = richTextBox.SelectedText.ToUpper();
        }

        private void SmallCaps_Click(object sender, EventArgs e)
        {
            richTextBox.SelectedText = richTextBox.SelectedText.ToLower();
        }
        #endregion

        #region Text size, bigger / smaller
        private void BiggerText_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new System.Drawing.Font(richTextBox.Font.Name,
                                    richTextBox.Font.Size + 2, richTextBox.Font.Style);
            fontSize.Items.Add(richTextBox.Font.Size + 2);
            int index = fontSize.Items.IndexOf(richTextBox.Font.Size + 2);
            fontSize.SelectedItem = fontSize.Items[index];
        }

        private void SmallerText_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new System.Drawing.Font(richTextBox.Font.Name,
                                    richTextBox.Font.Size - 2, richTextBox.Font.Style);
            int index = fontSize.Items.IndexOf(richTextBox.Font.Size - 2);
            fontSize.SelectedItem = fontSize.Items[index];
        }

        private void FontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = int.Parse(fontSize.Text);
            richTextBox.Font = new Font(_font, selectedIndex, richTextBox.Font.Style);
        }
        #endregion

        #region Numering

        private void CheckNumbering(object sender, EventArgs e)
        {
            string[] temp = (e as NumberingArgs).SplitSelection();
            string[] text = (e as NumberingArgs).SplitedText();

            int lineCount = 1;
            for (int i = 0; i < text.Length; i++)
            {
                bool tf = true;
                string str = "";
                for (int j = 0; j < temp.Length; j++)
                {
                    if (text[i].Substring(4).Equals(temp[j]))
                    {
                        tf = false;
                        str = temp[j];
                        break;
                    }
                }
                if (tf)
                {
                    text[i] = text[i].Replace(text[i].Substring(0,1), Convert.ToString(lineCount));
                    lineCount++;
                }
                else
                    text[i] = str;
            }

            string str1 = string.Join("\r\n", text);
            richTextBox.Text = str1;

        }

        private void NumberList_Click(object sender, EventArgs e)
        {
            string[] splitSelection = null;

            bool selection = false;
            bool Exists = false;

            if (richTextBox.SelectionLength > 0)
            {
                splitSelection = richTextBox.SelectedText.Replace("\r\n", "\n").Split("\n".ToCharArray());
                selection = true;
            }
            else
            {
                splitSelection = richTextBox.Text.Replace("\r\n", "\n").Split("\n".ToCharArray());
                selection = false;
            }
            try
            {
                for (int i = 0; i < splitSelection.Length; i++)
                {
                    int lineCount = (i + 1);
                    if (!string.IsNullOrEmpty(splitSelection[i]))
                    {
                        int number;
                        if (int.TryParse(splitSelection[i].Substring(0, 1), out number))
                        {
                            Exists = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            int j = 0;
            bool deleted = false;
            for (int i = 0; i < splitSelection.Length - j; i++)
            {
                int lineCount = (i + 1);
                if (lineCount > 9)
                    break;
                if (Exists)
                {
                    int number;
                    if (int.TryParse(splitSelection[i].Substring(0, 1), out number))
                        if (selection)
                        {
                            j = 1;
                            splitSelection[i] = splitSelection[i].Replace(Convert.ToString(number) + ".  ", "");
                            deleted = true;
                        }
                        else
                        {
                            j = 0;
                            splitSelection[i] = splitSelection[i].Replace(Convert.ToString(number) + ".  ", "");
                        }
                }
                else
                    if (!string.IsNullOrEmpty(splitSelection[i]))
                {
                    splitSelection[i] = Convert.ToString(lineCount) + ".  " + splitSelection[i];
                    j = 0;
                }
            }

            string str = string.Join("\r\n", splitSelection);

            if (deleted)
            {
                if (NumberingEvent != null)
                    NumberingEvent(this, new NumberingArgs(splitSelection, richTextBox.Text.Replace("\r\n", "\n").Split("\n".ToCharArray())));
            }
            else
            {
                if (selection)
                    richTextBox.SelectedText = str;
                else
                    richTextBox.Text = str;
            }
        }

        private void BulletList_Click(object sender, EventArgs e)
        {
            string[] splitSelection = null;
            bool selection = false;
            if (this.richTextBox.SelectionLength > 0)
            {
                splitSelection = richTextBox.SelectedText.Replace("\r\n", "\n").Split("\n".ToCharArray());
                selection = true;
            }
            else
            {
                splitSelection = richTextBox.Text.Replace("\r\n", "\n").Split("\n".ToCharArray());
                selection = false;
            }
            bool Exists = false;
            try
            {
                for (int i = 0; i < splitSelection.Length; i++)
                {
                    if (!string.IsNullOrEmpty(splitSelection[i]))
                    {
                        if (splitSelection[i].Contains("●")) { Exists = true; }
                    }
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            for (int i = 0; i < splitSelection.Length; i++)
            {
                int lineCount = (i + 1);
                if (Exists)
                    richTextBox.Text = richTextBox.Text.Replace("● " + " ", "");
                else
                {
                    if (!string.IsNullOrEmpty(splitSelection[i]))
                        splitSelection[i] = "● " + " " + splitSelection[i];
                }
            }
            string str = string.Join("\r\n", splitSelection);
            if (!Exists)
            {
                if (selection)
                    richTextBox.SelectedText = str;
                else
                    richTextBox.Text = str;
            }
        }
        #endregion

        #region File
        private void PrintDocument_Click(object sender, EventArgs e)
        {
            PrintDialog PrintDialog1 = new PrintDialog();
            PrintDialog1.AllowSomePages = true;
            PrintDialog1.ShowHelp = false;

            PrintDialog1.Document = _docToPrint;
            DialogResult result = PrintDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                _docToPrint.Print();
            }
        }

        private void document_PrintPage(object sender,
                        System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox.Text, richTextBox.Font,
                System.Drawing.Brushes.Black, 70, 70);
        }

        private void OpenDocument_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();

            openFile1.DefaultExt = "*.rtf";
            openFile1.Filter = "RTF Files|*.rtf";

            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
                richTextBox.LoadFile(openFile1.FileName);
            }
        }

        private void DeleteDocument_Click(object sender, EventArgs e)
        {
            //richTextBox.Clear();
            MainWindow.YesOrNo window3 = new MainWindow.YesOrNo(richTextBox);
            window3.Show();
        }

        private void SaveDocument_Click(object sender, EventArgs e)
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

        private void CopyText_Click(object sender, EventArgs e)
        {
            _text = richTextBox.SelectedText;
        }

        private void CutText_Click(object sender, EventArgs e)
        {
            _text = richTextBox.SelectedText;
            richTextBox.SelectedText = "";
        }

        private void PasteText_Click(object sender, EventArgs e)
        {
            richTextBox.Focus();
            int i = richTextBox.SelectionStart;
            richTextBox.SelectedText = _text;
            richTextBox.SelectionStart = i;
        }
        #endregion

        #region Alignment
        private void AlignRight_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText.Length > 0)
            {
                richTextBox.SelectionAlignment = HorizontalAlignment.Right;
            }
            else
            {
                richTextBox.SelectAll();
                richTextBox.SelectionAlignment = HorizontalAlignment.Right;
            }
        }

        private void AlignLeft_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText.Length > 0)
            {
                richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            }
            else
            {
                richTextBox.SelectAll();
                richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            }
        }

        private void AlignCenter_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText.Length > 0)
            {
                richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            }
            else
            {
                richTextBox.SelectAll();
                richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            }
        }
        #endregion

        #region Matched Words List
        private void richTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down)
            {
                wordList.Focus();
                wordList.SelectedIndex = 0;
                e.Handled = true;
            }
        }

        private void wordList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string last = richTextBox.Text.Substring(richTextBox.Text.LastIndexOf(" ") + 1);
                last = wordList.SelectedItem.ToString();
                richTextBox.Text = richTextBox.Text.Remove(richTextBox.Text.LastIndexOf(" ") + 1);
                richTextBox.Text += last.ToLower();
                wordList.Visible = false;
                richTextBox.Focus();
                richTextBox.SelectionStart = richTextBox.Text.Length;
            }
        }
        #endregion

        #region Check words by...
        private void checkBoxMissedLetters_CheckedChanged(object sender, EventArgs e)
        {
            if (!_checkMissed)
                _checkMissed = true;
            else
                _checkMissed = false;
        }

        private void checkBoxFromBeginning_CheckedChanged(object sender, EventArgs e)
        {
            if (!_checkIfContains)
                _checkIfContains = true;
            else
                _checkIfContains = false;
        }
        #endregion

        private void Dictionary_Click(object sender, EventArgs e)
        {
            MainWindow.Dictionary window2 = new MainWindow.Dictionary(_dictionary);
            window2.Show();
        }

        private void Question_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("This \"Text Editor\" was created for c# lectures." + "\n" +
                                                    "         Use it like a \"Microsoft Word Office\"." + "\n" +
                                                    "                            Good luck! :)",
            "Important Query",
            MessageBoxButtons.OK,
            MessageBoxIcon.Question);
        }

    }

    public class NumberingArgs : EventArgs
    {
        private string[] splitSelection;
        private string[] splitedText;

        public NumberingArgs(string[] str, string[] str1)
        {
            splitSelection = str;
            splitedText = str1;
        }

        public string[] SplitSelection() { return splitSelection; } 

        public string[] SplitedText() { return splitedText; }
    }
}

