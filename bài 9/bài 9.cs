using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("SV: Truong Van Quang - MSV: 2415053122232");
        List<int> numbers = new List<int>();
        Console.Write("Nhap so luong phan tu (co the nhap trung): ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu {i + 1}: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        // Tạo danh sách mới không chứa phần tử trùng bằng Linq Distinct
        List<int> uniqueList = numbers.Distinct().ToList();

        Console.WriteLine("Danh sach sau khi loai bo trung lap: " + string.Join(", ", uniqueList));
        Console.ReadLine();
    }
}