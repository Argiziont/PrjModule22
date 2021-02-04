using System.Collections.Generic;
using System.Windows.Forms;

namespace PrjModule22._2.Misc
{
    public class ButtonWithHolder : Button
    {
        public Comment Comment { get; set; }
        public IList<Comment> SubComment { get; set; }
        public NewsHolder NewsHolder { get; set; }
        public IList<NewsHolder> SubNews { get; set; }
    }
}