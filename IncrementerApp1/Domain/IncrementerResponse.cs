
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IncrementerApp1.Domain
{
    public class IncrementerResponse
    {
        public int currentValue { get; set; }

        public IncrementerResponse(int currentValue)
        {
            this.currentValue = currentValue;
        }

    }

}
