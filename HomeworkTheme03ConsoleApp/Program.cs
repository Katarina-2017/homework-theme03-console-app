using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTheme03ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Задача 1 \n");
            // Вывод поясняющей надписи
            // Ввод и преобразование числа, веденного с клавиатуры в целый тип данных
            Console.WriteLine("Введите целое число: ");
            int startNumber = int.Parse(Console.ReadLine());

            //Проверка введенного числа на четность
            if (startNumber % 2 == 0)
            {
                Console.WriteLine($"Введенное вами число {startNumber} - четное.");
            }
            else
            {
                Console.WriteLine($"Введенное вами число {startNumber} - нечетное.");
            }

            Console.ReadKey();

            //вывод поясняющей надписи
            //Ввод и преобразование числа, веденного с клавиатуры в целый тип данных-количество карт
            Console.WriteLine("\n Задача 2 \n");
            Console.Write("Приветсвуем вас в игре Blackjack! Сколько у вас карт на руках? ");
            int interval = int.Parse(Console.ReadLine());

            Console.WriteLine("\tЕсли у вас карта с числовым номиналом, введите цифру." +
                              "\n\tЕсли у вас валет - введите J. " +
                              "\n\tЕсли у вас дама - введите Q. " +
                              "\n\tЕсли у вас король - введите K. " +
                              "\n\tЕсли у вас туз - введите T.");

            //создание переменной userString строкового типа, для хранения введенной с клавиатуры строки
            //создание целочисленных переменных для хранения суммы всех карт amount и веса картинки weight
            string userString;
            int amount=0;
            int weight = 10;

            //ввод номинала каждой карты
            for (int i = 1; i < interval+1; i++)
            {
                Console.WriteLine($"Введите номинал {i}-ой карты:");
                userString=Console.ReadLine();
                //нахождение суммы всех карт, которые есть на руках у пользователя
                switch (userString)
                {
                    case "J": amount += weight;break;
                    case "Q": amount += weight; break;
                    case "K": amount += weight; break;
                    case "T": amount += weight; break;
                    default:
                        int numberCard = int.Parse(userString);
                        amount += numberCard;break;
                }
            }
            //вывод найденной суммы на экран
            Console.WriteLine($"Cуммa всех карт у вас на руках: {amount}");
            Console.ReadKey();

            Console.WriteLine("\n Задача 3 \n");
            Console.WriteLine("Введите целое число: ");
            int userNumber = int.Parse(Console.ReadLine());

            int counter = 2;
            bool checkPrime = false;

            while (counter <= userNumber-1)
            {
                if (userNumber % counter == 0)
                {
                    checkPrime = true;
                }
                counter++;
            }

            if (checkPrime == false)
            {
                Console.WriteLine($"Введенное число {userNumber} - простое");
            }
            else
            {
                Console.WriteLine($"Введенное число {userNumber} - не простое");
            }

            Console.ReadKey();
        }
    }
}
