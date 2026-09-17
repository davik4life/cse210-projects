using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video(
            "Learn C# Programming for Beginners",
            "Code Academy",
            720
        );

        video1.AddComment(new Comment(
            "Victor",
            "This explanation made C# much easier to understand."
        ));

        video1.AddComment(new Comment(
            "Emmanuel",
            "Great tutorial. I learned a lot from this."
        ));

        video1.AddComment(new Comment(
            "Sarah",
            "Please make another video about classes and objects."
        ));


        Video video2 = new Video(
            "Understanding Object-Oriented Programming",
            "Dev Learning",
            600
        );

        video2.AddComment(new Comment(
            "Michael",
            "The examples were very helpful."
        ));

        video2.AddComment(new Comment(
            "Jennifer",
            "I finally understand abstraction!"
        ));

        video2.AddComment(new Comment(
            "David",
            "Excellent explanation of OOP concepts."
        ));


        Video video3 = new Video(
            "Build Your First C# Application",
            "Programming World",
            900
        );

        video3.AddComment(new Comment(
            "Daniel",
            "I successfully built my first application."
        ));

        video3.AddComment(new Comment(
            "Grace",
            "This was easy to follow."
        ));

        video3.AddComment(new Comment(
            "James",
            "Looking forward to the next lesson."
        ));


        Video video4 = new Video(
            "C# Classes and Objects Explained",
            "Software Skills",
            540
        );

        video4.AddComment(new Comment(
            "John",
            "Classes make much more sense now."
        ));

        video4.AddComment(new Comment(
            "Mary",
            "Very clear explanation."
        ));

        video4.AddComment(new Comment(
            "Peter",
            "The examples helped me understand objects."
        ));


        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3,
            video4
        };


        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine(
                $"Number of Comments: {video.GetNumberOfComments()}"
            );

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(
                    $"- {comment.GetName()}: {comment.GetText()}"
                );
            }

            Console.WriteLine();
        }
    }
}