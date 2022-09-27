using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Contracts;
using Read_Text_File.Business_Logic;

namespace Read_Text_File.Classes
{
    internal  class CharacterCount : ICountData
    {
        public int Get_Count_By_Query(List<string> each_file_line)
        {
            return (from line in each_file_line
                    from word in line.Split(' ')
                    from ch in word
                    where ch != ' '
                    select ch).Count();
        }
        public int Get_Count_By_Lamda(List<string> each_file_line)
        {

            return  each_file_line.SelectMany(character => character.Split(' ')).ToList().SelectMany(x => x).Count();
            

        }



    }
}
