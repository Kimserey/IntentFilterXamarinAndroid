using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Newtonsoft.Json;

namespace IntentAppOne
{
	public class BasketMetadata
	{
		public DateTime Date { get; set; }
		public decimal Amount { get; set; }
		public string StoreName { get; set; }
	}

	[Activity(Label = "Activity ONE", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Main);
			Button button = FindViewById<Button>(Resource.Id.myButton);

			button.Click += (sender, e) =>
			{
				var intent = new Intent("com.kimserey.action.FIND_BASKET");
				intent.PutExtra("com.kimserey.extra.BASKET_METADATA_NAME", "ASDA FROM A");
				intent.PutExtra("com.kimserey.extra.BASKET_METADATA_DATE", DateTime.UtcNow.ToString("dd MMMM yyyy").ToUpper());
				intent.PutExtra("com.kimserey.extra.BASKET_METADATA_AMOUNT", (222.22).ToString("C2"));
				intent.SetFlags(ActivityFlags.NewTask);
				StartActivity(intent);
			};
		}
	}
}

