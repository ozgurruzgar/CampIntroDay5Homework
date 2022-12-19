using CampIntroDay5Homework.EntitiesService;
using System;
using System.Collections.Generic;
using System.Text;

namespace CampIntroDay5Homework.OverrideOperation
{
    public  class CompaignsManager : ICompaignService
    {
        public void Add(Compaigns compaigns)
        {
            Console.WriteLine("New Compaings Added. " + compaigns.Title);
        }

        public void Delete(Compaigns compaigns)
        {
            Console.WriteLine("Compaings Deleted. " + compaigns.Title);
        }

        public void Update(Compaigns compaigns)
        {
            Console.WriteLine("Compaings Updated. " + compaigns.Title);
        }
    }
}
