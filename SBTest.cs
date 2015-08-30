using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderTest
{
    class SBTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            StringBuilder sb = new StringBuilder();
            sb.Append("Numbers: ");

            for (int index = 1; index <= 200000; index++)
            {
                sb.Append(index);
                sb.Append(" ");
            }

            Console.WriteLine(sb.ToString().Substring(0, 1024));
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();
        }
    }
}
