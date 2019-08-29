using System;

using Android.App;
using Android.OS;
using Android.Widget;

namespace AdventureApp
{
    [Activity(Label = "LoginActivity")]
    public class LoginActivity : Activity
    {
        private Button loginAs;
        private EditText username;
        private EditText password;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.login);

            loginAs = FindViewById<Button>(Resource.Id.btn_LoginAs);
            username = FindViewById<EditText>(Resource.Id.edit_UserName);
            password = FindViewById<EditText>(Resource.Id.edit_UserPassword);

            loginAs.Click += LoginAs_Click;

        }
        private void LoginAs_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(GlobalActivity));
        }
    }
}