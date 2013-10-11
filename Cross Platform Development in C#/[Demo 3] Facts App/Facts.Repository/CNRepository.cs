using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Facts.Domain.Entities;

namespace Facts.Repository
{
    public class CNRepository : Facts.Domain.Repository.IFactRepository
    {
        private const string ServiceLocation = "http://api.icndb.com/jokes/random?limitTo=[nerdy]";
        public async Task<Fact> GetFact()
        {
            HttpClient client = new HttpClient();
            var result = await client.GetAsync(ServiceLocation);
            var stringResult = await result.Content.ReadAsStringAsync();


            string theJoke = ExtractJoke(stringResult);
            
            return new Fact()
            {
                TheFact = theJoke
            
            };
        }

        private string ExtractJoke(string stringResult)
        {
            string withoutEnd = stringResult.Substring(0, stringResult.IndexOf("\", \"categories"));

            int startOfJoke = withoutEnd.LastIndexOf("\"")+1;
            string theJoke = withoutEnd.Substring(startOfJoke);
            theJoke = theJoke.Replace("&quot;", "\"");
            return theJoke;
        }
    }
}
