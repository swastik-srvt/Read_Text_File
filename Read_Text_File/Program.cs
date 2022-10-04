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
                var eachFileLine = File.ReadAllLines(path).ToList();
                var countData = new CountData(eachFileLine);
                
                
                 Console.WriteLine("Count Lines By Query method are :-" + countData.countLinesByQuery);
                 Console.WriteLine("Count Lines By Lamda method are :-" + countData.countLinesByLamda);
                 Console.WriteLine();
                 Console.WriteLine("Count Words By Query method are :-" + countData.countWordsByQuery);
                 Console.WriteLine("Count Words By Lamda method are :-" + countData.countWordsByLamda);
                 Console.WriteLine();
                 Console.WriteLine("Count Characters By Query method are :-" + countData.countCharactersByQuery);
                 Console.WriteLine("Count Characters By Lamda method are :-" + countData.countCharactersByLamda);

            }
            catch(Exception ex)
            {
                Console.WriteLine("File Not Found" + ex);
            }

            Console.ReadLine();
        }
    }
}
