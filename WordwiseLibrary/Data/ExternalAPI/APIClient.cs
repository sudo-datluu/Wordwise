using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WordwiseLibrary.Data.ExternalAPI
{
    public static class APIClient
    {
        public static string queryURI = "https://random-wordapi-pi3m13ajd-ddatluu.vercel.app/word";
        public static async Task<WordResponse> GetRandomWord()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetStringAsync(queryURI);
                    if (!string.IsNullOrWhiteSpace(response))
                    {
                        WordResponse wr = JsonSerializer.Deserialize<List<WordResponse>>(response).First<WordResponse>();
                        wr.TrimResp();
                        return wr;
                    }
                }
                catch (Exception ex) {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                return null;
            }
        }
    }
}
