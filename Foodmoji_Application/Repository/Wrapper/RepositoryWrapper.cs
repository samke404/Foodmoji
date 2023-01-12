using Foodmoji_Application.Repository.DomainRepository;
using Foodmoji_Application.Repository.productRepository;
using Foodmoji_Infastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodmoji_Application.Repository.Wrapper
{
    public class RepositoryWrapper
    {
        public ApplicationDbContext _db;
        public IAccountRepository _account;
        public IProductRepository _product;

        public IAccountRepository Account
        {
            get { 
            if ( _account == null)
            {
                _account = new AccountRepository(_db);
            }
            return _account;
            }
        }

        public IProductRepository Product
        {
            get
            {
                if (_product == null)
                {
                    _product = new ProductRepository(_db);
                }
                return (_product);
            }
        }

        public RepositoryWrapper(ApplicationDbContext db)
        {
            _db = db;
            
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
