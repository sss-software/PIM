﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.Core.Exceptions
{
    public class InvalidProjectNumberException: Exception
    {
        public InvalidProjectNumberException(string message) : base(message)
        {
        }
    }
}
