using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IR_Btree_Indexer
{
    class WordOccurrences
    {
        public String Word;
        public List<int> Locations;

        public WordOccurrences(String word)
        {
            Word = word;
            Locations = new List<int>();
        }
    }
}
