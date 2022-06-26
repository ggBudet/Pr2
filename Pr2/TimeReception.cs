using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    internal class TimeReception
    {
        public WorkDay WorkDay { get; set; }
        public int HrsStart { get; set; }
        public int HrsEnd { get; set; }

        public TimeReception(int hrsStart, int hrsEnd, WorkDay workDay)
        {
            HrsStart = hrsStart;
            HrsEnd = hrsEnd;
            WorkDay = workDay;
        }
    }
}
