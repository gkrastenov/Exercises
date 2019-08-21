using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Support.Design.Widget;

namespace AdventureApp
{
    [Activity(Label = "Adventure", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button loginButton;
        Button registerButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
          
            loginButton = FindViewById<Button>(Resource.Id.btn_Login);
            registerButton = FindViewById<Button>(Resource.Id.btn_Register);          
            loginButton.Click += LoginButton_Click;
            registerButton.Click += RegisterButton_Click;

        }
        private void RegisterButton_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(RegisterActivity));
        }

        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(LoginActivity));
        }
    }
}