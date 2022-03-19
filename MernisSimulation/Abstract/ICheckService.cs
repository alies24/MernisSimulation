using MernisSimulation.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MernisSimulation.Abstract
{
    public interface ICheckService
    {
        bool Check(Person person);
    }
}
