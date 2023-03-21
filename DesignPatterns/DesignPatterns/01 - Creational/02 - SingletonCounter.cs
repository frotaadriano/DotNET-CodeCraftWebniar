using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._01___Creational
{
	public class Counter
	{
		private int count;
		private static Counter instance = null;

		private Counter()
		{
			count = 0;
		}

		public static Counter Instance()
		{
			if (instance == null)
			{
				instance = new Counter();
			}
			return instance;
		}

		public void Increment()
		{
			count++;
		}

		public void Decrement()
		{
			count--;
		}

		public int GetCount()
		{
			return count;
		}
	}

}
