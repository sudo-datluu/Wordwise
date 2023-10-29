using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordwiseLibrary.Models
{
    // Represents A set of word entity
    public class WordSet
    {
        // Identifier for the Word Set
        public int WordSetID { get; set; }
        
        // Creator and owner of word set
        public User Owner { get; set; }

        // Wordset name
        public string Name { get; set; }

        // Collection of words in this set
        public IList<Word> Words { get; set;}

        public WordSet() { 
            Words = new List<Word>();
        }

    }
}
