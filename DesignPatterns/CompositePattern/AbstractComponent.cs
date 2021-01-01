using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CompositePattern
{
    public abstract class AbstractComponent
    {
        public AbstractComponent()
        {
        }

        public abstract string Operation();

        public virtual void Add(AbstractComponent component)
        {
            throw new NotImplementedException();
        }
        public virtual void Remove(AbstractComponent component)
        {
            throw new NotImplementedException();
        }
        public virtual bool IsComposite()
        {
            return true;
        }
    }
}
