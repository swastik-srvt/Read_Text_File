using Read_Text_File.Business_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_Text_File.Classes
{
    internal class WordCount : ICountData
    {
        public int Get_Count_By_Query(List<string> each_file_line)
        {
            return (from line in each_file_line
                    from word in line.Split(' ')
                    select word).Count();
        }

        public int Get_Count_By_Lamda(List<string> each_file_Line)
        {

            return  each_file_Line.SelectMany(word=> word.Split(' ')).Count();
            

        }
    }
}
