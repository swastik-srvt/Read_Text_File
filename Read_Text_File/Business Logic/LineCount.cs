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
       
        public int GetCountByQuery(List<string> eachFileLine)
        {
            return (from line in eachFileLine
                    select line).Count();
        }
        public int GetCountByLamda(List<String> eachFileLine)
        {
            return eachFileLine.Select(lines => lines).Count();
            
        }
    }
}
