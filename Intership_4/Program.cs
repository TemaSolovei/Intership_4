using System;

namespace Intership_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double eps, result = 0, element; // eps — заданная точность, result — сумма элементов последовательности, element — элемент последовательности
            double i = 1; // i - номер элемента последовательности

            eps = checkDouble("Введите заданную точность: ");

            do
            {
                element = 1 / Math.Pow(i, 2);
                result += element;
                i++;
            } while (element > eps);

            Console.WriteLine("Результат вычисления бесконечной суммы = {0:0.00000000}", result);
            Console.WriteLine("Количество элементов последовательности: {0}", i-1);
            Console.WriteLine("Значение последнего элемента последовательности: {0:0.00000000}", element);
        }

        static double checkDouble(string message)
        {
            double result; // result - проверенная переменная
            bool ok; // Проверка ввода

            do
            {
                Console.Write(message);
                ok = double.TryParse(Console.ReadLine(), out result);
                if (!ok) Console.WriteLine("Ошибка! Введите вещественное число!");
                if (result <= 0) Console.WriteLine("Число должно быть больше нуля!");
            } while ((!ok) || (result <= 0));

            return result;
        }
    }
}
