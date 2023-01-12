using Foodmoji_Application.Repository.RepositoryBase;
using Foodmoji_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodmoji_Application.Repository.productRepository
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
    }
}
