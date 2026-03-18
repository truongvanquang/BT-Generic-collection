using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("SV: Truong Van Quang - MSV: 2415053122232");
        List<int> numbers = new List<int>();
        Console.Write("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());

        int count = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu {i + 1}: ");
            int value = int.Parse(Console.ReadLine());
            numbers.Add(value);
            if (value % 2 == 0) count++;
        }

        Console.WriteLine($"Co {count} so chan trong danh sach.");
        Console.ReadLine();
    }
}