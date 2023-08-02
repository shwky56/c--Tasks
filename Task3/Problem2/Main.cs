using System;
using System.Collections.Generic;
using System.IO;
using OfficeOpenXml;

class Program
{
    static void Main()
    {
        string excelFilePath = "path/to/your/excel/file.xlsx";
        List<Person> persons = ReadExcelFile(excelFilePath);
        
        // Do whatever you want with the 'persons' list here
        foreach (var person in persons)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }

    static List<Person> ReadExcelFile(string filePath)
    {
        List<Person> persons = new List<Person>();

        FileInfo fileInfo = new FileInfo(filePath);
        using (ExcelPackage package = new ExcelPackage(fileInfo))
        {
            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
            int rowCount = worksheet.Dimension.Rows;

            // Assuming that the first row contains the column headers
            for (int row = 2; row <= rowCount; row++)
            {
                string name = worksheet.Cells[row, 1].Value?.ToString();
                int age = int.Parse(worksheet.Cells[row, 2].Value?.ToString() ?? "0");

                Person person = new Person { Name = name, Age = age };
                persons.Add(person);
            }
        }

        return persons;
    }
}
