using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("SV: Truong Van Quang - MSV: 2415053122232");
        List<int> numbers = new List<int>();

        Console.WriteLine("Nhap vao 5 so nguyen:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Nhap so thu {i + 1}: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        Console.Write("Danh sach vua nhap: ");
        foreach (int n in numbers) Console.Write(n + " ");
        Console.ReadLine();
    }
}