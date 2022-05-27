using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros_elevados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Introduzca el número que desea elevar al cuadrado: ");
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine(num * num);
                Console.ReadLine();
            }
            catch (DivideByZeroException e)
            {
                Console.Write(e.Message);
            }
            catch (FormatException e)
            {
                Console.Write(e.Message);
            }
            Console.ReadKey();
        }
    }
}
