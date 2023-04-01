using System;
using System.Text;

namespace ConsoleForDummy
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(ReverseWords("a good  example"));
            Console.ReadKey();
        }

        public static string ReverseWords(string s)
        {
            string strOriginalOperator = "<=";
            char c = '=';

            if(strOriginalOperator.Contains(c)){
                Console.WriteLine("");
            }

            StringBuilder concatted=new StringBuilder();
            string[] split_words = s.Trim().Split(" ");
            for(int i = split_words.Length-1; i>=0; i--)
            {
                if (split_words[i]=="")
                    continue;
                if(i< split_words.Length - 1)
                    concatted.Append(" ");
                concatted.Append(split_words[i]);
            }
            return concatted.ToString();
        }
    }
}
