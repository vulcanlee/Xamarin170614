using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XAndroid1
{
    [Activity(Label = "XAndroid1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            EditText fooEditText = FindViewById<EditText>(Resource.Id.editText1);
            Button fooButton = FindViewById<Button>(Resource.Id.button1);
            TextView fooTextView = FindViewById<TextView>(Resource.Id.textView1);

            fooButton.Click += (s, e) =>
                {
                    fooTextView.Text = fooEditText.Text;
                };

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}

