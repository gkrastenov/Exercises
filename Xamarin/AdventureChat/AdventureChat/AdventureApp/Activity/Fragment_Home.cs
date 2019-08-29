using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace AdventureApp
{
    public class Fragment_Home : Android.Support.V4.App.Fragment
    {
        // doesn't need from constructor
        public Fragment_Home()
        {

        }
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view =  inflater.Inflate(Resource.Layout.fragment_home, container, false);
            var toolbar = view.FindViewById<Toolbar>(Resource.Id.toolbar_home);
            toolbar.Title = "Index";

            HasOptionsMenu = true;

            FragmentActivity activity = this.Activity;
            activity.SetActionBar(toolbar);

            return view;
        }
        public override void OnCreateOptionsMenu(IMenu menu, MenuInflater inflater)
        {
            inflater.Inflate(Resource.Menu.toolbar_home, menu);
            base.OnCreateOptionsMenu(menu, inflater);

        }
    }
}