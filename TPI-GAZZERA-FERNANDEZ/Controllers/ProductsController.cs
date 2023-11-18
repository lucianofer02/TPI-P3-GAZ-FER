using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using TPI_GAZZERA_FERNANDEZ.Entities;
using Microsoft.AspNetCore.Authorization;


namespace TPI_GAZZERA_FERNANDEZ.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductsDataStore _productsDataStore;
        public ProductsController(ProductsDataStore productsDataStore)
        {
            _productsDataStore = productsDataStore;
        }

        [HttpGet]
        [Route("{id}")]

        public IActionResult GetId(int id)
        {
            Product? products = _productsDataStore.GetId(id);

            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] ProductPostDto dto)
        {
            string role = ProductData.Claims.FirstOrDefault(c => c.type == ClaimTypes.Role).Value.ToString(); ;
            if (role == "Product")
            {
                var product = new Product()
                {
                    Nombre = dto.Nombre,
                    Precio = dto.Precio,
                }
                int id = _userService.CreateProduct(client);

                return Ok(id);
            }
            return Forbid();
        }
    }
}
}