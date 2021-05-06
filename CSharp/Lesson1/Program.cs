using System;

namespace App01
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 1
            /*
            1.Написать программу «Анкета».
            Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
            В результате вся информация выводится в одну строчку:
                а) используя склеивание;
                б) используя форматированный вывод;
                в) используя вывод со знаком $.
             */
            string firstName;
            string lastName;
            int age;
            double height;
            double weight;

            Console.Write("Введите ваше имя: ");
            firstName = Console.ReadLine();

            Console.Write("Введите вашу фамилию: ");
            lastName = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите ваш рост: ");
            height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ваш вес: ");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Name: " + firstName + ", Last name: " + lastName + ", Age: " + age + ", Height: " + height + ", Weight: " + weight);

            Console.WriteLine("Name: {0}, Last name: {1}, Age: {2}, Height: {3}, Weight: {4}", firstName, lastName, age, height, weight);

            Console.WriteLine($"Name: {firstName}, Last name: {lastName}, Age: {age}, Height: {height}, Weight: {weight}");

            #endregion

            #region 2

            /*
            2. Ввести вес и рост человека.
            Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
            где m — масса тела в килограммах, h — рост в метрах.
             */

            double indexOfMass;
            indexOfMass = weight / (height * height);
            Console.WriteLine($"Weight: {weight}, Height: {height}, Index of mass: {indexOfMass:F2}");
            #endregion

            #region 3

            /*
            3.
            а) Написать программу, которая подсчитывает расстояние между точками
            с координатами x1, y1 и x2, y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2 - y1, 2).
            Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
            б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
             */

            int x1;
            int x2;
            int y1;
            int y2;
            double result;

            Console.Write("Введите X1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите Y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите Х2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите Y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());

            result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"Расстояние между точками равно: {result:F2}");

            Console.WriteLine($"Расстояние между точками равно: {DistanceBetweenPoints(x1, x2, y1, y2):F2}");


            #endregion

            #region 4

            /*
            4. Написать программу обмена значениями двух переменных типа int
            без использования вспомогательных методов.
            а) с использованием третьей переменной;
            б) *без использования третьей переменной.
             */

            int number1 = 1;
            int number2 = 2;
            int number3;

            number3 = number1;
            number1 = number2;
            number2 = number3;

            Console.WriteLine($"{number1}, {number2}");

            int numberA = 1;
            int numberB = 2;


            numberA = numberA + numberB;
            numberB = numberA - numberB;
            numberA = numberA - numberB;

            Console.WriteLine($"{numberA}, {numberB}");

            #endregion

            #region 5

            /*
            5.
            а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            б) Сделать задание, только вывод организовать в центре экрана.
            в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x, int y).
             */

            string myName = "Michael";
            string myLastName = "Pogorelov";
            string myCity = "Zaporizhzhya";

            Console.WriteLine($"ваше имя: {myName}, фамилия: {myLastName}, город проживания: {myCity}");

            Console.Clear();
            Console.SetCursorPosition(50, 50);
            Console.WriteLine($"ваше имя: {myName}, фамилия: {myLastName}, город проживания: {myCity}");

            MyPrintInCenter($"ваше имя: {myName}, фамилия: {myLastName}, город проживания: {myCity}", 50, 50);

            #endregion

        }

        static double DistanceBetweenPoints(int x1, int x2, int y1, int y2)
        {
            double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return result;
        }


        static void MyPrintInCenter(string str, int left, int top)
        {
            Console.Clear();
            Console.SetCursorPosition(left, top);
            Console.WriteLine(str);
        }
    }
    #region 6

    /*
    6. *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
    */

    class MyVoids
    {
        static void MyPrint(string str)
        {
            Console.WriteLine(str);
        }

        static void MyPause()
        {
            Console.ReadLine();
        }
    }

    #endregion

}
