using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public class Commando : Soldier, ICommando,ISpecialisedSoldier,IPrivate
    {

        public Commando(string id, string firstname, string lastname, decimal salary,string corpType)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Salary = salary;
            CorpType = corpType;
            Missions = new();

        }
        public List<Mission> Missions { get ; set ; }
        public string CorpType { get ; set ; }
        public decimal Salary { get ; set; }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}");
            sb.AppendLine($"Corps: {CorpType.ToString()}");
            sb.AppendLine("Missions:");
            foreach (var item in Missions)
            {
                sb.AppendLine($"  {item.ToString()}");
            }
            return sb.ToString().TrimEnd();


        }
    }
}
