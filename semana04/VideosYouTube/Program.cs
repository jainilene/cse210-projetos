using System;

class Program
{
    static void Main(string[] args)
    {

        List<Video> _videos = new List<Video>();
        
        Console.WriteLine("Olá, Mundo! Este é o Projeto VideosYouTube.");
        
        Video v1 = new Video("Video 1 - Aula de Programação OO", "Pedro", 60);
        Video v2 = new Video("Video 2 - Aula de Abstração", "Marcos", 40);
        Video v3 = new Video("Video 3 - Aula de Encapsulamento", "Lucas", 40);
        Video v4 = new Video("Video 4 - Aula de Revisão", "João", 60);

        v1.AdicionarComentario("Joana", "Aula maravilhosa. Estou animada para aprender!");
        v1.AdicionarComentario("Miguel", "Aula interessante!");
        v1.AdicionarComentario("Diógenes", "Esse professor é fera!");

        v2.AdicionarComentario("Mariana", "Gostei muito de aprender essa técnica, deixa tudo mais claro!");
        v2.AdicionarComentario("Cleiton", "Excelente aula! Vou usar muito isso!");
        v2.AdicionarComentario("Rodrigo", "Menos é mais! Aula top!");

        v3.AdicionarComentario("Ana Clara", "Confesso que ainda confundo abstração com encapsulamento.");
        v3.AdicionarComentario("José", "Interessante essa técnica, aumenta o controle e evita vários pontos de manutenção");
        v3.AdicionarComentario("Carlos", "Tenho um amigo que na hora que cria os atributos ele já gera os métodos Getters e Setters hahah vou mandar esse video pra ele");

        v4.AdicionarComentario("Mariana", "Excelente revisão, professor! Obrigada.");
        v4.AdicionarComentario("Mariana", "Revisão top!!");
        v4.AdicionarComentario("Mariana", "Agora ficou tudo mais claro! ");

        _videos.Add(v1);
        _videos.Add(v2);
        _videos.Add(v3);
        _videos.Add(v4);

        foreach(Video video in _videos)
        {
            Console.WriteLine(video.RastrearVideo());
            Console.WriteLine("Quantidade de comentários: " + video.GetNumeroComentarios());
            Console.WriteLine(video.MostrarComentarios());
            
        }
    }
}