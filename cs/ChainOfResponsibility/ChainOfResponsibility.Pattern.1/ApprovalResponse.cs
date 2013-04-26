using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility.Pattern._1
{
    public enum ApprovalResponse
    {
        Denied,
        Approved,
        BeyondApprovalLimit,
    };
}
