using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayRepeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[30];
            Random random = new Random();
            int rememberedNumber = 0;
            int amountOfRepet = 0;
            int rememberedRepet = 0;
            int minRandom = 0;
            int maxRandom = 10;

            Console.Write("[ ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minRandom, maxRandom);
                Console.Write($"{array[i]} ");
            }

            Console.Write(" ]");

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    amountOfRepet++;
                }
                else
                {
                    amountOfRepet = 1;
                }

                if (amountOfRepet > rememberedRepet)
                {
                    rememberedNumber = array[i];
                    rememberedRepet = amountOfRepet;
                }

            }

            Console.WriteLine($" Число {rememberedNumber} повторяется {rememberedRepet} раза");
            Console.ReadKey();
        }
    }
}
