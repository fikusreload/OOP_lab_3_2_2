using System;
using System.IO;

namespace OOP_lab_3_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "aeiouyаоуиіуяюєї";

            char[] ch = s.ToCharArray();

            int[] elem = new int[s.Length];

            for (int i = 0; i < elem.Length; ++i)
            {
                elem[i] = 0;
            }

            StreamReader file = new StreamReader("text.txt");

            string str = file.ReadToEnd().ToLower();

            foreach (char c in str)
            {
                for (int i = 0; i < s.Length; ++i)
                {
                    if (c == ch[i])
                    {
                        ++ elem[i];
                    }
                }
            }

            ch[10] = 'i';

            for (int i = 0; i < elem.Length; ++i)
            {
                Console.WriteLine("{0} - {1}", ch[i], elem[i]);
            }
        }
    }
}
