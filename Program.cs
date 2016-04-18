/* Программа подсчитывет зарплату
 * в зависимости от количества отработанных лет.
 * В коде применятся такие базовые ООП концепции как инкапсуляция и наследование
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GetYourSalary getCode = new GetYourSalary();
            getCode.GetData();      
        }
       
    }
}
