﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zodiacon.PEParsing {
    public sealed class ExportedSymbol {
        public string Name { get; set; }
        public int Ordinal { get; set; }
        public uint Address { get; set; }
        public string ForwardName { get; set; }
        public string UndecoratedName { get; set; }
    }
}
