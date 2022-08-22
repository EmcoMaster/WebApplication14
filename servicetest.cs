using System;

public class Class1
{
	public interface data
	{
		public Task<Product> CreateProduktAsync(ProductRequest request);

		public Task<Product> GetProductAsync(int id);

		public Task<IEnumerable><Produkt>> GetAllProduktAsync();

		public Task<Produkt> UpdateProductAsync(int id, ProductRequest request);

		public Task DeleteAsync(int id)
	}
}
