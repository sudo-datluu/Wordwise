using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordwiseLibrary.Data.ExternalAPI
{
    // Define reponse from random word api
    public class WordResponse
    {
        public string word { get; set; }
        public string definition { get; set; }
        public string pronunciation { get; set; }

        public void TrimResp()
        {
            definition = definition.Trim();
        }
    }
}
