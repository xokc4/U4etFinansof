using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4etFinansof
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mesaz = new string[] {"Январь",
         "Февраль",
         "Март",
         "Апрель",
         "Май",
         "Июнь",
         "Июль",
         "Август",
         "СентябрьСентябрь",
         "Октябрь",
         "Ноябрь",
         "Декабрь"};

            Random random = new Random();
            int[] Dohod = new int[11];// массив дохода
            int[] rashod = new int[11];// массив расходов
            int[] pribol = new int[11];// массив прибыли

            for (int i = 0; i < Dohod.Length; i++)// цикл создания информации в массиве доходов
            {
                Dohod[i] = random.Next(100000, 500000);
                Console.WriteLine($"доход  {Dohod[i]}");
            }
            Console.WriteLine();

            for (int i = 0; i < rashod.Length; i++)// цикл создания информации в массиве расходов
            {
                rashod[i] = random.Next(100000, 300000);
                Console.WriteLine($"расход {rashod[i]}");
            }
            Console.WriteLine();
            for (int i = 0; i < pribol.Length; i++)// цикл создания информации в массиве прибыли
            {
                rashod[i] = Dohod[i] - rashod[i];

                Console.WriteLine($"прибыль {rashod[i]}");

            }
            Console.WriteLine();


            Array.Sort(rashod);// сортировка массива
            for (int i = 0; i < 3; i++)// цикл по определению с тремя месяцами с наименьшей прибылью
            {
                Console.WriteLine("месяц с отрицательной прибылью "+mesaz[i]+"   "+rashod[i]);
            }
            Console.WriteLine();

            int polowitMesaz = 0;
            int otrizatelnieMesaz = 0;
            for (int i = 0; i < rashod.Length; i++)// цикл по кол отрицательного дохода и положительного
            {


                if (rashod[i] < 0)
                {
                    otrizatelnieMesaz++;

                }
                if (rashod[i] > 0)
                {
                    polowitMesaz++;
                }
            }
            Console.WriteLine("количество месяцев с отрицательной прибылью:  " + otrizatelnieMesaz);
            Console.WriteLine("количество месяцев с положительной прибылью:  " + polowitMesaz);

            Console.ReadKey();

        }
       

    }
}
