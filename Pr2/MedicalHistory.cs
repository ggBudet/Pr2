using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    internal class MedicalHistory
    {
        public DateTime DateOfOnsetOfIllness { get; set; }
        public DateTime RecoveryDate { get; set; }
        public string Diagnosis { get; set; }
        public string PreventiveMeasures { get; set; }

        public MedicalHistory(DateTime dateOfOnsetOfIllness, DateTime recoveryDate, string diagnosis, string preventiveMeasures)
        {
            DateOfOnsetOfIllness = dateOfOnsetOfIllness;
            RecoveryDate = recoveryDate;
            Diagnosis = diagnosis;
            PreventiveMeasures = preventiveMeasures;
        }
    }
}
