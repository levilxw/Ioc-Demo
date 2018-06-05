using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore
{
    public interface ISend : IDisposable
    {
        string GetGuid();
    }
}
