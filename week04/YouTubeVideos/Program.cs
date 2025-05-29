using System;
using System.Diagnostics;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        List<Video> _videos = new List<Video>();
        Video video1 = new Video();
        video1._title = "How to clean a car";
        video1._author = "Peter";
        video1._seconds = 420;
        Comment comment1 = new Comment();
        comment1._name = "John";
        comment1._text = "You did a great job showing me how to clean my car!";
        Comment comment2 = new Comment();
        comment2._name = "Anne";
        comment2._text = "Thank you! Your video was very helpful.";
        Comment comment3 = new Comment();
        comment3._name = "Ben";
        comment3._text = "Hello, you showed how easy it is to clean my car!";
        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);
        _videos.Add(video1);

        Video video2 = new Video();
        video2._title = "How to Iceskate";
        video2._author = "Anna";
        video2._seconds = 600;
        Comment com1 = new Comment();
        com1._name = "Anne";
        com1._text = "Your lesson was very helpful, Thank you!";
        Comment com2 = new Comment();
        com2._name = "Jim";
        com2._text = "Thanks! Your video helped me learn to Iceskate.";
        Comment com3 = new Comment();
        com3._name = "Sara";
        com3._text = "Hello, you showed how easy it is to Iceskate!";
        video2._comments.Add(com1);
        video2._comments.Add(com2);
        video2._comments.Add(com3);
        _videos.Add(video2);

        Video video3 = new Video();
        video3._title = "How to change a car tire";
        video3._author = "Jim";
        video3._seconds = 300;
        Comment comm1 = new Comment();
        comm1._name = "Anne";
        comm1._text = "Your lesson was very helpful, Thank you!";
        Comment comm2 = new Comment();
        comm2._name = "Ben";
        comm2._text = "Thanks! Your video was clear and to the point.";
        Comment comm3 = new Comment();
        comm3._name = "Sara";
        comm3._text = "Hello, you showed how easy it is to change a tire!";
        video3._comments.Add(comm1);
        video3._comments.Add(comm2);
        video3._comments.Add(comm3);
        _videos.Add(video3);


        foreach (Video i in _videos)
        {
            Console.Write($"Title: {i._title}, Author: {i._author}, Seconds: {i._seconds} ");
            Console.WriteLine($"Comments: {i.NumberOfComments()},");
            i.ShowComments();
            Console.WriteLine();
        }
    }
}