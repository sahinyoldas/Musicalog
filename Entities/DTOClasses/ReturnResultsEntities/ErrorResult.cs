﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOClasses.ReturnResultsEntities
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(false, message)
        {

        }

        public ErrorResult() : base(false)
        {

        }
    }
}
