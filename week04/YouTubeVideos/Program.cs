using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

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
        Console.WriteLine(video1.NumberOfComments());
    }
}