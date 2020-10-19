using System;
using System.Collections.Generic;
using System.Threading;

public class Paper : IItem
{
	public int Count { get; set; }
	public string Name { get { return "Тетрадь " + Type + ", "+ Qty + " листов"; } }


	public int Prise { get; }
	public int Qty { get; }
	public string Type { get; }
	public Paper(int Count, int Prise, int Qty, string Type)
	{
		this.Type = Type;
		this.Qty = Qty;
		this.Count = Count;
		this.Prise = Prise;
	}

}
