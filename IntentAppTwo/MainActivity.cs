using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace IntentAppTwo
{
	[Activity(Label = "Activity TWO", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.Main);
			Button button = FindViewById<Button>(Resource.Id.myButton);
			button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
		}
	}

	[Activity(Label = "Activity TWO"), IntentFilter(new[] { "com.kimserey.action.FIND_BASKET" }, Categories = new[] { Intent.CategoryDefault })]
	public class CheckBasket : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState); 
			SetContentView(Resource.Layout.Checkbasket);
		}

		protected override void OnNewIntent(Intent intent)
		{
			base.OnNewIntent(intent);
		}
	}
}

