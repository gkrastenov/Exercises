using System;
using Android.App;
using Android.OS;
using Android.Widget;

namespace AdventureApp

{
    [Activity(Label = "Register")]
    public class RegisterActivity : Activity
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();

        private Button signUp;
        private EditText username;
        private EditText email;
        private EditText password;


        /*protected async override void OnAppearing()
        {

            base.OnAppearing();
            var allPersons = await firebaseHelper.GetAllPersons();
            lstPersons.ItemsSource = allPersons;
            1stPerson is listView
        }*/

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

        private async void SignUp_Click(object sender, EventArgs e)
        {
            var list =   await firebaseHelper.GetAllPersons();
      
           await firebaseHelper.AddPerson("text","test.email","test.password");
            // User newUser = new User(username.Text, email.Text, password.Text);
            username.Text = string.Empty;
            email.Text = string.Empty;
            password.Text = string.Empty;

            // var allPersons = await firebaseHelper.GetAllPersons();

            StartActivity(typeof(GlobalActivity));
        }
    }
}