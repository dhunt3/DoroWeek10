using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HylandCopy
{
    class HylandCopy
    {
        static void Main(string[] args)
        {
            string num1 = "2";
            string num2 = "3";
            Console.WriteLine(Add(num1, num2));

            Console.WriteLine(new TestClass().Add2());  //extra stuff. To see if I can understand this syntax...
            Console.ReadLine();
        }

        public static string Add(string num1, string num2)
        {
            try
            {
                throw new Exception("Invalid Numbers. Cannot add strings.");
                Console.WriteLine("Will this writeline message run?");
            }

            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                Console.Write("Goodbye... ");
            }


        }

        class TestClass  //extra stuff to see if I understand the new ClassName().Method() call in writeline.
        {
            public string Add2()
            {
                try
                {
                    throw new Exception("This is a TestClass exception");
                    Console.WriteLine("Will this writeline message run?");
                }

                catch (Exception e)
                {
                    return e.Message;
                }
                finally
                {
                    Console.Write("ByeBye... ");
                }

            }
        }

    }
}
