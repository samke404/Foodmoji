using Foodmoji_Application.Helpers.Extensions;
using Foodmoji_Application.Repository.DomainRepository;
using Foodmoji_Application.Repository.productRepository;
using Foodmoji_Application.ViewModels.Account;
using Foodmoji_Application.ViewModels.Product;
using Foodmoji_Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stripe;

namespace Foodmoji.Api.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        //inject db

        private readonly IProductRepository _productRepo;
        public ProductController(IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }

        [HttpPost]
        [Route("addProduct")]
        public async Task<IActionResult> addNewProducts([FromBody] AddProductViewModel products)
        {
            

            return Ok("");
        }
    }
}
