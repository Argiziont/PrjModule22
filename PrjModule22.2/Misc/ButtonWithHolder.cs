using System.Collections.Generic;
using System.Windows.Forms;
using PrjModule22._2.News_Logic;

namespace PrjModule22._2.Misc
{
    public class ButtonWithHolder : Button
    {
        public Comment Comment { get; init; }
        public IList<Comment> SubComment { get; init; }
        public NewsHolder NewsHolder { get; init; }
    }
}