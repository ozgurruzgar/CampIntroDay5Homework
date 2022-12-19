using CampIntroDay5Homework.OverrideOperation;
using System;
using System.Collections.Generic;
using System.Text;
using CampIntroDay5Homework.Abstract;

namespace CampIntroDay5Homework.Concrete
{
    public class CustomerSaleManager : SalesManager
    {
        public override void Add(Sales sales)
        {
            Compaigns compaigns1 = new Compaigns()
            {
                Id = 1,
                Title = "New Year Compaings",
                Description = "Espacially To New Year %30 Sale From Game.",
            };
            AddCompaigns(compaigns1);
            base.Add(sales);
        }
        
        private void AddCompaigns(Compaigns compaigns)
        {
            Console.WriteLine("Compaings Added. " + compaigns.Title);
        }
        
    }

}
