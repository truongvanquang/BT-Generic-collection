using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("SV: Truong Van Quang - MSV: 2415053122232");
        List<int> numbers = new List<int>();
        Console.Write("Ban muon nhap bao nhieu so? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap so thu {i + 1}: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("Tong cac phan tu: " + numbers.Sum());
        Console.ReadLine();
    }
}