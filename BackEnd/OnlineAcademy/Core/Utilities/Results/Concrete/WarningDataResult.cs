﻿using Core.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class WarningDataResult<T> : DataResult<T>
    {
        public WarningDataResult(T data) : base(data, ResultStatus.Warning)
        {
        }

        public WarningDataResult(T data, string message) : base(data, ResultStatus.Warning, message)
        {
        }
        public WarningDataResult(string message) : base(default, ResultStatus.Warning, message)
        {
        }
        public WarningDataResult() : base(default, ResultStatus.Warning)
        {
        }
    }
}
