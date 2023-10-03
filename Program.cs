using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        const int NUM = 8;
        static void Main()
        {
            int[] nums = new int[NUM];
            int total = 0;
            for (int i = 0; i < NUM; i++)
            {
                Console.Write("Por favor, introduzca el número: ");
                nums[i] = int.Parse(Console.ReadLine());
                total += nums[i];
            }
            Console.WriteLine("El total de números es: " + total);
            Console.ReadKey();
        }
    }
}
