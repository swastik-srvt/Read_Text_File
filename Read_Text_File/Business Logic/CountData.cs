using Read_Text_File.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_Text_File.Business_Logic
{
    internal class CountData

    {
        // follow proper naming conventions, dont use '_' between variable names
        private readonly ICountData countCharcterData;
        private readonly ICountData countWordData;
        private readonly ICountData countLineData;
        private readonly List<string> eachFileLine;

        public CountData(List<string> eachFileLine)
        { 
            this.eachFileLine = eachFileLine;
            this.countCharcterData = new CharacterCount();
            this.countLineData = new LineCount();
            this.countWordData = new WordCount();
            
        }

        // your class methods should never print anything on screen, they should return thier result to callee
        //follow propoer naming conventios for method name
        public void countLines()
        {
            Console.WriteLine("No. of Lines by Query :- " + countLineData.GetCountByQuery(eachFileLine) );
            Console.WriteLine("No. of Lines by Lamda :- " + countLineData.GetCountByLamda(eachFileLine) );
        }

        public void countWords()
        {
            Console.WriteLine("No. of Words by Query :- " + countWordData.GetCountByQuery(eachFileLine));
            Console.WriteLine("No. of Words by Lamda :- " +countWordData.GetCountByLamda(eachFileLine) );
        }

        public void countCharacters()
        {
            Console.WriteLine("No. of Character by Query :- " + countCharcterData.GetCountByQuery(eachFileLine) );
            Console.WriteLine("No. of Character by Lamda :- " + countCharcterData.GetCountByLamda(eachFileLine));
        }

    }
}
