using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
	public static class MyAggregate
	{
		public static T MyAggregatee<T>(this IEnumerable<T> source, Func<T, T, T> func)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}

			if (func == null)
			{
				throw new ArgumentNullException("source");
			}

			using (IEnumerator<T> e = source.GetEnumerator())
			{
				if (!e.MoveNext())
				{
					
				}

				T result = e.Current;
				while (e.MoveNext())
				{
					result = func(result, e.Current);
				}

				return result;
			}
		}

	}
}
