using System.Collections.Generic;

namespace PrjModule22._2.News_Logic
{
    public class Comment
    {
        public List<Comment> SubComments { get; } = new();
        public string Message { get; init; }
    }
}