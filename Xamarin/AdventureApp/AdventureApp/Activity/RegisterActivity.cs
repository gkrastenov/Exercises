using System;
using Android.App;
using Android.OS;
using Android.Widget;
using Adventure.Controllers;
using AdventureApp.Models;

namespace AdventureApp
{
    [Activity(Label = "Register")]
    public class RegisterActivity : Activity
    {
        private Button signUp;
        private EditText username;
        private EditText email;
        private EditText password;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.register);

            signUp = FindViewById<Button>(Resource.Id.btn_SignUp);
            username = FindViewById<EditText>(Resource.Id.edit_Username);
            email = FindViewById<EditText>(Resource.Id.edit_Email);
            password = FindViewById<EditText>(Resource.Id.edit_Password);

            // TODO: Add validations

            signUp.Click += SignUp_Click;
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            User newUser = new User(username.Text, email.Text, password.Text);
            UserController userController = new UserController(newUser);

            StartActivity(typeof(GlobalActivity));
        }
    }
}