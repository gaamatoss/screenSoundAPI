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
        //LinqFilter.FilterMusicByArtist(musicas, "Michael Jackson");

        // var musicasPreferidas = new MusicasPreferidas("Gabriel");
        // musicasPreferidas.AddFavoriteMusics(musicas[1]);
        // musicasPreferidas.AddFavoriteMusics(musicas[2]);
        // musicasPreferidas.AddFavoriteMusics(musicas[3]);
        var musicasPreferidasDavi = new MusicasPreferidas("Davi");
        musicasPreferidasDavi.AddFavoriteMusics(musicas[4]);
        musicasPreferidasDavi.AddFavoriteMusics(musicas[5]);
        musicasPreferidasDavi.AddFavoriteMusics(musicas[6]);
        // musicasPreferidasDavi.ShowFavoriteMusics();
        musicasPreferidasDavi.GenerateJsonFile();

        
    }
    catch(Exception error)
    {
        Console.WriteLine($"Erro: {error.Message}");
    }
};