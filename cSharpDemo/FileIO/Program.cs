using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class FileOperations
    {
        internal void WriteFile(string file)
        {
            StreamWriter sw = File.CreateText(file);
            Console.WriteLine("Enter Text to write: ");
            string txt = Console.ReadLine();
            sw.WriteLine(txt);
            sw.Close();
            Console.WriteLine("---Write Operation Success.");
        }
        internal void ReadFile(string file)
        {
            StreamReader sr = File.OpenText(file);
            Console.WriteLine("\nText From File:\n" + sr.ReadToEnd());
            sr.Close();
            Console.WriteLine("---Read Operation Success.");
        }
        internal void AppendFile(string file)
        {
            StreamWriter sw = File.AppendText(file);
            Console.WriteLine("\nEnter Text to Append: ");
            string txt = Console.ReadLine();
            sw.WriteLine(txt);
            sw.Close();
            Console.WriteLine("---Append Operation Success.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"d:\tops.txt";
            FileOperations fop = new FileOperations();
            fop.WriteFile(file);
            fop.ReadFile(file);
            fop.AppendFile(file);
            fop.ReadFile(file);
            Console.Read();

        }
    }
}
