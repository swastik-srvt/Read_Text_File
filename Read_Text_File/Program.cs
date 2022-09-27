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
                var _each_fil_line = File.ReadAllLines(path).ToList();
                var countData = new CountData(_each_fil_line);
                countData.countCharacters();
                countData.countWords();
                countData.countLines();

            }
            catch(Exception ex)
            {
                Console.WriteLine("File Not Found" + ex);
            }

            Console.ReadLine();
        }
    }
}
