﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern.Packaging
{
    public class MealWrapper : IPacking
    {
        public string Pack()
        {
            return "Wrapper";
        }
    }
}
