using System.Net.Http;

namespace JokeFatherApi
{
    public class JokeFather
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://jokefather.com/api/";
        public JokeFather()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36");
        }

        public async Task<string> GetRandomJoke()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/jokes/random");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetJoke(string jokeId)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/jokes/{jokeId}");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
