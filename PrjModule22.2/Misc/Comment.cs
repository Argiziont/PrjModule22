using System.Collections.Generic;

namespace PrjModule22._2.Misc
{
    public class Comment
    {
        public List<Comment> SubComments { get; set; } = new List<Comment>();
        public string Message { get; set; }
    }
}