using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Read_Text_File.Classes;
using Read_Text_File.Business_Logic;

namespace Read_Text_File
{
    internal class ReadFile
    {
       const string path = @"C:\Folder\Text2.txt"; 
        static void Main(string[] args)
        {
            try
            {
                //variable name should be meaningful
                var fileLines = File.ReadAllLines(path).ToList();
                var countData = new CountData(fileLines);
                
                
                 Console.WriteLine("Count Lines By Query method are :-" + countData.CountLinesByQuery());
                 Console.WriteLine("Count Lines By Lamda method are :-" + countData.CountLinesByLamda());
                 Console.WriteLine();
                 Console.WriteLine("Count Words By Query method are :-" + countData.CountWordsByQuery());
                 Console.WriteLine("Count Words By Lamda method are :-" + countData.CountWordsByLamda());
                 Console.WriteLine();
                 Console.WriteLine("Count Characters By Query method are :-" + countData.CountCharactersByQuery());
                 Console.WriteLine("Count Characters By Lamda method are :-" + countData.CountCharactersByLamda());

            }
            catch(Exception ex)
            {
                Console.WriteLine("File Not Found" + ex);
            }

            Console.ReadLine();
        }
    }
}
