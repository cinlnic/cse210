using System;

class Program
{
   static void Main(string[] args)
   {
      List<Video> videos = new List<Video>();

      Video video1 = new Video();
      video1.title = "Intro Video";
      video1.author = "Jane Smith";
      video1.length = 90;
      Comment comment1 = new Comment();
      comment1.name = "Lucy Mack";
      comment1.comment = "Great intro video!";
      video1.comments.Add(comment1);
      Comment comment2 = new Comment();
      comment2.name = "Josh Nichols";
      comment2.comment = "Very well done.";
      video1.comments.Add(comment2);
      Comment comment3 = new Comment();
      comment3.name = "Sally";
      comment3.comment = "Awesome! Nice to meet you.";
      video1.comments.Add(comment3);

      Video video2 = new Video();
      video2.title = "Drawing Tutorial";
      video2.author = "Joe Black";
      video2.length = 600;
      Comment vid2Comment1 = new Comment();
      vid2Comment1.name = "Hank";
      vid2Comment1.comment = "Excellent tutorial!";
      video2.comments.Add(vid2Comment1);
      Comment vid2Comment2 = new Comment();
      vid2Comment2.name = "Ethan Nichols";
      vid2Comment2.comment = "Very easy to follow.";
      video2.comments.Add(vid2Comment2);
      Comment vid2Comment3 = new Comment();
      vid2Comment3.name = "Rob";
      vid2Comment3.comment = "My drawing turned out great.";
      video2.comments.Add(vid2Comment3);

      Video video3 = new Video();
      video3.title = "Super Mario Bros Walkthrough";
      video3.author = "Conner Nichols";
      video3.length = 3600;
      Comment vid3Comment1 = new Comment();
      vid3Comment1.name = "Billy Joe";
      vid3Comment1.comment = "My favorite game!";
      video3.comments.Add(vid3Comment1);
      Comment vid3Comment2 = new Comment();
      vid3Comment2.name = "Cindi Nichols";
      vid3Comment2.comment = "Great job!";
      video3.comments.Add(vid3Comment2);
      Comment vid3Comment3 = new Comment();
      vid3Comment3.name = "Sue Smith";
      vid3Comment3.comment = "Helped me find the princess, thanks.";
      video3.comments.Add(vid3Comment3);

      videos.Add(video1);
      videos.Add(video2);
      videos.Add(video3);

      foreach (Video video in videos)
      {
         Console.WriteLine($"\nTitle: {video.title}");
         Console.WriteLine($"Author: {video.author}");
         Console.WriteLine($"Length: {video.length} seconds");
         Console.WriteLine("Comments:");
         DisplayComments(video.comments);
      }

      void DisplayComments(List<Comment> comments)
      {
         foreach (Comment comment in comments)
         {
            Console.WriteLine($"  {comment.name}");
            Console.WriteLine($"    {comment.comment}");
         }

      }
   }
}