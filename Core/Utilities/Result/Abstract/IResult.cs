﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result.Abstract
{
    public interface IResult
    {
        //sete niye yok
        bool Success { get; }
        string Message { get; }
    }
}
