using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_Text_File.Business_Logic
{
    internal interface ICountData
    {
        int Get_Count_By_Query(List<string> each_file_line);
        int Get_Count_By_Lamda(List<string> each_file_line );
    }
}
