using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace _15_FileHandling_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\User\OneDrive\Desktop\File.txt";
            string path2 = @"C:\Users\User\OneDrive\Desktop\newFile.txt";
            //Task 1
            File.Create(path).Close();

            //Task2
            //try
            //{
            //    if (File.Exists(path))
            //    {
            //        File.Delete(path);
            //    }
            //    else
            //    {
            //        throw new Exception("File does not exists!");
            //    }

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Task 3
            //if (File.Exists(path))
            //{
            //    Console.WriteLine("File is already exist");
            //}
            //else
            //{
            //    File.Create(path);
            //    Console.WriteLine("File was created succesfully");
            //}

            //Task 4
            //Console.WriteLine("Add text :");
            //string fileText = Console.ReadLine();
            //File.WriteAllText(path, fileText);
            //Console.WriteLine(File.ReadAllLines(path));

            //Task 5
            //Console.WriteLine(File.ReadAllText(path));

            //Task 6
            //Console.WriteLine("Add File name to create :");
            //string fileName = Console.ReadLine();
            //string filePath = @"C:\Users\User\OneDrive\Desktop" + @"\" + fileName;

            //if (File.Exists(filePath))
            //    Console.WriteLine("File with this name already exist , try another name. ");
            //else
            //{
            //    Console.WriteLine("Your files path is : " + filePath);
            //    File.Create(filePath).Close();
            //    Console.Write("Input number of lines : ");
            //    int num = int.Parse(Console.ReadLine());
            //    string[] lines = new string[num];
            //    for (int i = 0; i < num; i++)
            //    {
            //        Console.Write($"Input Line {i + 1} : ");
            //        string line = Console.ReadLine();
            //        lines[i] = line;
            //    }

            //    File.WriteAllLines(filePath, lines);
            //}

            //Task 7
            //Console.WriteLine("Create and write some line of text which does not contain a given string in a line  :  ");
            //Console.WriteLine("-------------------------------------------");

            //Console.Write("input number of lines to write in the file: ");
            //int num = int.Parse(Console.ReadLine());

            //Console.Write("Input the string to ignore the line : ");
            //string ignore = Console.ReadLine();

            //Console.WriteLine($"Input {num} lines below : ");
            //string[] lines = new string[num];
            //for (int i = 0; i < num; i++)
            //{
            //    Console.Write($"Input line {i+1} : ");
            //    string line = Console.ReadLine();
            //    lines[i] = line;
            //}

            //List<string> myArray = new List<string>();

            //foreach (string line in lines)
            //{
            //    if(!line.Contains(ignore))
            //    myArray.Add(line);
            //}

            // File.WriteAllLines(path, myArray);

            //Task 8
            //Console.Write("Append new text: ");
            //string name = Console.ReadLine();
            //File.AppendAllText(path, name);

            //Task 9,10
            //string newFile = @"C:\Users\User\OneDrive\Desktop\newFile.txt";
            //File.Copy(path, newFile);

            //Task 11
            //string[] lines = { "hello" ,"to ", "everyone"};
            //File.WriteAllLines(path, lines);
            //string line1 = File.ReadAllLines(path).First();
            //Console.WriteLine("The content of the first line of the file is: ");
            //Console.WriteLine(line1);

            //Task 12
            //Console.Write("Input number of lines to write in the file  : ");
            //int num = int.Parse(Console.ReadLine());

            //string[] myArray = new string[num];
            //Console.WriteLine($"Input {num} strings below :");
            //for (int i = 0; i < num; i++)
            //{
            //    Console.Write($"Input line {i + 1} : ");
            //    string line = Console.ReadLine();
            //    myArray[i] = line;
            //}
            //File.WriteAllLines(path2, myArray);
            //Console.WriteLine($"The content of the last line of the file {Path.GetFileName(path2)} is  :");
            //string lastLine = File.ReadAllLines(path2).Last();
            //Console.WriteLine(lastLine);

            //Task 13
            //string[] lines = { "hello", "to ", "everyone" };
            //File.WriteAllLines(path, lines);
            //Console.Write("Input which line you want to display  : ");
            //int num = int.Parse(Console.ReadLine());

            //string line = File.ReadLines(path).Skip(num-1).FirstOrDefault();
            //Console.WriteLine(line);

            ////or

            //string[] getLines = File.ReadAllLines(path);
            //Console.WriteLine(getLines[num-1]);

            //Task 14
            //Console.Write("Input number of lines to write in the file :");
            //int num = int.Parse(Console.ReadLine());

            //string[] lines = new string[num];
            //Console.WriteLine($"Input {num} strings below :");
            //for (int i = 0; i < num; i++)
            //{
            //    Console.Write($"Input line {i + 1} : ");
            //    string line = Console.ReadLine();
            //    lines[i] = line;
            //}
            //File.WriteAllLines(path, lines);

            //Console.Write("Input last how many numbers of lines you want to display  : ");
            //int numDisplay = int.Parse(Console.ReadLine());

            //Console.WriteLine($"The content of the last {numDisplay} lines of the file {Path.GetFileName(path)} is :  ");

            //string[] getLines = File.ReadAllLines(path);
            //for (int i = getLines.Length - numDisplay; i < getLines.Length; i++)
            //{
            //    Console.WriteLine(getLines[i]);
            //}

            //Task 15
            string[] lines = { "hello", "to ", "everyone" };
            File.WriteAllLines(path, lines);
            var lineCount = File.ReadLines(path).Count();
            Console.WriteLine(lineCount);












        }
    }
}
