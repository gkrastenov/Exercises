using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureApp.Models;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Firebase.Database;
using Firebase.Database.Query;


namespace AdventureApp
{
    public class FirebaseHelper
    {
        private FirebaseClient firebase = new FirebaseClient("https://mobilechat-adventure.firebaseio.com/");

        public async Task<List<Person>> GetAllUsernameOnPerson()
        {
            return (await firebase
              .Child("Persons")
              .OnceAsync<Person>()).Select(item => new Person
              {
                  Username = item.Object.Username,

              }).ToList();
        }

        public async Task<bool> CheckEmailExist(string email)
        {
            var person = (await firebase
               .Child("Persons")
               .OnceAsync<Person>()).Where(a => a.Object.Email == email).FirstOrDefault();

            if (person != null)
                return true;
            else
                return false;
        }

        public async Task<bool> CheckUsernameExist(string username)
        {
            var person = (await firebase
              .Child("Persons")
              .OnceAsync<Person>()).Where(a => a.Object.Username == username).FirstOrDefault();

            if (person != null)
                return true;
            else
                return false;
        }

        public async Task<bool> CheckCorrectPasswordForPerson(string email, string password)
        {
            var person = (await firebase
              .Child("Persons")
              .OnceAsync<Person>()).Where(a => a.Object.Email == email).FirstOrDefault();

            if (person != null)
                return true;
            else
                return false;
        }

        public void AddPerson(Person person)
        {
            var newPerson = person;
              firebase
             .Child("Persons")
             .PostAsync<Person>(newPerson);
        }
    }
}