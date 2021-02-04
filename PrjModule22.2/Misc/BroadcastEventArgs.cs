namespace PrjModule22._2.Misc
{
    public class BroadcastEventArgs
    {
        public BroadcastEventArgs(string message)
        {
            Message = message;
        }

        public string Message { get; }
    }
}