using System;
using System.Collections.Generic;
using System.Text;

namespace CampIntroDay5Homework.Adapters
{
    public class CustomerCheckService : IMernisService
    {
        public bool CheckIfRealPerson(Person person)
        {
            return true;
        }
    }
}
