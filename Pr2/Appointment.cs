using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    internal class Appointment
    {
        public DateTime Data { get; set; }
        public DateTime WorkTime { get; set; }
        public Doctor Doctor { get; set; }
        public TimeReception TimeReception { get; set; }

        public Patient Patient { get; set; }
        public Appointment(DateTime data, DateTime workTime)
        {
            Data = data;
            WorkTime = workTime;
        }
    }
}
