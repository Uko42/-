using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {         
            GetResult();
            Console.ReadKey();

            /*/  int fr = 1;
            Console.WriteLine("Введите число факториал которого вы хотите рассчитать");
            int lim = Convert.ToInt32(Console.ReadLine());
            lim++;
            for (int i = 1; i < lim; i++)
            {


                Console.WriteLine($"Факториал числа {i} равен {fr * i}");
                fr = fr * i;
            }
            Console.ReadKey(); /*/
        }

        static void GetData(int x, int y, out int sum, out int minus, out int mult, out int div)
         {
             mult = x * y;
             sum = x + y;
             div = x / y;
             minus = x - y;
            //Console.WriteLine($"ответ {sum} {mult} {minus} {div}");

        }
        static void GetResult()

         {
            /*/ Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите символ арифметической операции");
            string ArOperator = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            /*/
            Console.WriteLine("Введите выражение");
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    
            if (Int32.TryParse(words[0], out int a))
            {
                a = Convert.ToInt32(words[0]);
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
                return;
            }


            if (Int32.TryParse(words[2], out int b))
            {
                b = Convert.ToInt32(words[2]);
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
                return;
            }


            string ArOperator = words[1];
            GetData(a, b, out int sum, out int minus, out int mult, out int div);
             switch (ArOperator)
             {
                 case "*":
                     Console.WriteLine($"Ответ: {mult}");
                     break;
                 case "+":
                     Console.WriteLine($"Ответ: {sum}");
                     break;
                 case "-":
                     Console.WriteLine($"Ответ: {minus}");
                     break;

                 case "/":
                     Console.WriteLine($"Ответ: {div}");
                     break;
                 case "\\":
                     Console.WriteLine("Возможно вы имели ввиду деление?");
                     goto case "/";
                 default:
                     Console.WriteLine("Вы ввели не распознанный символ, попробуйте еще раз");
                     GetResult();
                     break;

                 
            }
         }
     }
 }
