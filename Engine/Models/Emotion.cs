using Engine.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Emotion
    {
        public Emotion()
        { }

        public Emotion(Emote level, string expression)
        {
            Feeling = level;
            Message = expression;
        }

        public Emote Feeling { get; private set; }
        public string Message { get; private set; }
    }
}
