﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result.Abstract
{
    public interface IDataResult<T> : IResult
    {
        // generic class?
        T Data { get; }
    }
}