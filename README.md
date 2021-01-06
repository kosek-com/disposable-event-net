[![NuGet](https://img.shields.io/nuget/dt/Kosek.DisposableEvent)](https://www.nuget.org/packages/Kosek.DisposableEvent/) [![Issues](https://img.shields.io/github/issues/kosek-com/disposable-event-net)](https://github.com/kosek-com/disposable-event-net/issues) [![License](https://img.shields.io/github/license/kosek-com/disposable-event-net)](https://github.com/kosek-com/disposable-event-net/blob/master/LICENSE) [![Release](https://img.shields.io/github/v/release/kosek-com/disposable-event-net)](https://github.com/kosek-com/disposable-event-net/releases) [![LastCommit](https://img.shields.io/github/last-commit/kosek-com/disposable-event-net)](https://github.com/kosek-com/disposable-event-net/commits/master) ![Build](https://img.shields.io/appveyor/build/Shelim/disposable-event-net)

# Disposable Events for .NET

![Logo](logo/DisposableEventNet.png)

A simple C# utility to create strongly-defined lifetimes for events

## Problem

.NET framework allows multiple ways to register events (or, more widely callbacks),
while there is no (generic) functionality to unregister them should there is reason to do so.

For example if your registration is bound to have side effects (like keeping source
alive while you are using it) - then it is easy to accidentally create resource leak (or oversubscription).

Let us have some code!

```C#
using System;
					
public class Program
{
	public static event EventHandler<EventArgs> ev;
	
	public static void Main()
	{
		ev += (obj, args) => Console.WriteLine("Hello World!");
		ev += (obj, args) => Console.WriteLine("Short lived!");
		ev += (obj, args) => Console.WriteLine("Hello World again!");
		
		ev.Invoke(null, new EventArgs());
		
		// How can I unsubscribe just event2?
	}
}
```

## The solution

The solution is actually quite simple: you can use provided `DisposableEvent` class
and each time you subsribe an event to it you will get `IDisposable` token.

Disposing that token will automatically unsuscribe you from the event.

See the below example:

```C#
using System;
using Kosek.DisposableEvent;

namespace example
{
	public class Program
	{
		public static readonly DisposableEvent event1 = new DisposableEvent();
		public static readonly DisposableEvent<string> event2 = new DisposableEvent<string>();
		
		static void Main(string[] args)
		{
			using(var token = event1.Register(Event1))
			{
				event1.Invoke(); // Outputs "Received event1!"
			}
			event1.Invoke(); // Outputs nothing
			
			var token1 = event2.Register(x => Console.WriteLine("Got: " + x));
			var token2 = event2.Register(x => Console.WriteLine("Really got: " + x));
			var token3 = event2.Register(x => Console.WriteLine("Yes! I've got: " + x));
			
			event2.Invoke("Ham"); // Outputs "Got: Ham", "Really got: Ham", "Yes! I've got: Ham"
			
			token2.Dispose();
			
			event2.Invoke("Ham"); // Outputs "Got: Ham", "Yes! I've got: Ham"
			
			var tokens = new DisposableCollection();
			tokens.Add(token1);
			tokens.Add(token3);
			
			tokens.Dispose();
			
			event2.Invoke("Milk?"); // Outputs nothing
		}
		
		private static void Event1()
		{
			Console.WriteLine("Received event1!");
		}
	}
}
```

## Features

 - The compiler will be peaky about not releasing `IDisposable` token. It is much
   harder to actually forgot to do so manually
 - The `DisposableEvent` have overloaded templates up to 16 arguments
   (that is the same amount as in `System.Action`)
 - If you have several events to allocate at once you can use provided `DisposableCollection`.
   With single `Dispose()` call you will dispose all `IDisposable` members of it

## Drawbacks

 - Not (yet) thread safe (PRs are welcome!)
