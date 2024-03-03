using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public class Private : Soldier, IPrivate
    {
        public Private(string id, string firstname,string lastname,decimal salary)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Salary = salary;
        }

        public decimal Salary { get; set ; }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is Private otherPrivate))
            {
                return false;
            }

            return otherPrivate.Id == Id;
        }
    }
}
