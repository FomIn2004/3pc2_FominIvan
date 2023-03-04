using System;
using System.Collections.Generic;
using System.Drawing;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(5);
            tree.Add(-3);
            tree.Add(8);
            tree.Add(-1);
            tree.Add(4);
            tree.Add(-7);
            tree.Add(9);
            // случайные значения 
            for (int i = 0; i < 10; i++)
            {
                int value = random.Next(10, 1001);
                tree.Add(value);

            }
            // Вычисление суммы значений в дереве
            int sum = tree.SumValues();
            Console.WriteLine("1 Задание");
            Console.WriteLine("Сумма значений в дереве: " + sum);
            Console.WriteLine("2 Задание");
            int count = tree.CountInternalNodes();
            Console.WriteLine("Количество внутренних узлов: " + count);
            Console.WriteLine("3 Задание");
            // Получаем отрицательные значения из дерева
            List<int> negativeValues = tree.GetNegativeValues();

            // Выводим отрицательные значения
            Console.WriteLine("Отрицательные значения в дереве: ");
            foreach (int value in negativeValues)
            {
                Console.WriteLine(value);
            }
        }
    }
}
