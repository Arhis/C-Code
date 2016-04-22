/*Здесь находятся все методы которые я использую в программе*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Office
{
    class Data : Human
    {
        public int getString; //Используется для получения данных и присвоению результатов в переменные в методе checkNumber
        public String divarication; //Переменая в Меню которая записывает значение (1-3) кто из людей будет выбран
         
        //Шапка программы
        public void Hat()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Coordinates horizontalTop = new Coordinates(15, 1, '+', 50);
            horizontalTop.DrownHorizontal();

            Coordinates verticalLeft = new Coordinates(16, 1, '+', 4);
            verticalLeft.DrowVertical();

            Coordinates horizontalBottom = new Coordinates(15, 6, '+', 50);
            horizontalBottom.DrownHorizontal();

            Coordinates verticalRight = new Coordinates(65, 1, '+', 4);
            verticalRight.DrowVertical();

            Coordinates vertical2 = new Coordinates(17, 1, '+', 4);
            vertical2.DrowVertical();

            Coordinates vertical3 = new Coordinates(64, 1, '+', 4);
            vertical3.DrowVertical();
            Console.BackgroundColor = ConsoleColor.Black;

            Console.SetCursorPosition(31, 3);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Офисное приложение");            
        } 
       

       /*Метод ввода данных со стороны пользователя */
        public virtual void EnterDataHuman()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nВведите ваше имя: \a");
            name = Console.ReadLine();

            Console.Write("Введите вашу фамилию: \a");
            surname = Console.ReadLine();

            Console.Write("Введите ваш возраст: \a");
            age = Console.ReadLine();                        
            checkNumber(age);
            age = getString.ToString();

            Console.Write("Укажите ваш пол: \a");
            gender = Console.ReadLine();            
        }

        //Вывод введенных данных пользователем

        public virtual void PrintYourResults()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\a\aРезультаты вашего ввода");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
            Console.WriteLine("Имя： "+name);
            Console.WriteLine("Фамилия: "+surname);
            Console.WriteLine("Возраст： "+age);
            Console.WriteLine("Пол: "+gender);            
        }      

        //Метод размещения строки на экране с заданными координатами и цветом текста
        public void DrawText(int x, int y, String message, int textColor)
        {
            if (textColor == 1)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }           
            if (textColor == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }            

            Console.SetCursorPosition(x, y);
            Console.Write(message);
        }

        //Проверка на ввод числового значения и его коррекция в случае необходимости
        public void checkNumber(String _x)
        {
            getString = 0;
            try
            {
                getString = int.Parse(_x);
            }
            catch (FormatException)
            {

                while (getString <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\a \a \a");
                     
                    Console.Write("Неправильный ввод, пожалуйста введите число: ");
                    Console.ResetColor();
                    _x = Console.ReadLine();
                    try
                    {

                        getString = int.Parse(_x);

                    }
                    catch (FormatException)
                    {
                    }
                }
            }            
        }       

        ///2016
        public void Num2016()
        {
            //2
            DrawText(20, 8, "8", 1);
            DrawText(21, 8, "8", 1);
            DrawText(22, 8, "8", 1);
            DrawText(22, 9, "8", 1);
            DrawText(22, 10, "8", 1);
            DrawText(21, 10, "8", 1);
            DrawText(20, 10, "8", 1);
            DrawText(20, 11, "8", 1);
            DrawText(20, 12, "8", 1);
            DrawText(21, 12, "8", 1);
            DrawText(22, 12, "8", 1);

            //0
            DrawText(24, 8, "8", 1);
            DrawText(25, 8, "8", 1);
            DrawText(26, 8, "8", 1);
            DrawText(26, 9, "8", 1);
            DrawText(26, 10, "8", 1);
            DrawText(26, 11, "8", 1);
            DrawText(26, 12, "8", 1);
            DrawText(25, 12, "8", 1);
            DrawText(24, 12, "8", 1);
            DrawText(24, 11, "8", 1);
            DrawText(24, 10, "8", 1);
            DrawText(24, 9, "8", 1);

            //1
            DrawText(28, 8, "8", 1);
            DrawText(29, 8, "8", 1);
            DrawText(29, 9, "8", 1);
            DrawText(29, 10, "8", 1);
            DrawText(29, 11, "8", 1);
            DrawText(29, 12, "8", 1);

            //6            
            DrawText(34, 8, "8", 1);
            DrawText(33, 8, "8", 1);
            DrawText(32, 8, "8", 1);
            DrawText(32, 9, "8", 1);
            DrawText(32, 10, "8", 1);
            DrawText(32, 11, "8", 1);
            DrawText(32, 12, "8", 1);
            DrawText(33, 10, "8", 1);
            DrawText(34, 10, "8", 1);
            DrawText(34, 11, "8", 1);
            DrawText(34, 12, "8", 1);
            DrawText(33, 12, "8", 1);
        }

        //Меню программы
        public void Menu()
        {
            Num2016();
            DrawText(3, 11, "1: Школьник", 2);
            DrawText(3, 12, "2: Работник", 2);
            DrawText(3, 13, "3: Директор", 2);
            DrawText(2, 15, "*", 2);
            DrawText(4, 15, "Введите число, того кого вы хотите описать（1-3)： ", 1);
            divarication = Console.ReadLine();
            checkNumber(divarication);
            CheckMenuNummber(); 
        }

        //Метод определяющий действие для каждой комбинации цыфр от (1-3)
        public void CheckMenuNummber()
        {
            switch (getString)
            {
                case 1:
                    Pupil pupil = new Pupil();
                    pupil.EnterDataHuman();
                    break;
                case 2:
                    Employee employee = new Employee();
                    employee.EnterDataHuman();
                    break;
                case 3:
                    Employer employer = new Employer();
                    employer.EnterDataHuman();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Неверный ввод, нажмите Enter\a\a\a");
                    Console.ResetColor();
                    Console.ReadLine();
                    Hat();
                    Menu();
                    break;
            }
        }

        //Опция = Нажмите Enter чтобы получить результаты
        public void Results()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\a\a Пожалуйста, нажмите Enter чтобы получить результаты");
            Console.ResetColor();
            Console.ReadLine();
        }

        //Метод Loading
        public void Loading()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(35, 10);
            String loading = "Loading";
            Console.Write(loading);
            for (int i = 1; i <= 3; i++)
            {
                Thread.Sleep(800);
                Console.Write(".");
            }
            Thread.Sleep(800);
            Console.ResetColor();
        }

        //Завершение работы программы
        public void EndProgram()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nПрограмма завершена, пожалуйста нажмите Enter чтобы выйти");
            Console.ReadLine();
        }
    }
 }

