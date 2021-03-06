﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventureApp.Models;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Adventure.Models
{
    // one User have many friends    
    public class Friends
    {
        private List<Person> listFriends = new List<Person>();

        public Friends()
        {
            // initial listFriends here
        }

        public void AddFriend(Person user )
        {
            // maybe have to work with User.Id -> will check
            listFriends.Add(user);
        }

        public void RemoveFriend(Person user)
        {
            // maybe have to work with User.Id -> will check
            listFriends.Remove(user);
        }
        public string FriendsCount()
        {
            return listFriends.Count.ToString();
        }

        public void GetUser(int id)
        {
            // must return View page for another person  -> new axml for another guy
        }
    }
}