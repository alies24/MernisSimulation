using MernisSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MernisSimulation.Concrete
{
    public class PersonCheckManager : ICheckService
    {
        ICheckService _checkService;
        public PersonCheckManager(ICheckService checkService)
        {
            _checkService = checkService;

        }
        public bool Check(Person person)
        {
            if (_checkService.Check(person))
            {
                Console.WriteLine("Kullanıcı bilgileri doğru.");

                return true;    
            }
            
            else
            {
                Console.WriteLine("Kullanıcı bilgileri hatalı.");
                return false;
            }
        }
    }
}
