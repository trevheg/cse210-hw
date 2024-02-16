using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        videos.Add(new Video("C# Abstraction for Beginners", "The Code Man", 632)) ;
        videos[0].CreateComment("Homer", "D'OH!");
        videos[0].CreateComment("Nelson", "Ha ha!");
        videos[0].CreateComment("Bart", "Don't have a cow man!");
        videos[0].CreateComment("Ned", "Okily dokily!");
        
        videos.Add(new Video("All about Encapsulation - C#", "Mr Programmer", 745)) ;
        videos[1].CreateComment("Dave Lister", "I had to watch the part starting at 2:34 a few times but now I get it.");
        videos[1].CreateComment("Arnold Rimmer", "Could use more color coding.");
        videos[1].CreateComment("Cat", "Fabulous!");
        videos[1].CreateComment("Kryten", "It's so well organized!");
        
        videos.Add(new Video("Inheritance in C#", "We Love Code", 275)) ;
        videos[2].CreateComment("Sokka", "This came back to me like my boomerang!");
        videos[2].CreateComment("Katara", "This is bending my mind.");
        videos[2].CreateComment("Aang", "This blew me away.");
        videos[2].CreateComment("Zuko", "I used to be against coding, but now I support it.");

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetVideoInfo());
        }

    }
}