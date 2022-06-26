using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    internal class Patient : HumanoidOrganism
    {
        public Guid IdPatient { get; set; }
        public string PassportData { get; set; }
        public int InsurancePolicyNumber { get; set; }

        public Patient(Guid idPatient, 
            string passportData, 
            int insurancePolicyNumber, 
            string lastName, 
            string name, 
            string middleName, 
            string gender, 
            DateTime dateOfBirthday)
            : base(lastName, 
                  name, 
                  middleName,
                  gender,
                  dateOfBirthday)
        {
            IdPatient = idPatient;
            PassportData = passportData;
            InsurancePolicyNumber = insurancePolicyNumber;
        }

    }
}
