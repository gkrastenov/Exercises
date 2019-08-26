using System;

namespace AdventureApp.Models
{
    public class User
    {
        #region 
        // values for registration
        private string username;
        private string password;
        private string email;
        #endregion
        /*
        private string firstName;
        private string lastName;
        private string age;
        private string phoneNumber;
        private string country;
        */
        //  private DateTime birthDate;
        public User(string username, string password, string email)
        {
            this.username = username;
            this.password = password;
            this.email = email;
        }
        public User()
        {
            // constructor for UserController
        }
        public string Username { get => this.username; }
        public string Password { get => this.password; }
        public string Email { get => this.email; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }



    }
}