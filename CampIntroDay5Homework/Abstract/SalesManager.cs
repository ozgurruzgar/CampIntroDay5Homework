using CampIntroDay5Homework.EntitiesService;
using System;
using System.Collections.Generic;
using System.Text;

namespace CampIntroDay5Homework.OverrideOperation
{
    public abstract class SalesManager : ISalesService
    {
        public virtual void Add(Sales sales)
        {
            Console.WriteLine("Purchase Saved To Database.");
        }

        public void Delete(Sales sales)
        {
            Console.WriteLine("Purchase Deleted From Database.");
        }

        public void Update(Sales sales)
        {
            Console.WriteLine("Purchase Updated.");
        }
    }
}
