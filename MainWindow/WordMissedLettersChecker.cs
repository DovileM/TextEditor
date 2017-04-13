using System;
using System.Collections.Generic;

namespace TextEditor
{
    public class WordMissedLettersChecker : MainWindow.IChecker
    {
        private Dictionary<string, Dictionary> _dictionary;

        public WordMissedLettersChecker(Dictionary<string, Dictionary> dictionary)
        {
            _dictionary = dictionary;
        }

        Func<string, string, bool> compareWords = (x, y) => { return y.Equals(x); };

        public List<string> findWords(List<string> listWords,string text)
        {
            if (text.Length > 0)
            {
                try
                {
                    string firstLetter = text[0].ToString().ToUpper();
                    if (firstLetter.Equals("Y") || firstLetter.Equals("Z"))
                        firstLetter = "YZ";
                    Dictionary temp = _dictionary[firstLetter];
                    for (int i = 0; i < temp.dictionary.Count; i++)
                    {
                        if (checkHowManyMatches(temp.dictionary[i].ToStringWord(), text) > (text.Length / 2))
                        {
                            bool tf = true;
                            if (listWords.Count != 0)
                                foreach (var item in listWords)
                                    if (item.Equals(temp.dictionary[i].ToStringWord()))
                                        tf = false;
                            if (tf)
                                listWords.Add(temp.dictionary[i].ToStringWord());
                        }
                    }
                    return listWords;
                }
                catch (KeyNotFoundException)
                {
                    throw new KeyNotFoundException();
                }
            }
            else
                return null;
        }
        private int checkHowManyMatches(string scan, string word)
        {
            List<string> s = new List<string>();
            int j = 0, k = 0;
            int size = 0;
            if (compareWords(scan[0].ToString().ToLower(), word[0].ToString().ToLower()))
            {
                for (int i = 0; i < scan.Length; i++)
                {
                    if (compareWords(scan[i].ToString().ToLower(), word[j].ToString().ToLower()))
                    {
                        s.Add(scan[i].ToString());
                        j++;
                        size++;
                    }
                    else
                    {
                        s.Add("*");
                        j++;
                        i--;
                        k++;
                    }
                    if (word.Length == j)
                        break;
                }
            }
            if (scan.Length + k < word.Length)
            {
                int i = scan.Length + k;
                while (i != word.Length)
                {
                    s.Add("*");
                    i++;
                }
            }
            string fullWord = string.Join("", s);
            s.Clear();

            return size;
        }
    }
}
