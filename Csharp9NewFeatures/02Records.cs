using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp9NewFeatures
{
    public record PersonRecord(string Name, string Surname);

    internal class _02Records
    {
        public void Demo()
        {
            var firstRecord = new PersonRecord("Silver", "Chariot");
            var secondRecord = new PersonRecord("Silver", "Chariot");
            var thirdRecord = firstRecord with {Name = "Test"};
            var another2 = firstRecord with { };
            var (name, surname) = firstRecord;

            var firstStruct = new PersonStruct("Silver", "Chariot");
            var secondStruct = new PersonStruct("Hermit", "Purple");

            var firstClass = new PersonClass("Silver", "Chariot",23);
            var secondClass = new PersonClass("Hermit", "Purple", 50);

            Console.WriteLine(firstRecord == secondRecord);
            //Console.WriteLine(firstStruct == secondStruct);
            Console.WriteLine(firstClass == secondClass);

            Console.WriteLine(firstRecord.ToString());
            Console.WriteLine(firstStruct.ToString());
            Console.WriteLine(firstClass.ToString());
        }
    }
    public class PersonClass
    {
        public string Name { get; init; }
        public string Surname { get; init; }
        public int Age { get; set; }
        public PersonClass(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }

    public struct PersonStruct
    {
        public string Name { get; init; }
        public string Surname { get; init; }

        public PersonStruct(string name , string surname)
        {
            Name = name;
            Surname = surname;
        }
    }

    //Record inheritance
    public record EmployeeRecord(string Name, string Surname, string Position) : PersonRecord(Name, Surname);

}
