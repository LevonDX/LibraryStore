using LibraryStore.Shared.Models;
using System.Text.Json;

namespace LibraryStore.ConsoleUI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            List<BookViewModel>? books = new List<BookViewModel>();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/api/");

            HttpResponseMessage response = await client.GetAsync("books/list");

            books = JsonSerializer.Deserialize<List<BookViewModel>>(await response.Content.ReadAsStringAsync());

        }
    }
}
