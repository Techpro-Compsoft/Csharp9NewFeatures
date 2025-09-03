using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp9NewFeatures
{
    internal class _01InitOnlyMembers
    {
        public void Demo()
        {
            var person = new PersonClassNew() { Name = "Silver", Surname = "Chariot" };
            //person.Name = "Hermit";
        }
    }
    public class PersonClassOld1
    {
        public string Name { get; }
        public string Surname { get; }

        public PersonClassOld1()
        {
            Name = "Silver";
            Surname = "Chariot";
        }
    }

    public class PersonClassOld
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public PersonClassOld()
        {
            Name = "Silver";
            Surname = "Chariot";
        }
    }
    public class PersonClassNew
    {
        public string Name { get; init; }
        public string Surname { get; init; }
    }
}
