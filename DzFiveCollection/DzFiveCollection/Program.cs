using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzFiveCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создать программу, которая принимает от пользователя слово и выводит его значение. Если такого слова нет, то следует вывести соответствующее сообщение.

            Dictionary<string, int> instruments = new Dictionary<string, int>();

            string instrumentsType = Console.ReadLine();

            instruments.Add("молоток", 15);

            instruments.Add("отвёртка", 5);

            instruments.Add("пила", 2);

            instruments.Add("гвозди", 151);

            instruments.Add("напильник", 5);

            if (instruments.ContainsKey(instrumentsType) == true)
            {
                Console.WriteLine(instruments[instrumentsType]);
            }
            else
            {
                Console.WriteLine("Этого товара нет в наличии");
            }
            Console.ReadKey();
        }
    }
}
