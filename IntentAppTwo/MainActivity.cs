using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Newtonsoft.Json;
using Android.Util;

namespace IntentAppTwo
{
	public class BasketMetadata
	{
		public DateTime Date { get; set; }
		public decimal Amount { get; set; }
		public string StoreName { get; set; }
	}

	[Activity(MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.Main);
			Button button = FindViewById<Button>(Resource.Id.myButton);
			button.Click += delegate
			{
				var intent = new Intent("com.kimserey.action.FIND_BASKET");
				intent.PutExtra("com.kimserey.extra.BASKET_METADATA_NAME", "ASDA");
				intent.PutExtra("com.kimserey.extra.BASKET_METADATA_DATE", DateTime.UtcNow.ToString("dd MMMM yyyy").ToUpper());
				intent.PutExtra("com.kimserey.extra.BASKET_METADATA_AMOUNT", (123.22).ToString("C2"));
				StartActivity(intent);
			};
		}
	}

	[Activity]
	[IntentFilter(new[] { "com.kimserey.action.FIND_BASKET" }, Categories = new[] { Intent.CategoryDefault })]
	public class CheckBasket : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Checkbasket);

			FindViewById<TextView>(Resource.Id.basket_name).Text = Intent.GetStringExtra("com.kimserey.extra.BASKET_METADATA_NAME");
			FindViewById<TextView>(Resource.Id.basket_date).Text = Intent.GetStringExtra("com.kimserey.extra.BASKET_METADATA_DATE");
			FindViewById<TextView>(Resource.Id.basket_amount).Text = Intent.GetStringExtra("com.kimserey.extra.BASKET_METADATA_AMOUNT");
		}
	}
}

