using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> Video = new List<Video>();

        Video Video1 = new Video("How to complete super difficult generic video game level", "CrazyGuy78", 5100);
        Video1.GetComment(new Comment("Josh", "first comment"));
        Video1.GetComment(new Comment("Abi", "Oh that's how you do that!"));
        Video1.GetComment(new Comment("Sebastian", "Nice"));
        Video.Add(Video1);

        Video Video2 = new Video("I made a cake out of air", "ThatOneCakeLady", 1758);
        Video2.GetComment(new Comment("Aria", "what a beautiful cake!"));
        Video2.GetComment(new Comment("Julia", "wow, now i know how to make an invisible cake"));
        Video2.GetComment(new Comment("Jesus", "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"));
        Video.Add(Video2);

        Video Video3 = new Video("Streaming till my laptop DIES - a saga", "SpiffyMan3000", 10000);
        Video3.GetComment(new Comment("YuB", "Man, can't believe his laptop lasted that long..."));
        Video3.GetComment(new Comment("DannyBoyo", "I died of laughter when he fell off his chair, classic spiffy man"));
        Video3.GetComment(new Comment("RafayelDaFishBoy", "why does it say it's a saga????"));
        Video3.GetComment(new Comment("Artist39", "I missed half of this because i fell asleep in a tree... update; broke my arm."));
        Video.Add(Video3);

        foreach (Video video in Video)
        {
            Console.WriteLine($"{video.GetVidName()}");
            Console.WriteLine($"{video.GetVidAuthor()}");
            Console.WriteLine($"{video.GetVidLength()}\n");
        }

        

    }

    

    
    

}