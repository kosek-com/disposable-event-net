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
