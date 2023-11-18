using TPI_GAZZERA_FERNANDEZ.Entities;

namespace TPI_GAZZERA_FERNANDEZ
{
    public class ProductsDataStore
    {
        public List<Product> Products { get; set; }
        public static ProductsDataStore Current { get; } = new ProductsDataStore();

        public ProductsDataStore()
        {
            Products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Milanesa con papas",
                    Price = "2500"
                },
                new Product()
                {
                    Id = 2,
                    Name = "Pizza",
                    Price = "3000"
                }
                new Product()
                {
                    Id = 3,
                    Name = "Choripan",
                    Price = "1500"
                },
                new Product()
                {
                    Id = 4,
                    Name = "Hamburguesa",
                    Price = "2750"
                },
                new Product()
                {
                    Id = 5,
                    Name = "Fideos con salsa",
                    Price = "1800"
                },
            };
        }

        public Product? GetId(int id)
        {
            return Products.SingleOrDefault(c => c.Id == id);
        }
    }

}
