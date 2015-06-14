﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class NodeName : Attribute
    {
        public string Name { get; set; }

        public NodeName(string name)
        {
            Name = name;
        }
    }
}
