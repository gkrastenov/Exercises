using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Support.Design.Widget;

using Firebase.Messaging;
using Firebase.Iid;
using Android.Util;
using Android.Gms.Common;

namespace AdventureApp
{
    [Activity(Label = "AdventureChat", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button loginButton;
        Button registerButton;

        static readonly string TAG = "MainActivity";

        internal static readonly string CHANNEL_ID = "my_notification_channel";
        internal static readonly int NOTIFICATION_ID = 100;

        TextView msgText;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
          
            loginButton = FindViewById<Button>(Resource.Id.btn_Login);
            registerButton = FindViewById<Button>(Resource.Id.btn_Register);

            msgText = FindViewById<TextView>(Resource.Id.msgText);
            loginButton.Click += LoginButton_Click;
            registerButton.Click += RegisterButton_Click;
            #region test notifications
            var logTokenButton = FindViewById<Button>(Resource.Id.logTokenButton);
            logTokenButton.Click += delegate {
                Log.Debug(TAG, "InstanceID token: " + FirebaseInstanceId.Instance.Token);
            };         
            if (Intent.Extras != null)
            {
                /*
                When the user taps a notification issued from FCMClient, any data accompanying that notification
                message is made available in Intent extras. Edit MainActivity.cs and add the following code to the top 
                of the OnCreate method (before the call to IsPlayServicesAvailable):
                    */
                foreach (var key in Intent.Extras.KeySet())
                {
                    var value = Intent.Extras.GetString(key);
                    Log.Debug(TAG, "Key: {0} Value: {1}", key, value);
                }
            }
#endregion

            IsPlayServicesAvailable();
            CreateNotificationChannel();
        }
        private void RegisterButton_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(RegisterActivity));
        }

        private void LoginButton_Click(object sender, System.EventArgs e)
        {           
            StartActivity(typeof(LoginActivity));
        }

        public bool IsPlayServicesAvailable()
        {

            // Notice : If your app has an OnResume method, it should call IsPlayServicesAvailable from OnResume as well.


            int resultCode = GoogleApiAvailability.Instance.IsGooglePlayServicesAvailable(this);
            if (resultCode != ConnectionResult.Success)
            {
                if (GoogleApiAvailability.Instance.IsUserResolvableError(resultCode))
                    msgText.Text = GoogleApiAvailability.Instance.GetErrorString(resultCode);
                else
                {
                    msgText.Text = "This device is not supported";
                    Finish();
                }
                return false;
            }
            else
            {
                msgText.Text = "Google Play Services is available.";
                return true;
            }
        }

        void CreateNotificationChannel()
        {
            /*
             This code checks the device to see if the Google Play Services APK is installed.
             If it is not installed, a message is displayed in the TextBox that instructs the user to download an APK from the Google Play Store
             (or to enable it in the device's system settings).
             Apps that are running on Android 8.0 (API level 26) or higher must create a notification channel for publishing their notifications. 
             Add the following method to the MainActivity class which will create the notification channel (if necessary): 
              */
            if (Build.VERSION.SdkInt < BuildVersionCodes.O)
            {
                // Notification channels are new in API 26 (and not a part of the
                // support library). There is no need to create a notification
                // channel on older versions of Android.
                return;
            }

            var channel = new NotificationChannel(CHANNEL_ID,
                                                  "FCM Notifications",
                                                  NotificationImportance.Default)
            {

                Description = "Firebase Cloud Messages appear in this channel"
            };

            var notificationManager = (NotificationManager)GetSystemService(Android.Content.Context.NotificationService);
            notificationManager.CreateNotificationChannel(channel);
        }


    }
}