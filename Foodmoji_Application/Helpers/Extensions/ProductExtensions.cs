using Foodmoji_Application.ViewModels.Account;
using Foodmoji_Application.ViewModels.Product;
using Foodmoji_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Foodmoji_Application.Helpers.Extensions
{
    public static class ProductExtensions
    {
        public static Product ToEntity(this AddProductViewModel model)
        {
            return new Product
            {
                ProductName = model.ProductName,
                Picture = model.Picture,
                ProductDescription = model.ProductDescription,
                Quantity = model.Quantity,
                Price = model.Price,
                TotalPrice = model.TotalPrice,

            };
        }
    }
}
