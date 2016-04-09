using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;

namespace FineHouseService
{
    [Activity(Label = "Activity3")]
    class Activity3 : Activity
    {
        User mLoggedOnUserx;
        public EditText mName;
        public EditText mEmail;
        public EditText mPassword1;
        public EditText mPassword2;
        public Button mButtonSignUp;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            SetContentView(Resource.Layout.Activity3);

            mName = FindViewById<EditText>(Resource.Id.txtName);
            mEmail = FindViewById<EditText>(Resource.Id.txtEmail);
            mPassword1 = FindViewById<EditText>(Resource.Id.txtPassword1);
            mPassword2 = FindViewById<EditText>(Resource.Id.txtPassword2);
            mButtonSignUp = FindViewById<Button>(Resource.Id.btnSignUpx);


            //mLoggedOnUserx = JsonConvert.DeserializeObject<User>(Intent.GetStringExtra("Userx"));
            // pobranie danych z pó³ i zapisanie do u¿ytkowinika


        }

    }
}