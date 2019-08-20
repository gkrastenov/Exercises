using System;

namespace AdventureApp.Models
{
    public class User
    {
        #region 
        // values for registration
        private string firstName;
        private string lastName;
        private string password;
        private string email;
        #endregion

        private int age;
        private string phoneNumber;
        private string country;

        public User(string firstName, string lastName, string password, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.email = email;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }


        public string ReturnFullName()
        {
           return this.firstName + " "+ this.lastName;
        }

    }
}