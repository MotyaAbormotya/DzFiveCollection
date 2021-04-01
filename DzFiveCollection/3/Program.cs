using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            //            5.Подумайте, как эффективнее решить эту задачу с использованием коллекций
            //"Будет 2 массива: 1) фио 2) должность.
            //Описать функцию заполнения массивов досье, функцию форматированного вывода, функцию поиска по фамилии и функцию удаления досье.
            //Функция расширяет уже имеющийся массив на 1 и дописывает туда новое значение.
            //Программа должна быть с меню, которое содержит пункты:
            //            1) добавить досье
            //2) вывести все досье(в одну строку через “-” фио и должность с порядковым номером в начале)
            //3) удалить досье
            //4) поиск по фамилии
            //5) выход"

            Dictionary<string, string> dossier = new Dictionary<string, string>();
            string menu;
            bool exit = false;

            AddingDossier(dossier);

            while (exit == false)
            {
                Console.Write("Команда: ");
                menu = Console.ReadLine();
                switch (menu)
                {
                    case "Search":
                        string searchName = Console.ReadLine();
                        Search(searchName, dossier);
                        break;
                    case "Del":
                        string nameForDel = Console.ReadLine();
                        Delete(nameForDel, dossier);
                        break;
                    case "Exit":
                        Exit(out exit);
                        break;
                    case "Add":
                        AddingDossier(dossier);
                        break;
                    case "Show":
                        Show(dossier);
                        break;
                }
            }
        }

        public static Dictionary<string, string> Delete(string nameForDel, Dictionary<string, string> dossier)
        {
            dossier.Remove(nameForDel);
            return dossier;
        }

        public static void Show(Dictionary<string, string> dossier)
        {
            Console.WriteLine();

            foreach (var item in dossier)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        public static void Exit(out bool exit)
        {
            exit = true;
        }

        public static void Search(string searchName, Dictionary<string, string> dossier)
        {
            Console.WriteLine();
            if (dossier.ContainsKey(searchName) == true)
            {
                Console.WriteLine(searchName + " " + dossier[searchName]);
                Console.WriteLine();
            }
        }

        public static Dictionary<string, string> AddingDossier(Dictionary<string, string> dossier)
        {
            Console.Write("Фамилия: ");
            string name = Console.ReadLine();
            Console.Write("Должность: ");
            string job = Console.ReadLine();
            dossier.Add(name, job);
            return dossier;
        }
    }
}

