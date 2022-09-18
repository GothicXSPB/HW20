namespace Lesson16
{
    public class Calculator
    {
        //1.Метод получает на вход 3 числа (A, B и С). Верните решение(значение X) линейного уравнения стандартного вида, где A*X+B=C.
       
        public static double SolutionLinearEquations(double a, double b, double c)
        {
            double result = 0;
            if (a == 0)
            {
                throw new ArgumentException("First argument cannot be 0");
            }
            result = (c - b) / a;
            return result;
        }

        //2.Метод получает на вход  2 числа (A и B). Если A больше B, подсчитать A+B, если A равно B, подсчитать A*B, если A меньше B, подсчитать A-B.

        public static int BiggerOrLess(int a, int b)
        {
            int result = 0;
            if (a > b)
            {
                result = a + b;
            }
            if (b > a)
            {
                result = a - b;
            }
            if (a == b)
            {
                result = a * b;
            }
            return result;
        }

        //3.Метод получает на вход двузначное число.Верните прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”.

        public static void NumbersInWords(int number)
        {
            string aa = "один";
            string bb = "два";
            string cc = "три";
            string dd = "четыре";
            string ee = "пять";
            string ff = "шесть";
            string gg = "семь";
            string hh = "восемь";
            string ii = "девять";
            string jj = "десять";
            string a = "двадцать";
            string b = "тридцать";
            string c = "сорок";
            string d = "пятьдесят";
            string e = "шестьдесят";
            string j = "семьдесят";
            string f = "восемьдесят";
            string g = "девяносто";

            number = Convert.ToInt32(number);

            if (number >= 10 && number <= 19)
            {
                switch (number)
                {
                    case 10:
                        Console.WriteLine(jj);
                        break;
                    case 11:
                        Console.WriteLine("одинадцать");
                        break;
                    case 12:
                        Console.WriteLine("двенадцать");
                        break;
                    case 13:
                        Console.WriteLine("тринадцать");
                        break;
                    case 14:
                        Console.WriteLine("четырнадцать");
                        break;
                    case 15:
                        Console.WriteLine("пятнадцать");
                        break;
                    case 16:
                        Console.WriteLine("шестнадцать");
                        break;
                    case 17:
                        Console.WriteLine("семнадцать");
                        break;
                    case 18:
                        Console.WriteLine("восемнадцать");
                        break;
                    case 19:
                        Console.WriteLine("девятнадцать");
                        break;

                }
            }
            if (number >= 20 && number <= 99)
            {
                int tens = number / 10;
                int units = number % 10;
                switch (tens)
                {
                    case 2:
                        Console.WriteLine(a + " ");
                        break;
                    case 3:
                        Console.WriteLine(b + " ");
                        break;
                    case 4:
                        Console.WriteLine(c + " ");
                        break;
                    case 5:
                        Console.WriteLine(d + " ");
                        break;
                    case 6:
                        Console.WriteLine(e + " ");
                        break;
                    case 7:
                        Console.WriteLine(j + " ");
                        break;
                    case 8:
                        Console.WriteLine(f + " ");
                        break;
                    case 9:
                        Console.WriteLine(g + " ");
                        break;
                }
                switch (units)
                {
                    case 1:
                        Console.WriteLine(aa);
                        break;
                    case 2:
                        Console.WriteLine(bb);
                        break;
                    case 3:
                        Console.WriteLine(cc);
                        break;
                    case 4:
                        Console.WriteLine(dd);
                        break;
                    case 5:
                        Console.WriteLine(ee);
                        break;
                    case 6:
                        Console.WriteLine(ff);
                        break;
                    case 7:
                        Console.WriteLine(gg);
                        break;
                    case 8:
                        Console.WriteLine(hh);
                        break;
                    case 9:
                        Console.WriteLine(ii);
                        break;
                }

            }

        }

        //4.Метод получает на вход число. Проверить попадает ли оно в один из диапазонов: от 0 до 10, от 20 до 30 или от 40 до 50. *Здесь хорошим вариантом будет вернуть true или false.

        public static bool CheckRange(int digital)
        {
            if (digital >= 0 && digital <= 10)
            {
                Console.WriteLine("Число попадает в выбранные диапазоны");
            }
            else if (digital >= 20 && digital <= 30)
            {
                Console.WriteLine("Число попадает в выбранные диапазоны");
            }
            else if (digital >= 40 && digital <= 50)
            {
                Console.WriteLine("Число попадает в выбранные диапазоны");
            }
            else
            {
                Console.WriteLine("Число не попадает в выбранные диапазоны");
                return false;
            }
            return true;
        }

        //5.Метод получает на вход 2 числа (A и B). Верните сумму всех чисел из диапазона от A до B, которые делятся на 7.

        public static int SumDigitalFissileOnSeven(int a, int b)
        {
            int temp = 0;

            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    temp += i;
                }
            }
            return temp;
        }

        //6.Метод получает на вход положительное число (N). Верните N-ое число ряда Фибоначчи.

        public static int NumberOfFibonacci(int n)
        {
            int a = 0;
            int b = 1;

            if(n<1)
            {
                throw new ArgumentOutOfRangeException("Argument cannot be less than 1");
            }

            for (int i = 1; i <= n - 1; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return b;
        }

        //7.Метод получает на вход число. Найти количество нечетных цифр этого числа.

        public static int NumberOfOddNumbers(int a)
        {
            int x = 0;

            while (a != 0)
            {
                int temp = a % 10;
                if (temp % 2 != 0)
                {
                    x++;
                }
                a /= 10;
            }
            return x;
        }

        //8.Метод получает на вход число. Найти число, которое является зеркальным

        public static int MirrorDigital(int a)
        {
            int x = 0;

            while (a != 0)
            {
                int temp = 0;
                if (a > 0)
                {
                    temp = a % 10;
                    a /= 10;
                    x += temp;
                    x *= 10;
                }
            }
            return x / 10;
        }

        //9.Метод получает на вход 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры. Например, для пары 123 и 345, ответом будет являться true, а, для пары 500 и 999 - false.

        public static bool CompareNumbers(int a, int b)
        {
            if (a > b)
            {
                int tmp = b;
                b = a;
                a = tmp;
            }

            while (a != 0)
            {
                int temp = a % 10;
                while (b != 0)
                {
                    int temp2 = b % 10;
                    if (temp == temp2)
                    {
                        return true;
                    }
                    b /= 10;
                }
                a /= 10;
            }
            return false;
        }

        public static int ReadDigital()
        {
            string a = Console.ReadLine();
            int digital = Convert.ToInt32(a);
            return digital;
        }

        public static void WriteRes(int digital)
        {
            Console.WriteLine(digital);
        }
    }
}