﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Exceptions
{
    public class CustomerException : Exception
    {
        public CustomerException(string message) : base(message)
        {
        }
    }
}
