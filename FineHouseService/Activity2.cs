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
    [Activity(Label = "Activity2")]
    public class Activity2 : Activity
    {

        User mLoggedOnUser;
        public TextView mUsr;
        public TextView mId;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            SetContentView(Resource.Layout.Activity2);

            mUsr = FindViewById<TextView>(Resource.Id.txtUsr);
            mId = FindViewById<TextView>(Resource.Id.txtId);

            mLoggedOnUser = JsonConvert.DeserializeObject<User>(Intent.GetStringExtra("User"));
            mId.Text = mLoggedOnUser.UserID.ToString();
            mUsr.Text = mLoggedOnUser.UserName.ToString();


        }
    }
}