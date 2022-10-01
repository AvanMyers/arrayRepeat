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

            Console.Write("[ ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0,10);
                Console.Write($"{array[i]} ");
            }
            Console.Write(" ]");

            for(int i = 0; i < array.Length; i++)
            {
                amountOfRepet = 0;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] == array[i])
                    {
                        amountOfRepet++;
                    } 
                    else
                    {
                        break;
                    }
                    if (amountOfRepet > rememberedRepet)
                    {
                        rememberedRepet = amountOfRepet;
                        rememberedNumber = array[j];
                    }
                }
            }
            Console.WriteLine($" Число {rememberedNumber} повторяется {rememberedRepet} раза");
            Console.ReadKey();
        }
    }
}
