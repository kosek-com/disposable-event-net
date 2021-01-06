using System;
using System.Collections.Generic;
using System.Linq;

namespace Kosek.DisposableEvent
{
	public sealed class DisposableEvent
	{
		private readonly Tokenable<Action> _callbacks = new Tokenable<Action>();
		
		public void Invoke()
		{
			foreach(var callback in _callbacks.GetRegistered())
			{
				callback?.Invoke();
			}
		}

		public Kosek.DisposableEvent.Token Register(Action callback)
		{
			return _callbacks.Register(callback);
		}
	}
	public sealed class DisposableEvent<T1>
	{
		private readonly Tokenable<Action<T1>> _callbacks = new Tokenable<Action<T1>>();

		public void Invoke(T1 arg1)
		{
			foreach (var callback in _callbacks.GetRegistered())
			{
				callback?.Invoke(arg1);
			}
		}

		public Kosek.DisposableEvent.Token Register(Action<T1> callback)
		{
			return _callbacks.Register(callback);
		}
	}
	public sealed class DisposableEvent<T1, T2>
	{
		private readonly Tokenable<Action<T1, T2>> _callbacks = new Tokenable<Action<T1, T2>>();

		public void Invoke(T1 arg1, T2 arg2)
		{
			foreach (var callback in _callbacks.GetRegistered())
			{
				callback?.Invoke(arg1, arg2);
			}
		}

		public Kosek.DisposableEvent.Token Register(Action<T1, T2> callback)
		{
			return _callbacks.Register(callback);
		}
	}
	public sealed class DisposableEvent<T1, T2, T3>
	{
		private readonly Tokenable<Action<T1, T2, T3>> _callbacks = new Tokenable<Action<T1, T2, T3>>();

		public void Invoke(T1 arg1, T2 arg2, T3 arg3)
		{
			foreach (var callback in _callbacks.GetRegistered())
			{
				callback?.Invoke(arg1, arg2, arg3);
			}
		}

		public Kosek.DisposableEvent.Token Register(Action<T1, T2, T3> callback)
		{
			return _callbacks.Register(callback);
		}
	}
	public sealed class DisposableEvent<T1, T2, T3, T4>
	{
		private readonly Tokenable<Action<T1, T2, T3, T4>> _callbacks = new Tokenable<Action<T1, T2, T3, T4>>();

		public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
			foreach (var callback in _callbacks.GetRegistered())
			{
				callback?.Invoke(arg1, arg2, arg3, arg4);
			}
		}

