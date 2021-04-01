using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2withHeashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Зарандомить 10 уникальных значений и вывести их на экран.

            HashSet<int> numbers = new HashSet<int>();

            Random random = new Random();

            for (int i = 0; numbers.Count != 10; i++)
            {
                int randomNumber = random.Next(1, 10 + 1);
                numbers.Add(randomNumber);
            }

            foreach(var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
