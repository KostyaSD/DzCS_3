internal class Program
{
    private static int number = 0;
    private static bool program = true;

    private static void Main(string[] args)
    {
        Console.WriteLine("Выберите задачу:\n1.Задача 19\n2.Задача 21\n3.Задача 23");
        number = Convert.ToInt32(Console.ReadLine());

        while (program)
        {
            try
            {
                tasks(number);
                program = false;
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так!! повторите ввод данных!");
            }
        }

        static void tasks(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("Вы выбрали Задачу 19.\n" +
                                      "чтобы узнать является ли число полиндромом\n" +
                                      "Введите число: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    task19(number);
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали Задачу 21.\n" +
                                      "для определения расстояния между двумя точками\n" +
                                      "введите координаты точки" +
                                      " A (x1,y1,z1) и B(x2, y2, z2).");
                    Console.Write("Введите координату x1: ");
                    int x1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите координату y1: ");
                    int y1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите координату z1: ");
                    int z1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите координату x2: ");
                    int x2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите координату y2: ");
                    int y2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите координату z2: ");
                    int z2 = Convert.ToInt32(Console.ReadLine());
                    task21(x1, y1, z1, x2, y2, z2);
                    break;
                case 3:
                    Console.Write("Вы выбрали Задачу 23.\n" +
                                      "Чтобы задать таблицу кубов от 1 до N " +
                                      "\nВведите число N: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    task23(number);
                    break;
                default:
                    Console.WriteLine("Задача не найдена!");
                    break;
            }
        }

        static void task19(int num)
        {
            string textNumber = num.ToString();
            int lenght = textNumber.Length;
            int result = 0;
            for (int i = 0; i <= lenght / 2; i++)
            {
                if (textNumber[i] == textNumber[lenght - 1 - i])
                {
                    //Console.WriteLine($"цифры {textNumber[i]} и {textNumber[lenght - 1 - i]} совпали");
                }
                else
                {
                    //Console.WriteLine($"цифры {textNumber[i]} и {textNumber[lenght - 1 - i]} не совпали - число не полиндром");
                    result = 1;
                    break;
                }
            }
            if (result == 0) Console.WriteLine("Число полиндром");
            else Console.WriteLine("Число не полиндром");
            return;
        }

        static void task21(int x1, int y1, int z1,
                             int x2, int y2, int z2)
        {
            double d = Math.Pow((Math.Pow(x2 - x1, 2) +
                                 Math.Pow(y2 - y1, 2) +
                                 Math.Pow(z2 - z1, 2)), 0.5);
            d = Math.Round(d, 2);
            Console.WriteLine("Растояние между точками А и В" +
                              " в 3D пространстве = " + d);
            return;
        }

        static void task23(int N)
        {
            if (N > 0)
            {
                Console.WriteLine($"Таблица кубов чисел от 1 до {N}:");
                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)} ");
                }
            }
            else Console.WriteLine($"Число {N} не попало в интервал от 1"); ;
        }
    }
}