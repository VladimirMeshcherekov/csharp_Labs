using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string inFile = @"input.txt"; //файл для ввода данных в приложение
            string outFile = @"output.txt"; //файл для вывода результатов вычислений
                                            
            TextReader save_in = Console.In;
            TextWriter save_out = Console.Out;
 

            if (!File.Exists(inFile)) // Дополнительное замечание чисто от себя
            {
                throw new Exception("No input file");
            }

            Console.SetIn(new StreamReader(new FileStream(inFile, FileMode.Open)));
            Console.SetOut(new StreamWriter(outFile));
            const double pi = 3.14;
            string strRadius = Console.ReadLine();
            if (double.TryParse(strRadius, out double radius))
            {
                if ((radius <= 0) || (radius > 100000))
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    Console.WriteLine($"L = {Math.Round(2 * pi * radius, 3)}");
                }
                Console.WriteLine($"S = {Math.Round(pi * Math.Pow(radius, 2), 3)}");
            }

            else
            {
                Console.WriteLine("ERROR");
            }
            
            Console.In.Close();
            Console.Out.Close();
            Console.SetIn(save_in);
            Console.SetOut(save_out);

        }
    }
}
