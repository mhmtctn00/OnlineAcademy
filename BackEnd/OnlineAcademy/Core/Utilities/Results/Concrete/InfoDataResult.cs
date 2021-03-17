using Core.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class InfoDataResult<T> : DataResult<T>
    {
        public InfoDataResult(T data) : base(data, ResultStatus.Info)
        {
        }

        public InfoDataResult(T data, string message) : base(data, ResultStatus.Info, message)
        {
        }
        public InfoDataResult(string message) : base(default, ResultStatus.Info, message)
        {
        }
        public InfoDataResult() : base(default, ResultStatus.Info)
        {
        }
    }
}
