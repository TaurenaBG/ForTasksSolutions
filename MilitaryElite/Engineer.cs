using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public class Engineer : Soldier, IEngineer, ISpecialisedSoldier,IPrivate
    {
        public Engineer(string id, string firstname, string lastname, decimal salary, string corpType)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Salary = salary;
            CorpType = corpType;
            Repairs = new();

        }


        public List<Repair> Repairs { get; set ; }
        public string CorpType { get ; set ; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}");
            sb.AppendLine($"Corps: {CorpType.ToString()}");
            sb.AppendLine("Repairs:");
            foreach (var item in Repairs)
            {
                sb.AppendLine($"  {item.ToString()}");
            }
            return sb.ToString().TrimEnd();


        }
    }
}
