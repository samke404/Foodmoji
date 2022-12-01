﻿using Foodmoji_Application.Repository.RepositoryBase;
using Foodmoji_Domain.Models;
using Foodmoji_Infastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodmoji_Application.Repository.DomainRepository
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }

}
