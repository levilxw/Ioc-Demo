using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore
{
    public class Send : ISend
    {
        public Send()
        {
            ThisGuid = Guid.NewGuid();
        }

        public Guid ThisGuid { get; set; }

        public void Dispose()
        {

        }

        public string GetGuid()
        {
            return ThisGuid.ToString();
        }
    }
}
