using Android.App;
using Android.Widget;
using Android.OS;
using Com.Braintreepayments.Api;
using System;

namespace BraintreeV2Example
{
    [Activity (
        Label = "BraintreeV2Example",
        MainLauncher = true,
        Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        BraintreeFragment mBraintreeFragment;

        protected override void OnCreate (Bundle savedInstanceState)
        {
            base.OnCreate (savedInstanceState);

            try {
                mBraintreeFragment = BraintreeFragment.NewInstance(this, "token");
                // mBraintreeFragment is ready to use!
            } catch (Exception e) {
                Console.WriteLine (e);
            }

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button> (Resource.Id.myButton);
			
            button.Click += delegate
            {
                
            };
        }
    }
}


