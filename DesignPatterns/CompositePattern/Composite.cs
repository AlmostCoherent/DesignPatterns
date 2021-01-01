using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CompositePattern
{
    public class Composite : AbstractComponent
    {
        protected List<AbstractComponent> _children = new List<AbstractComponent>();

        public override void Add(AbstractComponent component)
        {
            _children.Add(component);
        }

        public override void Remove(AbstractComponent component)
        {
            _children.Remove(component);
        }

        public override string Operation()
        {
            int i = 0;
            string result = "Branch(";

            foreach(AbstractComponent component in _children)
            {
                result += component.Operation();
                if(i != _children.Count - 1)
                {
                    result += "+";
                }
                i++;
            }
            return result + ")";
        }
    }
}
