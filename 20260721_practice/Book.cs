using System;
using System.Collections.Generic;
using System.Text;

namespace _20260721_Practice
{
    internal class Book
    {
		public string Title { get; set; }
		public string Author { get; set; }
		public bool IsBorrowed { get; set; }

		public Book(string title, string author)
		{
			Title = title;
			Author = author;
			IsBorrowed = false;
		}
	}
}
