﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business.Utilities.Result;
public interface IDataResult<T> : IResult
{
    T Data { get; }
}