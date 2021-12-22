using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    class ErrorResult : Result
    {
        public ErrorResult() : base(false)
        {
        }

        public ErrorResult(string message) : base(false, message)
        {
        }
    }
}
