using CampIntroDay5Homework.OverrideOperation;
using System;
using CampIntroDay5Homework.Adapters;

namespace CampIntroDay5Homework.Concrete
{
    public class CustomerPersonManager:PersonManager
    {
        IMernisService MernisService;

        public CustomerPersonManager(IMernisService mernisService)
        {
            MernisService = mernisService;
        }

        public override void Add(Person person)
        {
            if(MernisService.CheckIfRealPerson(person))
            {
                base.Add(person);
            }
            else
            {
                throw new Exception("Not a valid Person.");
            }
        }
    }

}
