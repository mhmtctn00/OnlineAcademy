using Core.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class InfoResult : Result
    {
        public InfoResult() : base(ResultStatus.Info)
        {
        }

        public InfoResult(string message) : base(ResultStatus.Info, message)
        {
        }
    }
}
