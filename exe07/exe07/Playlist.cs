using System;
using System.Collections.Generic;

namespace exe07
{
    class Playlist
    {
        // Lista de músicas na playlist
        private List<Musica> listaDeMusicas;
        // Dono da playlist
        private string dono;

        // Construtor da playlist
        public Playlist(string dono)
        {
            listaDeMusicas = new List<Musica>();
            this.dono = dono;
        }

        // Método para adicionar uma música na playlist
        public void AdicionarMusica(Musica musica)
        {
            listaDeMusicas.Add(musica);
        }

        public void TocarMusicaPlaylist(int indice)
        {
            if (indice >= 0 && indice < listaDeMusicas.Count)
            {
                Musica musica = listaDeMusicas[indice];
                musica.Tocar();
            }
            else
            {
                Console.WriteLine("Índice de música inválido.");
            }
        }

        // Método para "tocar" uma música aleatória da playlist
        public void TocarMusicaAleatoria()
        {
            Random random = new Random();
            int indiceAleatorio = random.Next(0, listaDeMusicas.Count);
            TocarMusicaPlaylist(indiceAleatorio);
        }
    }
}
