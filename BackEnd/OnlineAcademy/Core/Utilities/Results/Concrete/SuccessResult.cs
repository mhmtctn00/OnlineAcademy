using Core.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class SuccessResult : Result
    {
        public SuccessResult() : base(ResultStatus.Success)
        {
        }

        public SuccessResult(string message) : base(ResultStatus.Success, message)
        {
        }
    }
}
