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
            this.Username = username;
            this.Password = password;
            this.Email = email;
        }
        public User()
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



    }
}