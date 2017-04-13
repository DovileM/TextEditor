using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace TextEditor
{

    public class Dictionary
    {
        public List<Words> dictionary;

        public Dictionary()
        {
            dictionary = new List<Words>();
        }
        public bool ReadWordsFromFile(string letter)
        {
            string path = @"Dictionary\";
            string p2 = ".txt";
            path = path + letter + p2;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] str = line.Split(new string[] { " " }, StringSplitOptions.None);
                        string mean = string.Empty;
                        for (int i = 1; i < str.Length; i++)
                        {
                            mean +=str[i]+" ";
                        }
                        dictionary.Add(new Words(str[0], mean));
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public void ReadWordsFromInternet(string p2)
        {
            WebClient web = new WebClient();
            string text;
            string p1 = "http://www.englishcollocation.com/vocabulary/lettersearch/";
            string path = Path.Combine(p1, p2);

            Stream stream = web.OpenRead(path);
            using (StreamReader reader = new StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }
            bool tf = false;
            var result = Regex.Split(text.ToString(), @"<[^\>]*>");
            for (int i = 0; i < result.Length; i++)
            {
                if ("Y&Z".Equals(result[i]))
                {
                    for (int j = i + 12; j < result.Length; j++, i++)
                    {
                        if (string.IsNullOrWhiteSpace(result[j]) || Regex.IsMatch(result[j], @"^\(\w{0,}\)") || "(adj,adv)".Equals(result[j]))
                            continue;
                        if ("A".Equals(result[j]) || Regex.IsMatch(result[j], @"^ &#160;&#160; $"))
                        {
                            tf = true;
                            break;
                        }
                        p1 = "http://www.englishcollocation.com/how-to-use/";
                        p2 = result[j];
                        path = Path.Combine(p1, p2);
                        stream = web.OpenRead(path);
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            text = reader.ReadToEnd();
                        }
                        var mean = Regex.Split(text.ToString(), @"<[^\>]*>");
                        var str = GetAllMeaning(mean,result, j);
                        dictionary.Add(new Words(result[j], str));
                    }
                }
                if (tf)
                    break;
            }
        }

        private string GetAllMeaning(string[] mean, string[] result, int j)
        {
            string str = "";
            int one = 0;
            bool tf = false;
            for (int k = 0; k < mean.Length; k++)
            {
                if (mean[k].Equals("Ok"))
                {
                    one--;
                    k++;
                }
                if (result[j].Equals(mean[k]))
                {
                    one++;
                    if (one != 1)
                    {
                        for (int m = k; m < mean.Length; m++, k++)
                        {
                            if (string.IsNullOrWhiteSpace(mean[m]))
                                continue;
                            for (int n = ++m; n < m + 8; n++)
                            {
                                if (string.IsNullOrWhiteSpace(mean[n]))
                                    continue;
                                str += mean[n];
                            }
                            one++;
                            tf = true;
                            break;
                        }
                    }
                }
                if (tf)
                    break;
            }
            return str;
        }

        public string ToStringOne(int i)
        {
            return string.Format(dictionary[i].word+" "+dictionary[i].meaning);
        }

        public string ToStringWord(int i)
        {
            return dictionary[i].word;
        }
        public string ToStringAll()
        {
            string str = string.Empty;
            foreach (Words d in dictionary)
                str += d.word + d.meaning+"\n";
            return str;
        }
        public override string ToString()
        {
            string str = string.Empty;
            foreach (Words d in dictionary)
                str += d.word + "\n";
            return str;
        }
    }

    public struct Words
    {
        public string word;
        public string meaning;

        public Words(string word, string meaning)
        {
            this.word = word;
            this.meaning = meaning;
        }

        public override string ToString()
        {
            return string.Format(word + " " + meaning);
        }

        public string ToStringWord()
        {
            return word;
        }
    }
}
