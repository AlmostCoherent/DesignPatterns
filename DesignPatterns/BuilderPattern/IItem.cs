using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    interface IItem
    {
        string Name();
        float Price();
        IPacking Packing();
    }
}
