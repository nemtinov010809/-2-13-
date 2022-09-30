namespace Average_GeametricMean
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a, b;
            //Ввод первого числа
            Console.Write("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());
            //Ввод второго числа
            Console.Write("Enter b: ");
            b = Convert.ToInt32(Console.ReadLine());
            //Нахождения модуля чисел
            if (a < 0)
                a = -a;
            if (b < 0)
                b = -b;
            //Нахождение и вывод среднего арифметического
            Console.WriteLine("Среднее арифметическое модулей числа a и b: {0:F}", (a + b) / 2);
            //Нахождение и вывод среднего геометрического
            Console.WriteLine("Среднее геометрическое модулей числа a и b: {0:F}", Math.Sqrt(a * b));
        }
    }
}
