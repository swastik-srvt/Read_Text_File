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
        //private variable should have '_' prefix
        private readonly ICountData _countCharcterData;
        private readonly ICountData _countWordData;
        private readonly ICountData _countLineData;
        private readonly List<string> _fileLines;

        public CountData(List<string> fileLines)
        { 
            _fileLines = fileLines;
            _countCharcterData = new CharacterCount();
            _countLineData = new LineCount();
            _countWordData = new WordCount();
            
        }

        // your class methods should never print anything on screen, they should return thier result to callee
        //follow propoer naming conventios for method name
//         public void countLines()
//         {
//             Console.WriteLine("No. of Lines by Query :- " + countLineData.GetCountByQuery(eachFileLine) );
//             Console.WriteLine("No. of Lines by Lamda :- " + countLineData.GetCountByLamda(eachFileLine) );
//         }

        //method name should begin with capital letter
        public int CountLinesByQuery(){
            return _countLineData.GetCountByQuery(_fileLines);
        }
        public int CountLinesByLamda(){
               return _countLineData.GetCountByLamda(_fileLines);
        }

//         public void countWords()
//         {
//             Console.WriteLine("No. of Words by Query :- " + countWordData.GetCountByQuery(eachFileLine));
//             Console.WriteLine("No. of Words by Lamda :- " +countWordData.GetCountByLamda(eachFileLine) );
//         }
         public int CountWordsByQuery(){
            return _countWordData.GetCountByQuery(_fileLines);
        }
        public int CountWordsByLamda(){
               return _countWordData.GetCountByLamda(_fileLines);
        }

//         public void countCharacters()
//         {
//             Console.WriteLine("No. of Character by Query :- " + countCharcterData.GetCountByQuery(eachFileLine) );
//             Console.WriteLine("No. of Character by Lamda :- " + countCharcterData.GetCountByLamda(eachFileLine));
//         }
        
         public int CountCharactersByQuery(){
            return _countLineData.GetCountByQuery(_fileLines);
        }
        public int CountCharactersByLamda(){
               return _countLineData.GetCountByLamda(_fileLines);
        }

    }
}
