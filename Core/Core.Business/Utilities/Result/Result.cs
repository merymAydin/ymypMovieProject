﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business.Utilities.Result
{
    public class Result : IResult
    {
        public bool Success { get; } 
        public string Message {  get; }
        //constructor class ilk newlendiğinde oluşturulduğunda çağrılır
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
    }
}