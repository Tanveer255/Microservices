﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtAuthentication.Interface
{
    public interface IJwtAuthenticationService
    {
         Task<string> GenerateTokenAsync(string user);
    }
}
