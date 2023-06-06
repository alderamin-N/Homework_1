namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 задание

            //объявление переменной размероности таблицы
            int n;
            //этот цикл проверяет на интервал от 1 до 6
            do
            {
                bool result;
                //этот цикл проверяет можно ли распарсить 
                do
                {
                    Console.WriteLine("Введите размерность таблицы от 1 до 6:");
                    var str = Console.ReadLine();
                    result = int.TryParse(str, out n);

                }
                while (result == false);

            }
            while ((n < 1) || (n > 6));

            //2 задание
            string text;

            do
            {
                Console.WriteLine("Введите произвольный текст: ");
                text = Console.ReadLine();
            }

            while (text == ""); //проверяет строка пустая или нет


            //количество char в строке из 2 задания
            //Console.WriteLine(text);
            //int length = text.Length;
            //Console.WriteLine(length);



            //вывод 1-ой строки
            int a = (n - 1) * 2 + text.Length + 2;
            int b = (n - 1) * 2 + 3;


            for (int i = 0; i < b; i++)
            {
                Console.Write("+"); // граница боковая слева

                for (int j = 0; j < a; j++)
                {
                    if (i == n && j == n)
                    {
                        Console.Write(text);
                        j = n - 1 + text.Length;

                    }

                    else if (i == 0)
                    {
                        Console.Write("+");
                    }
                    else if (i == b - 1)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.Write("+"); //граница боковая справа
                Console.Write("\n");
            }

            //вывод 2-ой строки
            //Вывести 2ю строку таблицы. Она имеет ту же высоту, что и строка 1,
            //и представляет собой набор символов +, чередующихся в шахматном порядке.

            int count = 1;
            int j1 = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("+");//левая граница
                for (j1 = 0; j1 < n; j1++)
                {
                    if ((j1 % 2 == 0) && (count % 2 == 0)) // четный count и четный j

                    { Console.Write("+"); }



                    if ((j1 % 2 != 0) && (count % 2 != 0))
                    {
                        Console.Write(" " + "+");
                    }

                    else { Console.Write(" "); }
                }


                count++;
                Console.Write("+");//правая граница
                Console.Write("\n");

            }


            //3 задача 
            //Вывести 3ю строку таблицы. Она должна быть квадратной, "перечеркнутая" символом + по диагоналям



            for (int i = 0; i <= n; i++)
            {

                if (i == 0 || i == n)
                {
                    for (int j = 0; (j < n && i == 0) || (j < n && i == n); j++) // первая и последняя строка заполняется
                    {
                        Console.Write("+");
                    }

                }
                Console.Write("+"); // заполняется граница - левая

                for (int j = n, l = 0; j > 0 && l < n; j--, l++)
                {


                    if (l + 1 == n)
                    {
                        Console.Write("+"); //заполняются граница -  правая

                    }

                    if (i == j)
                    {
                        Console.Write("+");  //слево направо диагональ

                    }
                    if (i == l)
                    {
                        Console.Write("+"); // справо налево диагональ

                    }
                    if (i != n && i != 0)
                        Console.Write(" ");//ставлю пробелы

                }

                Console.Write("\n");

            }
        }
    }

}
   
