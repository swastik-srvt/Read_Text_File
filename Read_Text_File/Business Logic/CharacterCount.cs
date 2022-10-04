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
        public int GetCountByQuery(List<string> eachFileLine)
        {
            return (from line in eachFileLine
                    from word in line.Split(' ')
                    from ch in word
                    where ch != ' '
                    select ch).Count();
        }
        public int GetCountByLamda(List<string> eachFileLine)
        {

            return eachFileLine.SelectMany(character => character.Split(' ')).ToList().SelectMany(x => x).Count();
            

        }



    }
}
