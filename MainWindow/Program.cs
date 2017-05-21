using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    static class Program
    {
        private static Dictionary<string, Dictionary> dictionary;
        private static List<Dictionary> words;
        private static string[] html;
        private static string[] letters;
        private static char[] letter;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            html = new string[] { "a-words.aspx", "b-words.aspx", "c-words.aspx", "d-words.aspx", "e-words.aspx", "f-words.aspx", "g-words.aspx",
                "h-words.aspx", "i-words.aspx", "j-words.aspx","k-words.aspx", "l-words.aspx", "m-words.aspx", "n-words.aspx", "o-words.aspx", "p-words.aspx",
                "q-words.aspx", "r-words.aspx", "s-words.aspx", "t-words.aspx", "u-words.aspx", "v-words.aspx", "w-words.aspx", "yz-words.aspx"};
            /*html = new string[] { "148703", "148713", "148732", "148845", "149637", "149640", "149642", "149643", "151263", "151274",
                                  "151404", "151465", "151466", "156619", "156622", "158007", "158769", "158781", "158782","158782", "161539" };*/

            letters = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
                                               "N","O","P","Q","R","S","T","U","V","W","YZ"};

            dictionary = new Dictionary<string, Dictionary>();
            words = new List<Dictionary>();

            Thread dictThread = new Thread(new ThreadStart(DictionaryFileReader));

            dictThread.Start();
            //DictionaryFileReader(_dictionary, letters, words, html);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TextEditor(dictionary, new WordIfContainsChecker(dictionary), new WordMissedLettersChecker(dictionary)));

            Console.ReadLine();
        }

        private static void ReadFromInternet(int i)
        {
            Dictionary temp = new Dictionary();
            temp.ReadWordsFromInternet(html[i]);
            dictionary.Add(letters[i], temp);
            DictionaryFileWriter(i, letters[i]);
        }

        private static void DictionaryFileWriter(int num, string letters)
        {
            string path = @"Dictionary\";
            string p2 = ".txt";
            path = path + letters + p2;
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int m = 0; m < dictionary[letters].dictionary.Count; m++)
                {
                    sw.WriteLine(dictionary[letters].dictionary[m].ToString());
                }
            }
        }

        private static void DictionaryFileReader()
        {
            for (int i = 0; i < letters.Length; i++)
            {
                Dictionary temp = new Dictionary();
                bool ok = temp.ReadWordsFromFile(letters[i]);
                //if (ok)
                    dictionary.Add(letters[i], temp);
                //else
                    //ReadFromInternet(i);
            }
        }
    }
}
