using System;
using System.Text.Json;
namespace screenSoundAPI.Modelos;

internal class MusicasPreferidas
{
	public MusicasPreferidas(string nome)
	{
		Nome = nome;
		ListaDeMusicasFavoritas = new List<Musica>();
	}

	public string? Nome { get; set; }
	public List<Musica> ListaDeMusicasFavoritas { get; }

	public void AddFavoriteMusics(Musica musica)
	{
		ListaDeMusicasFavoritas.Add(musica);
	}

	public void ShowFavoriteMusics()
	{
		Console.WriteLine($"Essas são as musicas favoritas => {Nome}");
		foreach (var item in ListaDeMusicasFavoritas)
		{
			Console.WriteLine($"- {item.Nome} de {item.Artista}");
		}
	}

	public void GenerateJsonFile()
	{
		string json = JsonSerializer.Serialize(new{
			nome = Nome,
			musicas = ListaDeMusicasFavoritas
		});
		string fileName = $"musicasFavoritas-{Nome}.json";

		File.WriteAllText(fileName, json);
		System.Console.WriteLine("O Json foi criado com sucesso!");
	}
}

