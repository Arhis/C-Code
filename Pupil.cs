using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Office
{
    class Pupil : Data
    {
        String schoolTime;
        String parentsCount;         
        public override void EnterDataHuman()
        {
            base.EnterDataHuman();           
            Console.Write("Сколько часов у вас отнимает школа?： \a");
            schoolTime = Console.ReadLine();
            checkNumber(schoolTime);
            schoolTime = getString.ToString();
            Console.Write("Сколько у вас родителей： \a");
            parentsCount = Console.ReadLine();
            checkNumber(parentsCount);
            parentsCount= getString.ToString();
            Results();
            Loading();
            PrintYourResults();                                       
        }
        public override void PrintYourResults()
        {
            base.PrintYourResults();
            Console.WriteLine("Школа отнимает у вас "+schoolTime+" часов");
            Console.WriteLine("У вас " +parentsCount+" родителей");
            Console.WriteLine("");
            EndProgram();            
        }
    }
}
