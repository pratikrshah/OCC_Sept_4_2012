using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCC_WPF_POC
{
    class Rule_VM_1
    {
        #region Properties
        public List<Rule_Model_1> rule { get; set; }
        #endregion

        #region Constructor
        public Rule_VM_1()
        {
            #region Initializing a Rule
            rule = new List<Rule_Model_1>();

            rule.Add(new Rule_Model_1()
            {
                topMessage = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                recipients = new List<string> {"pratik@hotmail.com", "pratikrshah@gmail.com"},
                bottomMessage = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                hypLink = "http://www.gs.com",
                blockType = Rule_Model_1.OCCBlock.SoftBlock
            });
            #endregion
        }
        #endregion
    }
}
