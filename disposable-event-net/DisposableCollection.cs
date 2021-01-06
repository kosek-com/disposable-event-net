using System;
using System.Collections.Generic;
using System.Linq;

namespace Kosek.DisposableEvent
{
	public sealed class DisposableCollection : List<IDisposable>, IDisposable
	{
		public void Dispose()
		{
			while (this.Any())
			{
				var list = this.ToList();
				Clear();

				foreach (var item in list)
				{
					item?.Dispose();
				}
			}
		}
	}
}
