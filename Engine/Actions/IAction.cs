using System;
using Engine.Models;

namespace Engine.Actions
{
    public interface IAction
    {
        event EventHandler<Emotion> OnActionPerformed;
        void Execute(LivingEntity actor, LivingEntity target);
    }
}