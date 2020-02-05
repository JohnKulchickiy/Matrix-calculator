using System

namespace Lab4
{
    class Program
    {
        public static void Menu(Matrix first, Matrix second)
        {
            int choice;
            do
            {
                choice = 666;
                Console.WriteLine("Первая матрица:\n" + first.ToString());
                
                Console.WriteLine("Вторая матрица:\n" + second.ToString());
                
                Console.WriteLine("Выберите действие:\n1 - Сложение\n2 - Вычитание\n3 - Перемножение матриц\n4 - Умножение матрицы на число\n5 - Транспонирование матрицы\n0 - Выход из приложения\nВведите число, соответствующее вашему выбору:");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (System.FormatException)
                {

                }
                switch (choice)
                {
                    case 1:
                        //Сложение
                        try
                        {
                            Matrix result = first + second;
                            Console.WriteLine("Ответ:\n" + result.ToString());
                        }
                        catch (NullReferenceException)
                        {
                            Console.WriteLine("Ошибка: Матрицы неравного размера, операция невозможна");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        //Вычитание
                        try
                        {
                            Matrix result = first - second;
                            Console.WriteLine("Ответ:\n" + result.ToString());
                        }
                        catch (NullReferenceException)
                        {
                            Console.WriteLine("Ошибка: Матрицы неравного размера, операция невозможна");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        //Перемножение
                        try
                        {
                            Matrix result = first * second;
                            Console.WriteLine("Ответ:\n" + result.ToString());
                        }
                        catch (NullReferenceException)
                        {
                            Console.WriteLine("Ошибка: Матрицы неравного размера, операция невозможна");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        //Умножение на число
                        try
                        {
                            Console.WriteLine("Введите множитель:");
                            int num = int.Parse(Console.ReadLine());

                            if (num == 0)
                            {
                                throw new Exception("Вы ввели нулевое значение!");
                            }

                            Matrix result = first * num;
                            Console.WriteLine("Ответ:\n" + result.ToString());
                            
                            result = second * num;
                            Console.WriteLine("\n" + result.ToString());                            
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Ошибка: " + e.Message);
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        //Транспонирование 
                        Matrix res_1 = ~first;
                        Matrix res_2 = ~second;

                        Console.WriteLine("Ответ:\n" + res_1.ToString() + "\n\n" + res_2.ToString());

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Ух-Ух! Похоже ошибочка вышла. Повторите ввод!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (choice != 0);
        }
        static void Main(string[] args)
        {
            Matrix first = new Matrix(5, 3);
            Matrix second = new Matrix(5, 3);
            Menu(first, second);
        }
    }
}
