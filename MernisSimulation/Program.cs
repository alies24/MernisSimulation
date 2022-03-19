using MernisSimulation.Concrete;
using System;

namespace MernisSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Person person = new Person();

            person.NationalityId = 24853704878;
            person.FirstName = "ALİ";
            person.LastName = "AKBABA";
            person.BirthYear = 2000;
            



            PersonCheckManager personCheckManager = new PersonCheckManager(new MernisService());
            personCheckManager.Check(person);
        }
    }
}
