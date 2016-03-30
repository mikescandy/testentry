using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;

namespace testentry
{
	[Activity (Label = "testentry", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : ActionBarActivity
	{
		int count = 1;
		bool hasError =false;
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
				var entry = FindViewById<TextInputLayout>(Resource.Id.textInputLayout);
				if (!hasError)
				{
					entry.Error="error";
					entry.ErrorEnabled = true;
					hasError=true;
				}
				else{
					entry.Error=string.Empty;
					entry.ErrorEnabled = false;
					hasError=false;
				}
			};
		}
	}
}


