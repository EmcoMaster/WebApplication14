using System

	namespace webApi

public class Class
{
	public Class1()
	{
		[Key]
		public int id { get; set; }
		[Required]
		public string Namn { get; set; } = null!;
		[Required]
		[Column(TypeName = "money")]
	    public decimal Priset { get; set; }
		[Required]
		public string lista { get; set; }
		}
	   public class kategori
    {
		[Key]
		public int id { get; set; }

		[Required]

		public string Name { get; set; }
		
    }
	}
}
