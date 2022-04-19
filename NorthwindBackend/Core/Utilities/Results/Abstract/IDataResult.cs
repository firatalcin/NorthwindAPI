﻿using Core.Entities.Abstract;
using Core.Utilities.Abstract.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Abstract
{
    public interface IDataResult<T> : IResult 
    {
        T Data { get; }
    }
}
