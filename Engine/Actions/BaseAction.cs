using System;
using Engine.EventArgs;
using Engine.Models;

namespace Engine.Actions
{
    public abstract class BaseAction
    {
        protected readonly GameItem _itemInUse;

        public event EventHandler<Emotion> OnActionPerformed;

        protected BaseAction(GameItem itemInUse)
        {
            _itemInUse = itemInUse;
        }

        protected void ReportResult(Emotion result)
        {
            OnActionPerformed?.Invoke(this, result);
        }
    }
}