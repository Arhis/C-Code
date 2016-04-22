using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    class Employee : Data
    {
        String position;
        String education;
        String workTime;

        public override void EnterDataHuman()
        {
            base.EnterDataHuman();
            Console.Write("Какую должность вы занимаете в нашей фирме: \a");
            position = Console.ReadLine();
            Console.Write("Какое у вас образование:  \a");
            education = Console.ReadLine();
            Console.Write("Cколько лет вы работали в фирме: \a");
            workTime =Console.ReadLine();
            checkNumber(workTime);
            workTime = getString.ToString();
            Results();
            Loading();
            PrintYourResults();
        }

        public override void PrintYourResults()
        {
            base.PrintYourResults();
            Console.WriteLine("Ваша должность： " +position);
            Console.WriteLine("У вас " + education + " образование");
            Console.WriteLine("Вы проработали:  " + workTime + " года");
            EndProgram();
        }
       







    }
}
