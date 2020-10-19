using System;
using System.Collections.Generic;
using System.Threading;

public class Book: IItem
{
	public int Count { get; set; }
	public string Name { get { return "Книга:" + " " + BookName + " " + "Автор:" + " " + AutorName ; } }


	public int Prise { get; }
	public string AutorName { get; }
	public string BookName { get; } 
	public Book(int Count, int Prise, string AutorName, string BookName)
	{
		this.BookName = BookName;
		this.AutorName = AutorName;
		this.Count = Count;
		this.Prise = Prise;
	}

}
