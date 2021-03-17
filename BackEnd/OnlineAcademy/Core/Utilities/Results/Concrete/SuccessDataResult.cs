using Core.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data) : base(data, ResultStatus.Success)
        {
        }

        public SuccessDataResult(T data, string message) : base(data, ResultStatus.Success, message)
        {
        }
        public SuccessDataResult(string message) : base(default, ResultStatus.Success, message)
        {
        }
        public SuccessDataResult() : base(default, ResultStatus.Success)
        {

        }
    }
}
