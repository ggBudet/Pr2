using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    internal class Doctor : Speciality
    {
        public Guid Id { get; set; }

        public WorkDay WorkDay { get; set; }

        public Doctor(Guid id, 
            WorkDay workDay, 
            string name)
            : base (name)
        {
            Id = id;
        }
    }
}
