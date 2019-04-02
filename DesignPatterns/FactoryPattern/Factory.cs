using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    public static class Factory
    {
        public static IFactoryReturn GetFactoryReturnObject(ReturnType returnType)
        {
            switch (returnType)
            {
                case ReturnType.First:
                    return new FactoryReturnFirst();
                case ReturnType.Second:
                    return new FactoryReturnSecond();
                case ReturnType.Third:
                    return new FactoryReturnThird();
                default:
                    return new FactoryReturnDefault();
            }
        }
    }
}
