using System;

namespace AdventureApp.Models
{
    public class Person
    {
        public Person(string username, string email, string password)
        {
            this.Username = username;
            this.Password = password;
            this.Email = email;
            CreateNullValues();
        }
        public Person()
        {
            // constructor for UserController
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }

        // have to add initl
        public DateTime BirthDate { get; set; }

    private void CreateNullValues()
        {
            this.Age = "0";
            this.FirstName = "0";
            this.LastName = "0";
            this.PhoneNumber = "0";
            this.Country = "0";          
        }
    }
}