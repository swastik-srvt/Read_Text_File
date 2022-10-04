using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_Text_File.Business_Logic
{
    internal interface ICountData
    {
        int GetCountByQuery(List<string> eachFileLine);
        int GetCountByLamda(List<string> eachFileLine);
    }
}
