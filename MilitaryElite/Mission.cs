using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public class Mission
    {
        public Mission(string name,string status)
        {
            CodeName = name;
            Status = status;
        }
        public string  CodeName { get; set; }
        public string Status { get; set; } 

        public void CompleteMission()
        {
            
            this.Status = "Finished";
        }
        public override string ToString()
        {
            return $"Code Name: {CodeName} State: {Status}";
        }

    }
}
