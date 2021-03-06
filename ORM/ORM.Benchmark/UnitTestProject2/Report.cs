﻿using System.Collections.Generic;

namespace UnitTestProject2
{
    public class Report
    {
        public int RowCount { get; set; }

        public double CostTime { get; set; }

        public string Name { get; set; }

        public int Index { get; set; }

        public double Average { get; set; }

        public int RunTime { get; set; }

        public int RunCount { get; set; }

        public IEnumerable<Report> Details { get; set; }

        public object Data { get; set; }
    }
}