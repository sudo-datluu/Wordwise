using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordwiseLibrary.Models;

namespace WordwiseLibrary.Data.Controller
{
    public static class WordSetController
    {

        // Get word set from wordsetID
        public static WordSet? GetSingle(int wordSetID)
        {
            using (var context = new Context())
            {
                var wordset = context.WordSets.FirstOrDefault(ws => ws.WordSetID == wordSetID);
                return wordset;
            }
        }

        // Edit word set
        public static WordSet? Edit(int wordSetID, string name)
        {
            using (var context = new Context())
            {
                var wordset = context.WordSets.FirstOrDefault(ws => ws.WordSetID == wordSetID);
                if (wordset != null)
                {
                    wordset.Name = name;
                    context.SaveChanges();
                }
                return wordset;
            }
        }

        //Delete a word set
        //All words relating to this word set is deleted
        public static void Delete(int wordSetID) { 
            using (var context = new Context())
            {
                var wordset = context.WordSets.FirstOrDefault(ws => ws.WordSetID == wordSetID);
                if (wordset != null)
                {
                    context.WordSets.Remove(wordset);
                    context.SaveChanges();
                }
            }
        }

        // Get list of word set from an user
        public static List<WordSet> GetListFromUser(User user)
        {
            using (var context = new Context())
            {
                var wordSets = context.WordSets
                    .Where(ws => ws.Owner == user)
                    .ToList();
                return wordSets;
            }
        }

        // Get List of words from this word set
        public static List<Word> GetWords(int wordSetID)
        {
            using (var context = new Context())
            {
                var words = context.WordSets
                    .Where(ws => ws.WordSetID == wordSetID)
                    .SelectMany(ws => ws.Words)
                    .ToList();
                return words;
            }
        }
    }
}

