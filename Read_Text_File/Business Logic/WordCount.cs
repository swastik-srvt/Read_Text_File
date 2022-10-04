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
        public int GetCountByQuery(List<string> eachFileLine)
        {
            return (from line in eachFileLine
                    from word in line.Split(' ')
                    select word).Count();
        }

        public int GetCountByLamda(List<string> eachFileLine)
        {

            return  eachFileLine.SelectMany(word=> word.Split(' ')).Count();
            

        }
    }
}
