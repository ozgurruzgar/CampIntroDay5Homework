using CampIntroDay5Homework.EntitiesService;
using System;
using System.Collections.Generic;
using System.Text;

namespace CampIntroDay5Homework.OverrideOperation
{
    public abstract class PersonManager : IPersonService
    {
        public virtual void Add(Person person)
        {
            Console.WriteLine("Person Saved To Database. " + person.FirstName);
        }

        public void Delete(Person person)
        {
            Console.WriteLine("Person Deleted From Database. " + person.FirstName);
        }

        public void Update(Person person)
        {
            Console.WriteLine("Person Updated Person. " + person.FirstName);
        }
    }
}
