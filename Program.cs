using System.Text.Json;
using Screensound.Modelos;
using Screensound.Filters;

using (HttpClient client = new())
{
    try
    {
        string res = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json")!;
        var musicas = JsonSerializer.Deserialize<List<Musica>>(res);
        LinqFilter.FiltrarTodosOsGeneros(musicas);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
