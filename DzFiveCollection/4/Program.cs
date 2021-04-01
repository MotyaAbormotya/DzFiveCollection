using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Продуктовая корзина. Сначала необходимо заполнить ее продуктами, 
            //    введенными с консоли, начиная со дна корзины. Затем выложить товары из корзины, начиная с верхних

            Stack<string> foodInBasket = new Stack<string>();
            for (int i = 0; i < 5; i++)
            {
                foodInBasket.Push(Console.ReadLine());
            }

            foreach(var item in foodInBasket)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            while (foodInBasket.Count > 0)
            {
                Console.WriteLine("Вытаскиваем продукт .....");
                foodInBasket.Pop();
                Console.WriteLine("Вытащили продукт");
                Console.ReadKey();
                Console.Clear();
            }

            foreach (var item in foodInBasket)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("Корзина пуста");
            Console.ReadKey();
        }
    }
}
