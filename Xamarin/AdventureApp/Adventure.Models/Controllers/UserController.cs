namespace Adventure.Controllers
{
    using AdventureApp.Models;
    using System;

    public class UserController
    {
        private User currentUser;

        public UserController(User newUser)
        {
            this.currentUser = newUser;
            RegisterNewUser(newUser);
        }

        public string GetFullName()
        {
            return currentUser.FirstName + " " + currentUser.LastName;
        }
        public string GetAge()
        {
            return currentUser.Age;
        }
        public string GetCountry()
        {
            return currentUser.Country;
        }
        public string GetPhoneNumber()
        {
            return currentUser.PhoneNumber;
        }
        private void RegisterNewUser(User newUser)
        {
           // TODO : method for Register new User;
        }

    }
}
