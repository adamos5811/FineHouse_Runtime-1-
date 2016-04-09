using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Newtonsoft.Json;

namespace FineHouseService
{
    [Activity(Label = "FineHouseService", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        public Button mButtonLogIn;
        public Button mButtonSignUp;
        public EditText mUserName;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);


            mButtonLogIn = FindViewById<Button>(Resource.Id.btnLogIn);
            mButtonSignUp = FindViewById<Button>(Resource.Id.btnSignUp);

            mUserName = FindViewById<EditText>(Resource.Id.txtUsername);


            mButtonLogIn.Click += MButtonLogIn_Click;
            mButtonSignUp.Click += MButtonSignUp_Click;

        }

        private void MButtonSignUp_Click(object sender, EventArgs e)
        {
            // mode selection - bname of the activity
            Intent intent = new Intent(this, typeof(Activity3));
            this.StartActivity(intent);
        }

        private void MButtonLogIn_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Activity2));

            User user = new User()
            {
                UserID = 1,
                UserName = mUserName.Text,
                Password = "password"
            };
            intent.PutExtra("User", JsonConvert.SerializeObject(user));

            this.StartActivity(intent);


            // send user data via json 
        }
    }
}

