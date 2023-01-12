using Foodmoji_Application.Repository.DomainRepository;
using Foodmoji_Application.Repository.RepositoryBase;
using Foodmoji_Domain.Models;
using Foodmoji_Infastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodmoji_Application.Repository.productRepository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}

