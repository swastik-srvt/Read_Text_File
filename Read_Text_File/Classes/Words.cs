using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_Text_File.Classes
{
    internal class Words
    {

        int count = 0;
        public int No_Of_Words(List<string> list)
        {

            count = list.SelectMany(word=> word.Split(' ')).Count();
            return count;

        }
    }
}
