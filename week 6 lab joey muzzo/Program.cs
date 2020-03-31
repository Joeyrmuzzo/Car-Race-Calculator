using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_6_lab_joey_muzzo
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] chevy = new double[8];
            double[] ford = new double[8];
            int chevyCount = 0, fordCount = 0 ;
            double seconds = 0;
            for (int index = 0; index < 8; index++)
            {
                Console.Write("Enter Chevy time " + (index + 1) + ":");
                chevy[index] = Convert.ToDouble(Console.ReadLine());
            }
            for (int index = 0; index < 8; index++)
            {
                Console.Write("Enter Ford time " + (index + 1) + ":");
                ford[index] = Convert.ToDouble(Console.ReadLine());
            }
            for(int index = 0; index < 8; index++)
            {
                if (chevy[index] < ford[index])
                {
                    seconds = ford[index] - chevy[index];
                    Console.WriteLine("Chevy wins by : " + seconds);
                    chevyCount++;
                }
                else if (ford[index] < chevy[index])
                {
                    seconds = chevy[index] - ford[index];
                    Console.WriteLine("Ford wins by : " + seconds);
                    fordCount++;
                }
                else Console.WriteLine("The race resulted in a tie");
            }
            if (chevyCount > fordCount)
            {
                Console.WriteLine("Chevy is the overall winner!");
            }
            else if (fordCount > chevyCount)
            {
                Console.WriteLine("Ford is the overall winner!");
            }
            else Console.WriteLine("The races resulted in an overall tie!");
            Console.ReadLine();
        }
    }
}
