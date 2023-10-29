using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordwiseLibrary.Models;

namespace WordwiseLibrary.Data.Controller
{
    public static class WordController
    {
        // save a new word to set
        public static Word AddToSet(WordSet wordSet, User user, string term, string definition)
        {
            using (var context = new Context())
            {
                Word word = new Word() { WordSet = wordSet, Owner = user, Term = term, Definition = definition };
                context.Words.Add(word);
                context.SaveChanges();
                return word;
            }
        }

        // edit term and definition of a word
        public static Word? Edit(int wordID, string term, string definition) {
            using (var context = new Context())
            {
                var word = context.Words.FirstOrDefault(w => w.WordID == wordID);
                if (word != null)
                {
                    word.Term = term;
                    word.Definition = definition;
                    context.SaveChanges();
                }
                return word;
            }
        }

        // remove a word from system
        public static void Remove(int wordID)
        {
            using (var context = new Context())
            {
                var word = context.Words.FirstOrDefault(w => w.WordID == wordID);
                if (word != null)
                {
                    context.Words.Remove(word);
                    context.SaveChanges();
                }
            }
        }

        // Get a word, otherwise return null
        public static Word? Get(int wordID)
        {
            using (var context = new Context())
            {
                var word = context.Words.FirstOrDefault(w => w.WordID == wordID);
                return word;
            }
        }
    }
}
