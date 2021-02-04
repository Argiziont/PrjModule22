using System.Collections.Generic;

namespace PrjModule22._2.News_Logic
{
    public class NewsHolder
    {
        public List<Comment> Comments { get; } = new();
        public string Text { get; init; }
        public User Sender { get; init; }
    }
}