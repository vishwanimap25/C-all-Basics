﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestions
{
    internal class Region
    {
        public string Name { get; set; }
        public List<Dist> dists { get; set; } = new List<Dist>();
    }
}
