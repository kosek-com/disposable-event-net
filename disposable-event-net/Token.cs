using System;

namespace Kosek.DisposableEvent
{
    public abstract class Token : IDisposable
    {
        public abstract void Dispose();
    }
}
