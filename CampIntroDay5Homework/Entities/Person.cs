using CampIntroDay5Homework.Abstract;
using System;

namespace CampIntroDay5Homework
{
    public class Person : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
        public string PhoneNumber { get; set; }
    }
}
