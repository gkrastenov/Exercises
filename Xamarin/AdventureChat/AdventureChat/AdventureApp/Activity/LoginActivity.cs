using System;

using Android.App;
using Android.OS;
using Android.Widget;

namespace AdventureApp
{
    [Activity(Label = "LoginActivity")]
    public class LoginActivity : Activity
    {
        private FirebaseHelper firebaseHelper = new FirebaseHelper();

        private bool canLogin = false;
        private Button btn_loginAs;
        private EditText txt_email;
        private EditText txt_password;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.login);

            btn_loginAs = FindViewById<Button>(Resource.Id.btn_LoginAs);
            txt_email = FindViewById<EditText>(Resource.Id.edit_InputEmail); // rename id from edit_UserName to edit_InputEmail
            txt_password = FindViewById<EditText>(Resource.Id.edit_InputPassword); // rename id from edit_UserPassword to edit_InputPassword

            btn_loginAs.Click += LoginAs_Click;

        }
        private void LoginAs_Click(object sender, EventArgs e)
        {

            var email = txt_email.Text;
            var password = txt_password.Text;
            CheckPersonExist(email, password);

            if(canLogin)
            {
                StartActivity(typeof(GlobalActivity));
            }
            else
            {
                // red text above btn_loginAs  , nevalidni danni , opitaite otnovo
            }
        }
        private async void CheckPersonExist(string email, string password)
        {
            var existEmail = await firebaseHelper.CheckEmailExist(email);

            if (existEmail == false)
            {
                // red text above btn_loginAs  , ne sushtestvuva takova ime
            }

            var correctPassword = await firebaseHelper.CheckCorrectPasswordForPerson(email, password);

            if(correctPassword)
            {
                canLogin = true;
            }
        }
    }
}