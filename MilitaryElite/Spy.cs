using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public class Spy :Soldier
    {
        public Spy(string id,string firstname,string lastName,int Code)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastName;
            CodeNumber = Code;
                     
        }
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CodeNumber { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id}");
            sb.AppendLine($"Code Number: {CodeNumber}");
            return sb.ToString();
        }
    }
}
