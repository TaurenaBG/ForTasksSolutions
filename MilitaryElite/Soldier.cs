using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
     public abstract class Soldier : ISoldier
    {
        
        public string Id { get ; set; }
        public string FirstName { get ; set ; }
        public string LastName { get; set  ; }
        //public decimal Salary { get ; set ; }

        //public override string ToString()
        //{
        //    return $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}"; 
        //}
    }
}
