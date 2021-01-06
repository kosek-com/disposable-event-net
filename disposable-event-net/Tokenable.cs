using System;
using System.Collections.Generic;
using System.Linq;

namespace Kosek.DisposableEvent
{
    internal sealed class Tokenable<T>
    {
        private readonly Dictionary<Token, T> _registry = new Dictionary<Token, T>();

        private class Token : Kosek.DisposableEvent.Token
        {
            public readonly Tokenable<T> Owner;

            public Token(Tokenable<T> owner)
            {
                Owner = owner;
            }

            public override void Dispose()
            {
                Owner.Unregister(this);
            }
        }

        public Kosek.DisposableEvent.Token Register(T obj)
        {
            var ret = new Token(this);
            _registry[ret] = obj;
            return ret;
        }

        public List<T> GetRegistered()
        {
            return _registry.Values.ToList();
        }

        private void Unregister(Token token)
        {
            _registry.Remove(token);
        }
    }
}
