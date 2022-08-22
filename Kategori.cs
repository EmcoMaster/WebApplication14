using System;

public class Class1
{
	public Class1()
	{
		[Key]
		public int id { get; set; }
		[Required]
	    public string Namn { get; set; }
	}
}
