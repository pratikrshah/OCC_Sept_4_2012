using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCC_WPF_POC
{
    class AzmanViewModel: ViewModelBase
    {
        #region Properties

        //public List<Azman> az_rules { get; set; }
        public ObservableCollection<Azman> az_rules
        {
            get
            {
                return _az_rules;
            }
        }

        #region Initializing Rules

        private static ObservableCollection<Azman> _az_rules = new ObservableCollection<Azman>(new List<Azman>()
            {
                new Azman()
                {
                    ruleName = 400,
                    ruleDescription = "External Recipients",
                    rulePrivisionDetails = new RuleProvision()
                    {
                        RP_Requestor = "Carlos",
                        RP_GroupName = "gs-operations"
                    }
                },

                new Azman()
                {
                    ruleName = 527,
                    ruleDescription = "Operations Classification",
                    rulePrivisionDetails = new RuleProvision()
                    {
                        RP_Requestor = "Carlos",
                        RP_GroupName = "gs-operations"
                    }
                }
            });
        #endregion
        #endregion
  
        #region Constructor
        public AzmanViewModel()
        {
            #region Commented Out code
            //az_rules = new ObservableCollection<Azman>();

            //az_rules.Add(new Azman()
            //{
            //    ruleName = 400,
            //    ruleDescription = "External Recipients",
            //    rulePrivisionDetails = new RuleProvision()
            //    {
            //        RP_Requestor = "Carlos",
            //        RP_GroupName = "gs-operations"
            //    }

            //});

            //az_rules.Add(new Azman()
            //{
            //    ruleName = 527,
            //    ruleDescription = "Operations Classification",
            //    rulePrivisionDetails = new RuleProvision()
            //    {
            //        RP_Requestor = "Carlos",
            //        RP_GroupName = "gs-operations"
            //    }

            //});

            #endregion
        }
        #endregion
    }
}