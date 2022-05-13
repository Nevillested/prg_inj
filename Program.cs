using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_inj2
{
    class Program
    {
        static public string Comand;
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Введите необходимый пункт меню");
                Console.WriteLine("1-добавление записей в массив");
                Console.WriteLine("2-удаление записей из массива");
                Console.WriteLine("3-вывод массива на экран");
                Console.WriteLine("4-фильтрация массива по заданному пользователем коду детали");
                Console.WriteLine("5-поиск суммарного количества по заданному коду детали");
                Console.WriteLine("6-сортировка по полю «адрес ячейки»");
                Comand = Console.ReadLine();
                if (Comand == "1")
                {
                    Console.WriteLine("Выбран первый пункт");
                    ArrayList list = new ArrayList();
                    list.Add(2.3); // заносим в список объект типа double
                    list.Add(55); // заносим в список объект типа int
                    list.AddRange(new string[] { "Hello", "world" }); // заносим в список строковый массив

                    // перебор значений
                    foreach (object o in list)
                    {
                        Console.WriteLine(o);
                    }

                    // удаляем первый элемент
                    list.RemoveAt(0);
                    // переворачиваем список
                    list.Reverse();
                    // получение элемента по индексу
                    Console.WriteLine(list[0]);
                    // перебор значений
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(list[i]);
                    }

                    Console.ReadLine();
                }
                else if (Comand == "2")
                {
                    Console.WriteLine("Выбран второй пункт");
                    Comand = Console.ReadLine();

                }
                else if (Comand == "3")
                {
                    Console.WriteLine("Выбран третий пункт");
                    Comand = Console.ReadLine();

                }
                else if (Comand == "4")
                {
                    Console.WriteLine("Выбран четвертый пункт");
                    Comand = Console.ReadLine();

                }
                else if (Comand == "5")
                {
                    Console.WriteLine("Выбран пятый пункт");
                    Comand = Console.ReadLine();

                }
                else if (Comand == "6")
                {
                    Console.WriteLine("Выбран шестой пункт");
                    Comand = Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Введите номер пункта!");
                }
            }
        }
    }
}
