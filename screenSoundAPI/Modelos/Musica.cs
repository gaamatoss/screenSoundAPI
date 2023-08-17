﻿using System.Text.Json.Serialization;
namespace screenSoundAPI.Modelos
{
	internal class Musica
	{
		public Musica()
		{
		}

		[JsonPropertyName("song")]
		public string Nome { get; set; }

        [JsonPropertyName("artist")]
        public string Artista { get; set; }

        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }

        [JsonPropertyName("genre")]
        public string Genero { get; set; }

        public void ShowMusicaDetails()
        {
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Duração(Segundos): {Duracao / 1000}");
            Console.WriteLine($"Gênero: {Genero}");
        }
    }
}

