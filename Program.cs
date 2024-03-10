using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet2_7_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej mógłbyś napisać ile masz zrostu ? w cm :");
            int wzrost = Int32.Parse(Console.ReadLine());

            if (wzrost < 160)
            {
                Console.WriteLine("Jesteś jednym z wyżsch hobbitów jakiego widziałem");

            }
            else if (wzrost < 160 && wzrost < 185)
            {
                Console.WriteLine("Witamy pana elfa w naszym składzie");

            }
            else
            {
                Console.WriteLine("Czyżby naszym oczom ukazał się prawdziwy trol ?");

            }
            Console.ReadLine();

            
        }
    }
}
