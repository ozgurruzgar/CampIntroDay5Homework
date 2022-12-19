using CampIntroDay5Homework.OverrideOperation;
using System.Collections.Generic;
using System.Collections;
using System;
using CampIntroDay5Homework.Concrete;
using CampIntroDay5Homework.Adapters;

namespace CampIntroDay5Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Sales sales = new Sales() { Id = 1, ProductName = "FIFA 2022", Unit = 1, Total = 800 };
            SalesManager salesManager = new CustomerSaleManager();
            salesManager.Add(sales);

            Console.WriteLine("\n"); 

            Sales sales2 = new Sales() { Id = 2, ProductName = "God Of War Ragnörok", Unit = 1, Total = 800 };
            SalesManager salesManager2 = new CustomerSaleManager();
            salesManager.Add(sales2);

            Console.WriteLine("\n");

            Sales sales3 = new Sales() { Id = 3, ProductName = "Infamous Second Son", Unit = 1, Total = 150 };
            SalesManager salesManager3 = new CustomerSaleManager();
            salesManager.Add(sales3);

            Console.WriteLine("\n");

            Person person = new Person() {Id=1,FirstName="Özgür",LastName="Rüzgar",NationalityId="12345678932",DateOfBirth=new DateTime(2002,7,14),PhoneNumber="123456789" };
            PersonManager personManager = new CustomerPersonManager(new CustomerCheckService());
            personManager.Add(person);

            Console.WriteLine("\n");

            Person person2 = new Person() { NationalityId= "12345678932",Id=2,FirstName="Sedat",LastName="Rüzgar",DateOfBirth=new DateTime(1976,6,17),PhoneNumber="123456789"};
            PersonManager personManager2 = new CustomerPersonManager(new MernisServiceAdapter());
            personManager2.Add(person2);

            Console.WriteLine("\n");

            Person person3 = new Person() { Id = 2, FirstName = "Özcan", LastName = "Rüzgar", NationalityId = "12345678932", DateOfBirth = new DateTime(1981, 8, 23), PhoneNumber = "123456789" };
            PersonManager personManager3 = new CustomerPersonManager(new CustomerCheckService());
            personManager3.Add(person3);
        }
    }
}
