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
        FirebaseClient firebase = new FirebaseClient("https://mobilechat-adventure.firebaseio.com/");

        public async Task<List<User>> GetAllPersons()
        {

            return (await firebase
              .Child("Persons")
              .OnceAsync<User>()).Select(item => new User
              {
                  Username = item.Object.Username,
                  Email = item.Object.Email,
                  Password = item.Object.Password

              }).ToList();
        }

        public async Task AddPerson(string username, string email, string password)
        {
            var newUser = new User(username, email, password);
            await firebase
             .Child("Persons")
             .PostAsync<User>(newUser);

        }

    }
}