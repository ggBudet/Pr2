using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    internal class HumanoidOrganism
    {
        public string LastName { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirthday { get; set; }

        public HumanoidOrganism(string lastName, string name, string middleName, string gender, DateTime dateOfBirthday)
        {
            LastName = lastName;
            Name = name;
            MiddleName = middleName;
            Gender = gender;
            DateOfBirthday = dateOfBirthday;
        }
    }
}
