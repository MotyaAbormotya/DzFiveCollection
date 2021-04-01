using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
//            вас есть множество целых чисел.Каждое целое число - это сумма покупки.
//Вам нужно обслуживать клиентов до тех пор, пока очередь не станет пуста.
//После каждого обслуженного клиента деньги нужно добавлять на наш счёт и выводить его в консоль.
//После обслуживания каждого клиента программа ожидает нажатия любой клавиши, после чего
//затирает консоль и по новой выводит всю информацию, только уже со следующим клиентом
            Queue<int> sum = new Queue<int>();
            int scoreMoney = 0;
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                sum.Enqueue(random.Next(1, 50 + 1));
            }

            foreach (var item in sum)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            scoreMoney = Sum(sum);

            Console.WriteLine(scoreMoney);
            Console.ReadKey();
        }

        public static int Sum(Queue<int> sum)
        {
            int scoreMoney = 0;

            for (int i = 0; sum.Count > 0; i++)
            {
                Console.WriteLine("Производиться обслуживание");
                scoreMoney += sum.Dequeue();
                Console.WriteLine("Покупатель обслужен. У вас на счету " + scoreMoney + " руб");
                Console.ReadKey();
                Console.Clear();
            }

            return scoreMoney;
        }
    }
}
