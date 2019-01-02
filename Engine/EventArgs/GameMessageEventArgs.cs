namespace Engine.EventArgs
{
    [System.Flags]
    public enum Emote
    {
        FATAL,
        TERRIBLE,
        MOCKING,
        NORMAL,
        STOIC,
        HAPPY,
        DANGEROUS,
        FANTASTIC,
        ORGASMIC,
        REQUIRED,
        REWARD
    }

    public class GameMessageEventArgs : System.EventArgs
    {
        public string Message { get; private set; }
        public Emote Level { get; private set; }

        public GameMessageEventArgs(string message) : this (Emote.NORMAL, message)
        {

        }

        public GameMessageEventArgs(Emote level, string message)
        {
            Message = message;
            Level = level;
        }
    }
}