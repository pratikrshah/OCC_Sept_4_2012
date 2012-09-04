﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCC_WPF_POC
{
    public class Rule_Model_1
    {
        public string topMessage { get; set; }
        public List<string> recipients { get; set; }
        public string bottomMessage { get; set; }
        public string hypLink { get; set; }
        public OCCBlock blockType { get; set; }
        public string Image { get { return "/Resource/Images/" + blockType + ".png"; } }

        public enum OCCBlock
        {
            HardBlock,
            SoftBlock,
            ModifyAndSend
        }
    }
}
