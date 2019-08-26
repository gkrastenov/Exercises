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

namespace AdventureApp
{
    [Activity(Label = "Index", Theme = "@style/AppTheme")]
    public class GlobalActivity : FragmentActivity
    {
        BottomNavigationView bottomNavigation;
        Android.Support.V4.App.Fragment fragPacket;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.global_layout);  
            
            bottomNavigation = FindViewById<BottomNavigationView>(Resource.Id.bottom_navigation);
            bottomNavigation.NavigationItemSelected += BottomNavigation_NavigationItemSelected;

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
                        fragPacket = new Fragment_Home();

                    using (Android.Support.V4.App.FragmentTransaction fragmentTx = SupportFragmentManager.BeginTransaction())
                    {
                        fragmentTx.Replace(Resource.Id.content, fragPacket);
                        fragmentTx.Commit();
                    }
                    break;
                case Resource.Id.menu_search:                   
                        fragPacket = new Fragment_Search();

                    using (Android.Support.V4.App.FragmentTransaction fragmentTx = SupportFragmentManager.BeginTransaction())
                    {
                        fragmentTx.Replace(Resource.Id.content, fragPacket);
                        fragmentTx.Commit();
                    }
                    break;
                case Resource.Id.menu_chat:                   
                        fragPacket = new Fragment_Chat();

                    using (Android.Support.V4.App.FragmentTransaction fragmentTx = SupportFragmentManager.BeginTransaction())
                    {
                        fragmentTx.Replace(Resource.Id.content, fragPacket);
                        fragmentTx.Commit();
                    }
                    break;

                case Resource.Id.menu_profile:                   
                        fragPacket = new Fragment_Profile();

                    using (Android.Support.V4.App.FragmentTransaction fragmentTx = SupportFragmentManager.BeginTransaction())
                    {
                        fragmentTx.Replace(Resource.Id.content, fragPacket);
                        fragmentTx.Commit();
                    }
                    break;
            }         
        }
    }

}
