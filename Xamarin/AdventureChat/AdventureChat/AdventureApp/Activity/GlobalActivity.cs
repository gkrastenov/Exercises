using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;
using Fragment = Android.App.Fragment;
using Newtonsoft.Json;
using AdventureApp.Models;
using Adventure.Controllers;

namespace AdventureApp
{
    [Activity(Label = "Index", Theme = "@style/AppTheme")]
    public class GlobalActivity : FragmentActivity
    {
        private PersonController personController;
        BottomNavigationView bottomNavigation;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.global_layout);  
            
            bottomNavigation = FindViewById<BottomNavigationView>(Resource.Id.bottom_navigation);
            bottomNavigation.NavigationItemSelected += BottomNavigation_NavigationItemSelected;

            Person person = JsonConvert.DeserializeObject<Person>(Intent.GetStringExtra("Person"));
            personController.SetPerson(person);
            // Load the first fragment on creation
            LoadFragment(Resource.Id.menu_home);
        }
        private void BottomNavigation_NavigationItemSelected(object sender, BottomNavigationView.NavigationItemSelectedEventArgs e)
        {
            LoadFragment(e.Item.ItemId);
        }
        void LoadFragment(int id)
        {        
            switch (id)
            {     
                case Resource.Id.menu_home:
                    Fragment_Home fragPacketHome = new Fragment_Home();

                    using (Android.Support.V4.App.FragmentTransaction fragmentTx = SupportFragmentManager.BeginTransaction())
                    {
                        fragmentTx.Replace(Resource.Id.content, fragPacketHome);
                        fragmentTx.Commit();
                    }
                    break;
                case Resource.Id.menu_add:
                    Fragment_AddFriends fragPacketAdd = new Fragment_AddFriends();

                    using (Android.Support.V4.App.FragmentTransaction fragmentTx = SupportFragmentManager.BeginTransaction())
                    {
                        fragmentTx.Replace(Resource.Id.content, fragPacketAdd);
                        fragmentTx.Commit();
                    }
                    break;
                case Resource.Id.menu_chat:
                    Fragment_Chat fragPacketChat = new Fragment_Chat();

                    using (Android.Support.V4.App.FragmentTransaction fragmentTx = SupportFragmentManager.BeginTransaction())
                    {
                        fragmentTx.Replace(Resource.Id.content, fragPacketChat);
                        fragmentTx.Commit();
                    }
                    break;

                case Resource.Id.menu_profile:
                    Fragment_Profile fragPacketProfile = new Fragment_Profile();
                    fragPacketProfile.SetName(personController.GetUsername());
                    using (Android.Support.V4.App.FragmentTransaction fragmentTx = SupportFragmentManager.BeginTransaction())
                    {
                        fragmentTx.Replace(Resource.Id.content, fragPacketProfile);
                        fragmentTx.Commit();
                    }
                    break;
            }         
        }
    }

}
