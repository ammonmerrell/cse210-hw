using System;
using System.Transactions;

class Video
{
    public string _title;
    public string _author;
    public int _seconds;
    public List<Comment> _comments= new List<Comment>();
    public int NumberOfComments()
    {
        return _comments.Count;
    }

}