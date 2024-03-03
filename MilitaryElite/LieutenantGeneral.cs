using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public class LieutenantGeneral : Soldier, ILieutenantGeneral,IPrivate
    {

        public LieutenantGeneral(string id, string firstname, string lastname, decimal salary)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Salary = salary;
            Privates = new();
        }
        public HashSet<Private> Privates { get ; set ; }
        public decimal Salary { get ; set ; }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}");
            sb.AppendLine("Privates:");
            foreach (var item in Privates)
            {
                sb.AppendLine($"  {item.ToString()}");
            }
            return sb.ToString().TrimEnd();


        }
    }
}
