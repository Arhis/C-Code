using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    class Coordinates
    {
        public int x; //Координата X
        public int y; //Координата Y
        char sym; //Передаваемый символ
        int length; // Длина риcсуемой линии

        /*Конструктор который принемает координаты*/
        public Coordinates(int x, int y, char sym, int length)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
            this.length = length;
        }

        

        //Метод проресовывает горизонтальные линии
        public void DrownHorizontal()
        {   
            for (int i = 1; i <= length; i++)
            {
                Console.SetCursorPosition(x+i, y);
                Console.Write(sym);
            }
        }

        //Метод проресовывает вертикальные линии
        public void DrowVertical()
        {
            for (int i = 1; i <= length; i++)
            {
                Console.SetCursorPosition(x, y+i);
                Console.Write(sym);
            }             
        }
    }
}