		public Kosek.DisposableEvent.Token Register(Action<T1, T2, T3, T4> callback)
		{
			return _callbacks.Register(callback);
		}
	}
	public sealed class DisposableEvent<T1, T2, T3, T4, T5>
	{
		private readonly Tokenable<Action<T1, T2, T3, T4, T5>> _callbacks = new Tokenable<Action<T1, T2, T3, T4, T5>>();

		public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
			foreach (var callback in _callbacks.GetRegistered())
			{
				callback?.Invoke(arg1, arg2, arg3, arg4, arg5);
			}
		}

		public Kosek.DisposableEvent.Token Register(Action<T1, T2, T3, T4, T5> callback)
		{
			return _callbacks.Register(callback);
		}
	}
	public sealed class DisposableEvent<T1, T2, T3, T4, T5, T6>
	{
		private readonly Tokenable<Action<T1, T2, T3, T4, T5, T6>> _callbacks = new Tokenable<Action<T1, T2, T3, T4, T5, T6>>();

		public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
			foreach (var callback in _callbacks.GetRegistered())
			{
				callback?.Invoke(arg1, arg2, arg3, arg4, arg5, arg6);
			}
		}

		public Kosek.DisposableEvent.Token Register(Action<T1, T2, T3, T4, T5, T6> callback)
		{
			return _callbacks.Register(callback);
		}
	}
	public sealed class DisposableEvent<T1, T2, T3, T4, T5, T6, T7>
	{
		private readonly Tokenable<Action<T1, T2, T3, T4, T5, T6, T7>> _callbacks = new Tokenable<Action<T1, T2, T3, T4, T5, T6, T7>>();

		public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
			foreach (var callback in _callbacks.GetRegistered())
			{
				callback?.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
			}
		}

		public Kosek.DisposableEvent.Token Register(Action<T1, T2, T3, T4, T5, T6, T7> callback)
		{
			return _callbacks.Register(callback);
		}
	}
	public sealed class DisposableEvent<T1, T2, T3, T4, T5, T6, T7, T8>
	{
		private readonly Tokenable<Action<T1, T2, T3, T4, T5, T6, T7, T8>> _callbacks = new Tokenable<Action<T1, T2, T3, T4, T5, T6, T7, T8>>();

		public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
			foreach (var callback in _callbacks.GetRegistered())
			{
				callback?.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
			}
		}

		public Kosek.DisposableEvent.Token Register(Action<T1, T2, T3, T4, T5, T6, T7, T8> callback)
		{
			return _callbacks.Register(callback);
		}
	}
	public sealed class DisposableEvent<T1, T2, T3, T4, T5, T6, T7, T8, T9>
	{
		private readonly Tokenable<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> _callbacks = new Tokenable<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>>();

		public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
			foreach (var callback in _callbacks.GetRegistered())
			{
				callback?.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
			}
		}

		public Kosek.DisposableEvent.Token Register(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> callback)
		{
			return _callbacks.Register(callback);
		}
	}
	public sealed class DisposableEvent<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
	{
		private readonly Tokenable<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> _callbacks = new Tokenable<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>();

		public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
			foreach (var callback in _callbacks.GetRegistered())
			{
				callback?.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
			}
		}

		public Kosek.DisposableEvent.Token Register(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> callback)
		{
			return _callbacks.Register(callback);
		}
	}
	public sealed class DisposableEvent<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
	{
		private readonly Tokenable<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> _callbacks = new Tokenable<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>();

		public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
			foreach (var callback in _callbacks.GetRegistered())
			{
				callback?.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
			}
		}

		public Kosek.DisposableEvent.Token Register(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> callback)
		{
			return _callbacks.Register(callback);
		}
	}
	public sealed class DisposableEvent<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
	{
		private readonly Tokenable<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> _callbacks = new Tokenable<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>();

		public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
			foreach (var callback in _callbacks.GetRegistered())
			{
				callback?.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
			}
		}

		public Kosek.DisposableEvent.Token Register(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> callback)
		{
			return _callbacks.Register(callback);
		}
	}
	public sealed class DisposableEvent<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
	{
		private readonly Tokenable<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> _callbacks = new Tokenable<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>();

		public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
			foreach (var callback in _callbacks.GetRegistered())
			{
				callback?.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
			}
		}

		public Kosek.DisposableEvent.Token Register(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> callback)
		{
			return _callbacks.Register(callback);
		}
	}
	public sealed class DisposableEvent<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
	{
		private readonly Tokenable<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> _callbacks = new Tokenable<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>();

		public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
			foreach (var callback in _callbacks.GetRegistered())
			{
				callback?.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
			}
		}

		public Kosek.DisposableEvent.Token Register(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> callback)
		{
			return _callbacks.Register(callback);
		}
	}
	public sealed class DisposableEvent<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
	{
		private readonly Tokenable<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> _callbacks = new Tokenable<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>();

		public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
		{
			foreach (var callback in _callbacks.GetRegistered())
			{
				callback?.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
			}
		}

		public Kosek.DisposableEvent.Token Register(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> callback)
		{
			return _callbacks.Register(callback);
		}
	}
	public sealed class DisposableEvent<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
	{
		private readonly Tokenable<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> _callbacks = new Tokenable<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>();

		public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
		{
			foreach (var callback in _callbacks.GetRegistered())
			{
				callback?.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
			}
		}

		public Kosek.DisposableEvent.Token Register(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> callback)
		{
			return _callbacks.Register(callback);
		}
	}
}
