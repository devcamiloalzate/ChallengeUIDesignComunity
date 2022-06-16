using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeUIDesign.Models
{
    public class FinanceItem
    {
        public string Name { get; internal set; }
        public string Info { get; internal set; }
        public string Info2 { get; internal set; }
        public string FirstPercent { get; internal set; }
        public string SecondPercent { get; internal set; }
        public bool IsSecondPercent { get; internal set; }
        public string Icon { get; internal set; }
    }
}
