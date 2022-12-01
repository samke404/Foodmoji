using Foodmoji_Application.Repository.DomainRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodmoji_Application.Repository.Wrapper
{
    public interface IRepositoryWrapper
    {
        IAccountRepository Account { get; }
        void Save();
    }
}
