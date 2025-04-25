namespace Nisan2.Models
{
    public class Repository
    { 
       private static readonly List<Products> _products = new List<Products>();

       static Repository()
       {
            _products = new List<Products>
            {
                new Products { Id = 1, Name = "Product 1", Price = 10.99m, ImageUrl = "1.jpg", IsActive = true, Listed = true },
                new Products { Id = 2, Name = "Product 2", Price = 20.99m, ImageUrl = "4.jpg", IsActive = true, Listed = false },
                new Products { Id = 3, Name = "Product 3", Price = 30.99m, ImageUrl = "1.jpg", IsActive = false, Listed = true },
                new Products { Id = 4, Name = "Product 4", Price = 40.99m, ImageUrl = "4.jpg", IsActive = true, Listed = true },
                new Products { Id = 5, Name = "Product 5", Price = 50.99m, ImageUrl = "1.jpg", IsActive = true, Listed = false }, 
                new Products { Id = 6, Name = "Product 6", Price = 60.99m, ImageUrl = "6.jpg", IsActive = true, Listed = true },
            };
       }
       public static List<Products> GetProducts
       {
            get { return _products; }
       }

        public static Products? GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

    }
}