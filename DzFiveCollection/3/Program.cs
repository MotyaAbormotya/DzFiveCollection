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

            AddDossier(dossier);

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
                        string nameForDelete = Console.ReadLine();
                        Delete(nameForDelete, dossier);
                        break;
                    case "Exit":
                        Exit(out exit);
                        break;
                    case "Add":
                        AddDossier(dossier);
                        break;
                    case "Show":
                        Show(dossier);
                        break;
                }
            }
        }

        public static Dictionary<string, string> Delete(string nameForDelete, Dictionary<string, string> dossier)
        {
            if (dossier.ContainsKey(nameForDelete) == true)
                dossier.Remove(nameForDelete);
            else
                Console.WriteLine("Такого досье не существует");
            return dossier;
        }

        public static void Show(Dictionary<string, string> dossier)
        {
            Console.WriteLine();

            foreach (var item in dossier)
            {
                Console.Write($"{item.Key} - {item.Value}");
            }

            Console.WriteLine();
        }

        public static void Exit(out bool exit)
        {
            exit = true;
        }

        public static void Search(string searchSurname, Dictionary<string, string> dossier)
        {
            Console.WriteLine();
            if (dossier.ContainsKey(searchSurname) == true)
            {
                Console.WriteLine(searchSurname + " " + dossier[searchSurname]);
                Console.WriteLine();
            }
        }

        public static Dictionary<string, string> AddDossier(Dictionary<string, string> dossier)
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

