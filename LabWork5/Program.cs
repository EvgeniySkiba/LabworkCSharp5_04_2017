using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork5
{
    class Program
    {
        // использхуем только здесь 
        private static House[] houseArray = null;

        // делегат
        private delegate int PrintMenuDelegate();

        /// <summary>
        ///  выбор пункта меню
        /// </summary>
        /// <returns></returns>
        static int ChoiseMenu()
        {
            int chose = -1;

            do
            {
                PrintMenu();
                chose = Convert.ToInt32(Console.ReadLine());

            } while (chose < 0 || chose > 2);

            return chose;

        }



        static void PrintMenu()
        {
            Console.WriteLine("Plese choise action: ");

            Console.WriteLine("1. Read ");
            Console.WriteLine("2. Find");
            Console.WriteLine("0. Exit ");
        }


        public static int Main(string[] args)
        {
            PrintMenuDelegate del = new PrintMenuDelegate(ChoiseMenu);

            int choise = del.Invoke();

            do
            {
                // согласно заданию все действия прроихзводятся в этом классе 
                House house = new House();
                switch (choise)
                {
                    case 1:
                        Console.WriteLine("Enter the array size : ");
                        int size = Convert.ToInt32(Console.ReadLine());

                        // если некорректное значение при вводе -  миниму м один элемент 
                        if (size < 0)
                            size = 1;

                        // согласно задания в качестве параметра будет передаваться массив типа house 
                        houseArray = new House[size];

                        // массив есть можем вызвать ввод 
                        house.Read(houseArray, size);
                        choise = del.Invoke();
                        break;

                    case 2:
                        {
                            // если массива нету - показать главное меню 
                            if (houseArray == null || houseArray.Length < 1)
                            {
                                choise = del.Invoke();
                            }

                            // иначе ищем 

                            Console.WriteLine("Pleace enter vladelec : ");
                            String vladelec = Console.ReadLine();
                            house.Poisk(houseArray, houseArray.Length, vladelec);
                            choise = del.Invoke();
                            break;
                        }

                    default:
                        break;
                }
            } while (choise != 0);

            Console.WriteLine("Press any key to continue ....");
            Console.ReadLine();

            return 0;
        }


    }
}
