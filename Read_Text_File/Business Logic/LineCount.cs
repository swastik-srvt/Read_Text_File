using Read_Text_File.Business_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_Text_File.Classes
{
    internal class LineCount : ICountData
    {
       
        public int Get_Count_By_Query(List<string> each_file_line)
        {
            return (from line in each_file_line
                    select line).Count();
        }
        public int Get_Count_By_Lamda(List<String> each_file_line)
        {
            return each_file_line.Select(lines => lines).Count();
            
        }
    }
}