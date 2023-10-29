using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordwiseLibrary.Models
{
    // Represent a word saved by a user
    public class Word
    {
        // Identifier of a word
        public int WordID { get; set; }

        // The expression of a word
        public string Term { get; set; }

        // Meaning of a word
        public string Definition { get; set; }

        // User who save this word
        public User Owner { get; set; }

        public int WordSetID { get; set; }

        // Wordset collection of this word
        public WordSet WordSet { get; set; }
    }
}
