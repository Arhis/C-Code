using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**/
namespace First
{
    class GetYourSalary :Basic
    {
        
        public void GetData()
        { 
            Console.Write("Type your name: ");
            String name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hi " + name + "!");
            Console.WriteLine("");         

            Console.Write("How many years have you been working in the company?: ");
            String typedWorkYears = Console.ReadLine();
            try
            {
                workYears = int.Parse(typedWorkYears);
            }
            catch(FormatException)
            {
                Console.WriteLine("Некорректный ввод, пожалуйста, введите число, программа завершает работу...нажмите Enter\a\a\a");
                Console.Read();
                Environment.Exit(0);            
            }
            CountYourSalary();
            
        }
    }
}
