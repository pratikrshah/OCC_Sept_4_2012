using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCC_WPF_POC
{
    public class Azman
    {
        public int ruleName { get; set; }
        public string ruleDescription { get; set; }
        public RuleProvision rulePrivisionDetails {get; set;}
    }

    public class RuleProvision
    {
        public string RP_Requestor { get; set; }
        public string RP_GroupName { get; set; }

    }
}
