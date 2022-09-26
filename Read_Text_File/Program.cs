using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Read_Text_File.Classes;

namespace Read_Text_File
{
    internal class ReadFile
    {
       static string path = @"C:\Folder\Text2.txt";
        static  string str = File.ReadAllText(path);

        
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(path).ToList();
            if (File.Exists(path))
            {
                Console.WriteLine("File Found");
                string data = File.ReadAllText(path);
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("File Not Found ");

            }

            CharacterCount charCount = new CharacterCount();
            int result = charCount.No_Of_Char(lines);
            Console.WriteLine("total char :-" + result);
            Console.WriteLine();


            LineCount lineCount = new LineCount();
            int res = lineCount.No_Of_Line(lines);
            Console.WriteLine("total Lines :-" + res);
            Console.WriteLine();

            Words wordCount = new Words();
            int ress = wordCount.No_Of_Words(lines);
            Console.WriteLine("total Lines :-" + ress);
            Console.WriteLine();


            Console.ReadLine();

        }
    }
}
