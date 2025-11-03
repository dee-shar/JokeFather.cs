# JokeFather.cs
Web-API for [jokefather.com](https://jokefather.com) the ultimate collection of dad jokes that are guaranteed to make you groan.

## Example
```cs
using JokeFatherApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new JokeFather();
            string joke = await api.GetRandomJoke();
            Console.WriteLine(joke);
        }
    }
}
```
