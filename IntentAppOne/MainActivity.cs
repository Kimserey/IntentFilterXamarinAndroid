using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace IntentAppOne
{
	[Activity(Label = "Activity ONE", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Main);
			Button button = FindViewById<Button>(Resource.Id.myButton);

			button.Click += (sender, e) => {
				var intent = new Intent("com.kimserey.action.FIND_BASKET");
				intent.SetFlags(ActivityFlags.NewTask);
				StartActivity(intent);
			};
		}
	}
}

