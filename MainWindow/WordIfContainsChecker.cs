using System;
using System.Collections.Generic;

namespace TextEditor
{
    public class WordIfContainsChecker : MainWindow.IChecker
    {
        private Dictionary<string, Dictionary> _dictionary;
        public WordIfContainsChecker(Dictionary<string, Dictionary> dictionary)
        {
            _dictionary = dictionary;
        }

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
                        if (temp.dictionary[i].ToStringWord().ToUpper().Contains(text.ToUpper()))
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
                    Console.WriteLine("1FUNKCIJOJ: "+listWords.Count); //4
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


        Func<string, string, bool> compareWords = (x, y) => { return y.Equals(x); };
    }

}
