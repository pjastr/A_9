using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź ciąg znaków i naciśnij enter");
            string a = Console.ReadLine();
            Console.WriteLine(a.Remove(1,1));
            Console.ReadKey();
        }
    }
}
