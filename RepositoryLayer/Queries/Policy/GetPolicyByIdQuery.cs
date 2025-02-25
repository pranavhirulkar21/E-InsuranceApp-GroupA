﻿using MediatR;
using ModelLayer;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Queries.Policy
{
    public class GetPolicyByIdQuery : IRequest<PolicyDTO>
    {
        public int id;

        public GetPolicyByIdQuery(int id)
        {
            this.id = id;
        }
    }
}
