using System.Collections.Generic;

namespace PrjModule22._2.Misc
{
    public class NewsHolder
    {
        public List<Comment> Comments { get; set; } = new();
        public string Text { get; set; }
        public User Sender { get; set; }
    }
}