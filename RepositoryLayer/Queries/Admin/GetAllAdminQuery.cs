﻿using MediatR;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Queries.Admin
{
    public class GetAllAdminQuery : IRequest<List<AdminEntity>>
    {
    }
}
