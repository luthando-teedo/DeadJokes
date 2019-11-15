using System;
using System.Threading.Tasks;
using DadJokesLibrary;

namespace DadJokesApp
{
    class Program
    {
        static async Task Main(string[] args)
        {

           string jokeString = await JokesGernarator.GetRandomJokeAsync();

            Console.WriteLine(jokeString);
        }
    }
}
