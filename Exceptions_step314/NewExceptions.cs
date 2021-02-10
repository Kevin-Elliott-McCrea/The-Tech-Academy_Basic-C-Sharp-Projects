using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_step314
{
    public class ZeroException : Exception
    {
        public ZeroException()
            : base() { }
    }

    public class BelowZeroException : Exception
    {
        public BelowZeroException()
            : base() { }
    }
}
