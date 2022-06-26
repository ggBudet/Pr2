using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    internal class OutpatientCard : MedicalHistory
    {
        public Guid Id { get; set; }

        Patient patient;
        public OutpatientCard(Guid id, 
            DateTime dateOfOnsetOfIllness, 
            DateTime recoveryDate, 
            string diagnosis, 
            string preventiveMeasures,
            Patient patient)
            : base (dateOfOnsetOfIllness, 
                  recoveryDate, 
                  diagnosis, 
                  preventiveMeasures)
        {
            Id = id;
            this.patient = patient;
        }
    }
}
