using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatakbr5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("upisi domenu");
            string upis = Console.ReadLine();

            if(upis.Substring(0, 3) == "www")
            {
                if(upis.Substring(upis.Length-3) == ".hr")
                {
                    Console.WriteLine("tocna adresa");
                }
                else
                {
                    Console.WriteLine("netocna adresa");
                }
            }
            else
            {
            Console.WriteLine("netocna adresa");
            }

            Console.ReadKey();

        }
    }
}
