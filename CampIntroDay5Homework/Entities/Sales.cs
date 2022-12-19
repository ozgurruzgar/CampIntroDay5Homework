using CampIntroDay5Homework.Abstract;

namespace CampIntroDay5Homework
{
    public class Sales : IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Unit { get; set; }
        public double Total { get; set; }
    }
}
