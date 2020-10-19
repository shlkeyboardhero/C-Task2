using System;
using System.Collections.Generic;
using System.Threading;

public class Card : IItem
{
	public int Count { get; set; }
	public string Name { get { return "Открытка: " + Type + " с текстом: " + Text; } }


	public int Prise { get; }
	public string Type { get; }
	public string Text { get; }
	public Card(int Count, int Prise, string Type, string Text)
	{
		this.Type = Type;
		this.Text = Text;
		this.Count = Count;
		this.Prise = Prise;
	}

}
