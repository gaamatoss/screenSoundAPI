using screenSoundAPI.Modelos;
namespace screenSoundAPI.Filtros
{
	internal class LinqFilter
	{
		public static void FilterGenre(List<Musica> musicas)
		{
			var AllGenre = musicas.Select(musica => musica.Genero).Distinct().ToList();
			foreach(var genero in AllGenre)
			{
				Console.WriteLine($"- {genero}");
			}
		}

		public static void FilterArtist(List<Musica> musicas){
			var AllArtists = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
			foreach(var artista in AllArtists)
			{
				Console.WriteLine($"- {artista}");
			}
		}

		public static void FilterArtistByGenre(List<Musica> musicas, string genre){
			var AllArtistsByGenre = musicas.Where(musica => musica.Genero.Contains(genre)).Select(musica => musica.Artista).Distinct().ToList();
			Console.WriteLine($"Exibindo artistas do genero >> {genre}");
			foreach(var artista in AllArtistsByGenre)
			{
				Console.WriteLine($"- {artista}");
			}
		}

		public static void FilterMusicByArtist(List<Musica> musicas, string artist){
			var AllMusicByArtist = musicas.Where(musica => musica.Artista.Contains(artist)).Select(musica => musica.Nome).Distinct().ToList();
			Console.WriteLine($"Exibindo musicas do artista >> {artist}");
			foreach(var musica in AllMusicByArtist)
			{
				Console.WriteLine($"- {musica}");
			}
		}
	}
}

