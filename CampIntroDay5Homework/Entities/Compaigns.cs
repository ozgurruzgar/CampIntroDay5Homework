using CampIntroDay5Homework.Abstract;

namespace CampIntroDay5Homework
{
    public class Compaigns:IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
