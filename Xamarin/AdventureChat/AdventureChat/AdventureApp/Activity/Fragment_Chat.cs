using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventureApp.Adapters;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Support.V7.App;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace AdventureApp
{
    public class Fragment_Chat : Android.Support.V4.App.Fragment
    {
        private Adapter_FriendChat adapter_friendChats;
        private ListView chats;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            var view =  inflater.Inflate(Resource.Layout.fragment_chat, container, false);
            var toolbar = view.FindViewById<Toolbar>(Resource.Id.toolbar_chat);
            toolbar.Title = "Chats";

            HasOptionsMenu = true;

            FragmentActivity activity = this.Activity;
            activity.SetActionBar(toolbar);

            chats = view.FindViewById<ListView>(Resource.Id.list_recentChats);
            adapter_friendChats = new Adapter_FriendChat(this.Activity);
            chats.Adapter = adapter_friendChats;
            return view;
        }

        public override void OnCreateOptionsMenu(IMenu menu, MenuInflater inflater)
        {
            inflater.Inflate(Resource.Menu.toolbar_chat, menu);
            base.OnCreateOptionsMenu(menu, inflater);

        }
        public override bool OnOptionsItemSelected(IMenuItem menu)
        {
            menu.SetChecked(true);
            switch (menu.ItemId)
            {
                case Resource.Id.menu_createGroup:
                    // TODO : Add logic 
                    return true;

            }
            return false;

        }
    }
}