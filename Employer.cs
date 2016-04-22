using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    class Employer : Data
    {
        String experience;
        String inferiorsCount;

        public override void EnterDataHuman()
        {
            
            base.EnterDataHuman();
            Console.Write("Сколько лет вы директор данной фирмы: \a");
            experience = Console.ReadLine();
            checkNumber(experience);
            experience = getString.ToString();
            Console.Write("Сколько подчиненных в вашем распаряжении: \a");
            inferiorsCount = Console.ReadLine();
            checkNumber(inferiorsCount);
            inferiorsCount = getString.ToString();
            Results();
            Loading();
            PrintYourResults();
        }
        public override void PrintYourResults()
        {
            base.PrintYourResults();
            Console.WriteLine("Вы директор " + experience + " года");
            Console.WriteLine("у вас " + inferiorsCount+ " подчинённых"); 
            EndProgram();
        }

    }
}
