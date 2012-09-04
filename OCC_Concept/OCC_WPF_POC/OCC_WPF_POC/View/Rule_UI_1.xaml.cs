using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OCC_WPF_POC
{
    /// <summary>
    /// Interaction logic for Rule_UI_1.xaml
    /// </summary>
    public partial class Rule_UI_1 : UserControl
    {
        Rule_VM_1 rulevm1;
        public Rule_UI_1()
        {
            InitializeComponent();
            rulevm1 = new Rule_VM_1();
            DataContext = rulevm1; 
        }
    }
}
