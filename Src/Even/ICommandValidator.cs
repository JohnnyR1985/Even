﻿using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even
{
    public interface ICommandValidator
    {
        Task<RejectReasons> ValidateAsync(object command);
    }
}
