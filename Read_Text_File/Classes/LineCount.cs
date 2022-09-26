using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_Text_File.Classes
{
    internal class LineCount
    {
        int count = 0;

        public int No_Of_Line(List<String> list)
        {
            count = list.Select(lines => lines).Count();
            return count;
        }
    }
}