using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    internal class Employee : HumanoidOrganism
    {
        public Guid Id { get; set; }

        public Post Post { get; set; }

        public Employee(Guid id, 
            string lastName, 
            string name, 
            string middleName, 
            string gender, 
            DateTime dateOfBirthday) 
            : base (lastName, 
                  name, 
                  middleName, 
                  gender, 
                  dateOfBirthday)
        {
            Id = id;
        }

        public void AddEmployee()
        {

        }

        public void ChangeEmployee()
        {

        }

        public void DeleteEmployee()
        {

        }
    }
}
