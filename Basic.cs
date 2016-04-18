using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Basic
    {
        private double salary = 8000.42;
        private int grows = 2000;
        public int workYears = 0;

        public void CountYourSalary()
        {
            if (workYears >= 1)
            {
                for (int i = workYears; i != 1; i--)
                {
                    salary = salary + grows;
                }

                Console.Write("Your salary: " + salary + "$\a");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Вы ввели ноль или отрицательное число, программа завершает работу, нажмите Enter\a\a\a");
                Console.ReadLine();
            }
        }
    }
}
