namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("\nДоступные операции:\n" +
                    "1 - Сложить 2 числа\n" +
                    "2 - Вычесть первое из второго\n" +
                    "3 - Перемножить два числа\n" +
                    "4 - Разделить первое на второе\n" +
                    "5 - Возвести в степень N первое число, где N равно второму числу\n" +
                    "6 - Найти квадратный корень из числа\n" +
                    "7 - Найти 1% от числа\n" +
                    "8 - Найти факториал из числа\n" +
                    "9 - Выйти из программы\n");

                Console.WriteLine("\nВыберите операцию: ");
                string operation = Console.ReadLine();
                int операция = Convert.ToInt32(operation);

            while (операция != 9)
            {

                // для первых двуз операций нужны оба числа
                if (операция == 1 || операция == 2 || операция == 3 || операция == 4 || операция == 5)
                {
                    Console.WriteLine("\nВведите первое число: ");
                    string num_1 = Console.ReadLine();
                    double число_1 = Convert.ToDouble(num_1);

                    Console.WriteLine("\nВведите второе число: ");
                    string num_2 = Console.ReadLine();
                    double число_2 = Convert.ToDouble(num_2);

                    // используем оператор выбора 
                    switch (операция)
                    {
                        case 1:
                            Console.WriteLine($"\n{число_1}+{число_2} = {число_1 + число_2}");
                            break;
                        case 2:
                            Console.WriteLine($"\n{число_2}-{число_1} = {число_2 - число_1}");
                            break;
                        case 3:
                            Console.WriteLine($"\n{число_1}*{число_2} = {число_1 * число_2}");
                            break;
                        case 4:
                            if (число_2 == 0)
                            {
                                Console.WriteLine("Ошибка! Деление на 0 недопустимо.");
                            }
                            else
                            {
                                Console.WriteLine($"\n{число_1}/{число_2} = {число_1 / число_2}");
                            }
                            break;
                        case 5:
                            Console.WriteLine($"\n{число_1}^{число_2} = {Math.Pow(число_1, число_2)}");
                            break;
                        default:
                            Console.WriteLine("Вы выбрали неверную операцию");
                            break;
                    }
                }
                if (операция == 6 | операция == 7 | операция == 8)
                {
                    Console.WriteLine("\nВведите число: ");
                    string num = Console.ReadLine();
                    double число = Convert.ToDouble(num);

                    switch (операция)
                    {
                        case 6:
                            Console.WriteLine($"\nКвадрвтный корень из {число} равен: {Math.Sqrt(число)}");
                            break;
                        case 7:
                            Console.WriteLine($"\n1% от {число} равен: {число / 100}");
                            break;
                        case 8:
                            double факториал = 1;
                            double цикл = число;
                            for (double i = 2; i <= цикл; i++)
                            {
                                факториал = факториал * i;
                            }
                            Console.WriteLine($"\n{число}! = {факториал}");
                            break;
                        default:
                            Console.WriteLine("Вы выбрали неверную операцию");
                            break;
                    }
                }
                    Console.WriteLine("\nВыберите операцию: ");
                    string operation_1 = Console.ReadLine();
                    int операция_1 = Convert.ToInt32(operation_1);

                    операция = операция_1;
            }
        }
    }
}