using System;
namespace Exercises.Models
{
    public class User
    {

        public User(string username, string operatingSystem, string type)
        {
            Username = username;
            OperatingSystem = operatingSystem;
            Type = type;
        }

        public string Username { get; set; }

        public string OperatingSystem { get; set; }

        public string Type { get; set; }
    }

    public class Person
    {
        public Person(string firstName, string lastName, string city, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public int Age { get; set; }

    }
}
