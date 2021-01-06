# Disposable Events for .NET

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

See [the example](example/Program.cs)

## Features

 - The compiler will be peaky about not releasing `IDisposable` token. It is much
   harder to actually forgot to do so manually
 - The `DisposableEvent` have overloaded templates up to 16 arguments
   (that is the same amount as in `System.Action`)
 - If you have several events to allocate at once you can use provided `DisposableCollection`.
   With single `Dispose()` call you will dispose all `IDisposable` members of it

## Drawbacks

 - Not (yet) thread safe (PRs are welcome!)
