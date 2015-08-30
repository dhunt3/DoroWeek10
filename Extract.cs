using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extraction
{
    class Extract
    {
        static void Main(string[] args)
        {
            string str = "Hello World";
            string result = ExtractCapitals(str);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static string ExtractCapitals(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (char.IsUpper(ch))
                {
                    result.Append(ch);
                }
            }
            return result.ToString();
        }
    }
}
