using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR11
{
    class Program
    {
        static void Main(string[] args)
        {

            // Дано количество часов, минут и секунд (1 час = 60 минут, 1 минута = 60 секунд). 
            //Вычислить и вывести общее количество секунд с начала суток.


            Console.WriteLine("\tВариант 5\n\n\tзадание 1");
        m100:
            Console.Write("Введите количество часов: ");
            int Ch;

            try
            {
                Ch = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException exception)
            {
                Console.WriteLine("METHOD - " + exception.TargetSite.ToString()); //метод
                Console.WriteLine("MESSAGE - " + exception.Message.ToString()); //сообщение об ошибке
                Console.WriteLine("SOURCE - " + exception.Source.ToString()); //источник ошибки
                Console.WriteLine("DATA - " + exception.Data.ToString());   //дополнит информация
                Console.WriteLine("STACK - " + exception.StackTrace.ToString());
            }
            //if (Ch < 0)
            //{
            //    Console.Write("Ошибка. Введенное вами число не корректно. Попробуйте снова.\n");
            //    goto m100;
            //}

        m200:
            Console.Write("Введите количество минут: ");
            int Min = Convert.ToInt32(Console.ReadLine());

            if (Min < 0)
            {
                Console.Write("Ошибка. Введенное вами число не корректно. Попробуйте снова.\n");
                goto m200;
            }

        m300:
            Console.Write("Введите количество секунд: ");
            int Sek = Convert.ToInt32(Console.ReadLine());

            if (Sek < 0)
            {
                Console.Write("Ошибка. Введенное вами число не корректно. Попробуйте снова.\n");
                goto m300;
            }

            double Otv = Ch * 3600 + Min * 60 + Sek;
            Console.WriteLine("Количество секунд с начала суток: {0}\n\n\n\n", Otv);


            //Проверить истинность высказывания: "Сумма двух первых цифр данного 
            //четырехзначного целого положительного числа равна сумме двух его последних цифр".

            Console.WriteLine("\tзадание 2");

        m400:
            Console.Write("Введите четырехзначное целое положительное число:");
            int D = Convert.ToInt32(Console.ReadLine());

            if (D < 0 || D > 10000 || D < 999)
            {
                Console.Write("Ошибка. Введенное вами число не корректно. Попробуйте снова.\n");
                goto m400;
            }

            int a1 = D / 1000;
            int a2 = (D / 100) % 10;
            int b1 = (D / 10) % 10;
            int b2 = D % 10;
            int A = a1 + a2;
            int B = b1 + b2;

            if (A == B) Console.WriteLine("Да. Числа равны\n\n\n\n");
            else Console.WriteLine("Нет. Числа не равны\n\n\n\n");

            

            //Единицы длины пронумерованы следующим образом: 1 - дециметр, 2 - километр, 3 - метр, 
            //4 - миллиметр, 5 - сантиметр. Дан номер единицы длины (целое число в диапазоне от 1 до 5)
            //и длина отрезка в этих единицах (вещественное число). Найти длину отрезка в метрах.
            Console.WriteLine("\tзадание 2");

        m500:
            double Otv2;
        Console.Write("1 - дециметр, 2 - километр, 3 - метр, 4 - миллиметр, 5 - сантиметр\nВедите число от 1 до до 5: ");
            int Vk = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите длину отрезка: ");
            double Lin = Convert.ToDouble(Console.ReadLine());

            if (Vk < 0 ||  Vk > 5 )
            {
                Console.Write("Ошибка. Введенное вами число не корректно. Попробуйте снова.\n");
                goto m500;
            }

            switch (Vk)
            {
                case 1: goto m501; 
                case 2: goto m502; 
                case 3: goto m503; 
                case 4: goto m504; 
                case 5: goto m505;
            }

        m501:
            Otv2 = Lin / 10;
            goto end;

        m502:
            Otv2 = Lin * 1000;
            goto end;

        m503:
            Otv2 = Lin * 1;
            goto end;

        m504:
            Otv2 = Lin /1000;
            goto end;

        m505:
            Otv2 = Lin /100;
            goto end;

        end:
            Console.WriteLine("Длина отрезка в метрах равна: {0}", Otv2);

        }
    }
}
