using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // For every each seconds
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    // This method will get the total of comment
    public int GetCommentCount()
    {
        return Comments.Count;
    }

    // This method will add new comment
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }
}