namespace exe07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando algumas músicas
            Musica musica1 = new Musica("Cygnus X-I Book II: Hemispheres", "Rush", "Gravadora X");
            Musica musica2 = new Musica("Owner Of A Lonely Heart", "Yes", "Gravadora Y");
            Musica musica3 = new Musica("Tarkus", "Emerson, Lake and Palmer", "Gravadora Z");

            // Criando uma playlist e adicionando músicas
            Playlist playlist = new Playlist("Paulo Aug.");
            playlist.AdicionarMusica(musica1);
            playlist.AdicionarMusica(musica2);
            playlist.AdicionarMusica(musica3);

            // Tocando a música Cygnus X-I Book II: Hemispheres
            musica1.Tocar();

            // Tocando a música Tarkus (índice 2) pela playlist
            playlist.TocarMusicaPlaylist(2);

            // Tocando uma música aleatória da playlist
            playlist.TocarMusicaAleatoria();

            Console.ReadLine();
        }
    }
}
