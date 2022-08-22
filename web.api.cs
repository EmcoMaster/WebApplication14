using System;

public class Class1
{
	public Class1()
	{
		[Key]
		public string ArtikelNummer { get; set; } = null!;

		[Required]

	    public string Namn { get; set; } = null;

		public string Användare { get; set; }
	    [Required]
		[Column(TypeNamn="money")]
	    public decimal pris { get; set; }

         [Required]
	    public int kategoriID { get; set; }
	    public virtual Produktenkategori kategori { get; set; }
	}
}
