using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MediatorPattern
{
    public interface IMediator
    {
        void Shout(Message message, Person person);
    }
}
