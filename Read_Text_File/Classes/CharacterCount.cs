using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Read_Text_File.Classes
{
    internal  class CharacterCount
    {

        int count = 0;
        public int No_Of_Char(List<string> list)
        {

            count = list.SelectMany(character => character.Split(' ')).ToList().SelectMany(x => x).Count();
            return count;

        }



    }
}
