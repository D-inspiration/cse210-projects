using System;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Video 1", "Author 1", 60);
        Video video2 = new Video("Video 2", "Author 2", 120);
        Video video3 = new Video("Video 3", "Author 3", 90);

        // Add comments to videos
        video1.Comments.Add(new Comment("John", "Great video!"));
        video1.Comments.Add(new Comment("Jane", "I agree!"));
        video2.Comments.Add(new Comment("Bob", "Good job!"));
        video2.Comments.Add(new Comment("Alice", "Thanks!"));
        video3.Comments.Add(new Comment("Mike", "Excellent!"));
        video3.Comments.Add(new Comment("Emma", "Well done!"));

        // Create list of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video information and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"Comment by {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
