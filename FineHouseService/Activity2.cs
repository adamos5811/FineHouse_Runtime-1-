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

        User mUser;
        public TextView mUsr;
        public TextView mId;
        public TextView mEm;
        public TextView mPass1;
        public TextView mPass2;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            SetContentView(Resource.Layout.Activity2);

            mUsr = FindViewById<TextView>(Resource.Id.txtUsr);
            mId = FindViewById<TextView>(Resource.Id.txtId);
            mEm = FindViewById<TextView>(Resource.Id.txtMail);
            mPass1 = FindViewById<TextView>(Resource.Id.txtPass1);
            mPass2 = FindViewById<TextView>(Resource.Id.txtPass2);

            mUser = JsonConvert.DeserializeObject<User>(Intent.GetStringExtra("User"));
            mId.Text = mUser.UserID.ToString();
            mUsr.Text = mUser.UserName.ToString();
            mEm.Text = mUser.Email.ToString();
            mPass1.Text = mUser.Password.ToString();
            mPass2.Text = mUser.Password2.ToString();


        }
    }
}