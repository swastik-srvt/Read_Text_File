using Read_Text_File.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_Text_File.Business_Logic
{
    internal class CountData

    {
        // follow proper naming conventions, dont use '_' between variable names
        private readonly ICountData _count_Charcter_data;
        private readonly ICountData _count_Word_data;
        private readonly ICountData _count_Line_data;
        private readonly List<string> _each_file_line;

        public CountData(List<string> _each_file_line)
        { 
            this._each_file_line = _each_file_line;
            this._count_Charcter_data = new CharacterCount();
            this._count_Line_data = new LineCount();
            this._count_Word_data = new WordCount();
            
        }

        // your class methods should never print anything on screen, they should return thier result to callee
        //follow propoer naming conventios for method name
        public void countLines()
        {
            Console.WriteLine("No. of Lines by Query :- " + _count_Line_data.Get_Count_By_Query(_each_file_line) );
            Console.WriteLine("No. of Lines by Lamda :- " + _count_Line_data.Get_Count_By_Lamda(_each_file_line) );
        }

        public void countWords()
        {
            Console.WriteLine("No. of Words by Query :- " + _count_Word_data.Get_Count_By_Query(_each_file_line));
            Console.WriteLine("No. of Words by Lamda :- " +_count_Word_data.Get_Count_By_Lamda(_each_file_line) );
        }

        public void countCharacters()
        {
            Console.WriteLine("No. of Character by Query :- " + _count_Charcter_data.Get_Count_By_Query(_each_file_line) );
            Console.WriteLine("No. of Character by Lamda :- " + _count_Charcter_data.Get_Count_By_Lamda(_each_file_line));
        }

    }
}
