using screenSoundAPI.Modelos;
using System.Text.Json;
using screenSoundAPI.Filtros;
using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(response)!;//É usado o exclamação pois não pode ser nulo o retorno
        musicas[0].ShowMusicaDetails();
        // LinqFilter.FilterGenre(musicas);
        // LinqFilter.FilterArtist(musicas);
        // LinqFilter.FilterArtistByGenre(musicas, "pop");
        LinqFilter.FilterMusicByArtist(musicas, "Michael Jackson");
    }
    catch(Exception error)
    {
        Console.WriteLine($"Erro: {error.Message}");
    }
};