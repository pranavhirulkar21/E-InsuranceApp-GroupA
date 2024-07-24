﻿using ModelLayer;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interface
{
    public interface IAgentRL
    {
        Task<InsuranceAgentEntity> CreateAgentAsync(InsuranceAgentEntity insuranceAgentML);
    }
}
