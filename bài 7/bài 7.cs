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

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu {i + 1}: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        numbers.Sort();
        Console.WriteLine("Danh sach sau khi sap xep tang dan: " + string.Join(", ", numbers));
        Console.ReadLine();
    }
}