Using System;

namespace TPI-P3-GAZ-FER.Services.Implementations
{
    public class ProductsService : IProductsService
{
    private readonly ProductContext _context;

    public ProductsService(ProductsService context)
    {
        _context = context;
    }
    public List<ProductData> GetProducts()
    {
        return _context.Product.Where(p => p.ProductType == "Product").ToList();
    }
}
}
