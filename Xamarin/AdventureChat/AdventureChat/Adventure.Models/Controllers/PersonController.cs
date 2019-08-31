namespace Adventure.Controllers
{
    using AdventureApp.Models;
    using System;

    public class PersonController
    {
         private Person currentPerson;

        public PersonController()
        {

        }
        public void SetPerson(Person newPerson)
        {
            this.currentPerson = newPerson;
        }
        public string GetFirstName()
        {
           return this.currentPerson.FirstName;
        }
        public string GetLastName()
        {
            return this.currentPerson.LastName;
        }
        public string GetUsername()
        {
            return this.currentPerson.Username;
        }
    }
}
