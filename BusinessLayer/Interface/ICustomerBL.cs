﻿using ModelLayer;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public interface ICustomerBL
    {
        Task<CustomerEntity> RegisterAsync(CustomerML model);
    }
}
