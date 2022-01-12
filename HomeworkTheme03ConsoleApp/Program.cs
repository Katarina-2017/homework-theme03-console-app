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
        }
    }
}
