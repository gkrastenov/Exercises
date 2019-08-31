using System;
using Android.App;
using Android.OS;
using Android.Widget;
using Adventure.Controllers;
using AdventureApp.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System.Collections.Generic;
using System.Threading.Tasks;
using Android.Content;
using Newtonsoft.Json;

namespace AdventureApp

{
    [Activity(Label = "Register")]
    public class RegisterActivity : Activity
    {
        private FirebaseHelper firebaseHelper = new FirebaseHelper();

        private Button signUp;
        private EditText username;
        private EditText email;
        private EditText password;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.register);

            signUp = FindViewById<Button>(Resource.Id.btn_SignUp);
            username = FindViewById<EditText>(Resource.Id.edit_Username);
            email = FindViewById<EditText>(Resource.Id.edit_Email);
            password = FindViewById<EditText>(Resource.Id.edit_Password);

            // TODO: Add validations

            signUp.Click += SignUp_Click;
        }

        private async void SignUp_Click(object sender, EventArgs e)
        {     
            Person person = new Person(username.Text, email.Text, password.Text);           

            var emailExist = await firebaseHelper.CheckEmailExist(email.Text);
            var usernameExist = await firebaseHelper.CheckUsernameExist(username.Text);

            username.Text = string.Empty;
            email.Text = string.Empty;
            password.Text = string.Empty;

            if(emailExist==true || usernameExist == true)
            {
                throw new InvalidOperationException("ne moje da se registrira potrebitel");
            }
            firebaseHelper.AddPerson(person);

            Intent intent = new Intent(this, typeof(GlobalActivity));
            intent.PutExtra("Person", JsonConvert.SerializeObject(person));

            this.StartActivity(intent);
            this.Finish();

            
        }
    }
}