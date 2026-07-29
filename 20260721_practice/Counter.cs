using System;
using System.Collections.Generic;
using System.Text;

namespace _20260721_Practice
{
    internal class Counter
    {

			private static int count = 0;

			public Counter()
			{
				count++;
			}

			public static int GetCount()
			{
				return count;
			}
		
	}
}
