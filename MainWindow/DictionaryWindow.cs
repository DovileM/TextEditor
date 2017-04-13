using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindow
{
    public partial class Dictionary : Form
    {
        private Dictionary<string, TextEditor.Dictionary> dictionary;
        public Dictionary(Dictionary<string, TextEditor.Dictionary> dictionary)
        {
            InitializeComponent();
            this.dictionary = dictionary;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextEditor.Dictionary words;
            string msg = dict.SelectedItem.ToString();
            string letter = msg[0].ToString();
            if (letter.Equals("Y") || letter.Equals("Z"))
                letter = "YZ";
            for (int i = 0; i < dictionary.Count; i++)
            {
                if (dictionary.TryGetValue(letter, out words))
                {
                    for (int j = 0; j < words.dictionary.Count; j++)
                    {
                        if (msg.Equals(words.ToStringWord(j)))
                        {
                            meaningLabel.Text = words.ToStringOne(j);
                            break;
                        }
                    }
                }
            }
            
        }

        private void ShowWords(string letter)
        {
            TextEditor.Dictionary words;
            dict.Items.Clear();
            for (int i = 0; i < dictionary.Count; i++)
            {
                if (dictionary.TryGetValue(letter, out words))
                {
                    Console.WriteLine(letter);
                    for (int j = 0; j < words.dictionary.Count; j++)
                    {
                        dict.Items.Add(words.ToStringWord(j));
                    }
                    break;
                }
            }
        }

        #region Letter Click
        private void A_Click(object sender, EventArgs e)
        {
            ShowWords("A");
        }

        private void B_Click(object sender, EventArgs e)
        {
            ShowWords("B");
        }

        private void C_Click(object sender, EventArgs e)
        {
            ShowWords("C");
        }

        private void D_Click(object sender, EventArgs e)
        {
            ShowWords("D");
        }

        private void E_Click(object sender, EventArgs e)
        {
            ShowWords("E");
        }

        private void F_Click(object sender, EventArgs e)
        {
            ShowWords("F");
        }

        private void G_Click(object sender, EventArgs e)
        {
            ShowWords("G");
        }

        private void H_Click(object sender, EventArgs e)
        {
            ShowWords("H");
        }

        private void I_Click(object sender, EventArgs e)
        {
            ShowWords("I");
        }

        private void J_Click(object sender, EventArgs e)
        {
            ShowWords("J");
        }

        private void K_Click(object sender, EventArgs e)
        {
            ShowWords("K");
        }

        private void L_Click(object sender, EventArgs e)
        {
            ShowWords("L");
        }

        private void M_Click(object sender, EventArgs e)
        {
            ShowWords("M");
        }

        private void N_Click(object sender, EventArgs e)
        {
            ShowWords("N");
        }

        private void O_Click(object sender, EventArgs e)
        {
            ShowWords("O");
        }

        private void P_Click(object sender, EventArgs e)
        {
            ShowWords("P");
        }

        private void Q_Click(object sender, EventArgs e)
        {
            ShowWords("Q");
        }

        private void R_Click(object sender, EventArgs e)
        {
            ShowWords("R");
        }

        private void S_Click(object sender, EventArgs e)
        {
            ShowWords("S");
        }

        private void T_Click(object sender, EventArgs e)
        {
            ShowWords("T");
        }

        private void U_Click(object sender, EventArgs e)
        {
            ShowWords("U");
        }

        private void W_Click(object sender, EventArgs e)
        {
            ShowWords("W");
        }

        private void YZ_Click(object sender, EventArgs e)
        {
            ShowWords("YZ");
        }
        #endregion

        private void Search_TextChanged(object sender, EventArgs e)
        {
            TextEditor.Dictionary words;
            dict.Items.Clear();
            if (search.Text.Length > 0)
            {
                string msg = search.Text;
                string letter = msg[0].ToString().ToUpper();
                if (letter.Equals("Y") || letter.Equals("Z"))
                    letter = "YZ";
                for (int i = 0; i < dictionary.Count; i++)
                {
                    if (dictionary.TryGetValue(letter, out words))
                    {
                        for (int j = 0; j < words.dictionary.Count; j++)
                        {
                            if (words.dictionary[j].ToStringWord().ToUpper().Contains(search.Text.ToUpper()))
                            {
                                Console.WriteLine(words.dictionary[j].ToStringWord() + "                " + search.Text);
                                dict.Items.Add(words.dictionary[j].ToStringWord());
                            }
                        }
                        break;
                    }
                }
            }
        }
    }
}
