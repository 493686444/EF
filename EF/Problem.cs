using System;
using System.Collections.Generic;
using System.Text;

namespace EF
{
    public class Problem:Content
    {
        public int? Reward { get; set; }
        public ProblemStatus Status { get; set; }
}
}
