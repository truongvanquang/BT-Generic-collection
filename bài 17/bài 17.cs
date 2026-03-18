using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("SV: Truong Van Quang - MSV: 2415053122232");
        Console.WriteLine("--- Bai 17: Tim so xuat hien nhieu nhat ---");

        List<int> numbers = new List<int>();
        Console.Write("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        // Tìm số xuất hiện nhiều nhất bằng LINQ
        if (numbers.Count > 0)
        {
            var result = numbers.GroupBy(x => x)
                                .OrderByDescending(g => g.Count())
                                .First();

            Console.WriteLine($"\nSo xuat hien nhieu nhat la: {result.Key} (xuat hien {result.Count()} lan)");
        }

        Console.ReadLine();
    }
}