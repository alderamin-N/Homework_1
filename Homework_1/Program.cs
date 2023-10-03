using System.Drawing;
using System.Globalization;

namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность таблицы от 1 до 6:");
            var str = Console.ReadLine();
            int number;
            if ((int.TryParse(str, out number ) == false) || (number <1) || (number>6))
            {
                do
                {
                    Console.WriteLine("Вы ввели неверно! Повторите попытку!");
                    Console.WriteLine("Введите размерность таблицы от 1 до 6:");
                    str = Console.ReadLine();
                    int.TryParse(str, out number);
                }
                while ((int.TryParse(str, out number) == false) || (number < 1) || (number > 6));
            }
            string text;
            do
            {
                Console.WriteLine("Введите произвольный текст: ");
                text = Console.ReadLine();
            }
            while (text == "");

            Console.WriteLine("размер слов = " + text.Length);
            int width = (number - 1) * 2 +(text.Length) + 2;//ширина таблицы
            int height = (number - 1)* 2 + 3; // высота таблицы
            if (width >40)
            {
                Console.WriteLine("Ширина таблицы не может быть больше 40 символов!");
            }
            //program 1
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    if (j == 0 || j == height - 1)
                    {
                        Console.Write("+");
                    }
                    else if (i == 0 || i == width - 1)
                    {
                        Console.Write("+");
                    }
                    else if (i == number && j == number)
                    {
                        Console.Write(text);
                        i = number - 1 + text.Length;
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
            //program 2
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    //if (j == 0 || j == height - 1)
                    //{
                    //    Console.Write("+");
                    //}
                    if (i == 0 || i == width - 1)
                    {
                        Console.Write("+");
                    }
                    else if ((j % 2 == 0) && (i % 2 != 0))
                    {
                        Console.Write(" " + "+");
                    }
                    else if ((j % 2 != 0) && (i % 2 == 0))
                    {
                        Console.Write("+" + " ");
                    }
                }
                Console.WriteLine();
            }
            //program 3
            int n = 1;
            for (int j = 0; j < width; j++)
            {
                for (int i = 0; i < width; i++)
                {                  
                    if (j == 0 || j == width - 1)
                    {
                        Console.Write("+");
                    }
                    else if (i == 0 || i == width - 1)
                    {
                        Console.Write("+");
                    }
                    else if (j == i)
                    {
                        Console.Write("+");
                    }
                    else if (i == width - n - 1 && j == n || i == width - n - 2 && j == n + 1)
                    {
                        Console.Write("+");
                        n++;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
   
