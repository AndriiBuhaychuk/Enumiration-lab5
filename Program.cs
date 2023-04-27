using System;
using System.IO;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Шлях до файлу sort.txt
        string path = @"C:\Users\Andrii Buhaichuk\Desktop\sort.txt";

        // Відкриваємо файл input для читання
        var inputFile = File.OpenText(path);

        // Читаємо елементи з файлу та записуємо їх у масив
        var elements = inputFile
            .ReadToEnd()
            .Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        // Сортуємо масив елементів за зростанням
        Array.Sort(elements);

        // Шлях до файлу output.txt
        string outputFilePath = @"C:\Users\Andrii Buhaichuk\Desktop\output.txt";

        // Відкриваємо файл output для запису
        var outputFile = File.CreateText(outputFilePath);

        // Записуємо відсортований масив елементів у файл output
        foreach (var element in elements)
        {
            outputFile.WriteLine(element);
        }

        // Виводимо повідомлення про успішне завершення
        Console.WriteLine("Файл успішно встановлений на робочий стіл");

        // Закриваємо файли
        inputFile.Close();
        outputFile.Close();
    }
}
