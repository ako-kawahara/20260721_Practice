using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace _20260721_Practice
{
	internal class CoinCase
	{
		int coin500 = 0;
		int coin100 = 0;
		int coin50 = 0;
		int coin10 = 0;
		int coin5 = 0;
		int coin1 = 0;

		public void AddCoins(int type, int count)
		{
			if (type == 500)
			{
				coin500+= count;
			}
			else if (type == 100)
			{
				coin100+= count;
			}
			else if (type == 50)
			{
				coin50 += count;
			}
			else if (type == 10)
			{
				coin10 += count;
			}
			else if (type == 5)
			{
				coin5 += count;
			}
			else if(type == 1)
			{
				coin1 += count;
			}
		}

				public  int GetCount(int type)
			{
				if (type == 500)
				{
					return coin500;
				}
				else if (type == 100)
				{
					return coin100;
				}
				else if (type == 50)
				{
					return coin50;
				}
				else if (type == 10)
				{
					return coin10;
				}
				else if (type == 5)
				{
					return coin5;
				}
				else if (type == 1)
				{
					return coin1;
				}
				return 0;
			}


		

		public int GetAmount()
		{
			return coin500 * 500
			+ coin100 * 100
			+ coin50 * 50
			+ coin10 * 10
			+ coin5 * 5
			+ coin1 * 1;
		}
		public int GetCountAll()
		{
			return coin500
				 + coin100
				 + coin50
				 + coin10
				 + coin5
				 + coin1;
		}

	}
}
