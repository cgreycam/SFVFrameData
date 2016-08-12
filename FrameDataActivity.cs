
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

namespace SFVFrameData
{
	[Activity(Label = "FrameDataActivity")]
	public class FrameDataActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your application here
			SetContentView(Resource.Layout.FrameData);


			ImageButton btnBalrog = FindViewById<ImageButton>(Resource.Id.imgBalrog);
			btnBalrog.Click += delegate
			{
				StartActivity(typeof(BalrogActivity));
			};
			ImageButton btnRainbowMika = FindViewById<ImageButton>(Resource.Id.imgRainbowMika);
			btnRainbowMika.Click += delegate
			{
				StartActivity(typeof(RainbowMikaActivity));
			};
			ImageButton btnIbuki = FindViewById<ImageButton>(Resource.Id.imgIbuki);
			btnIbuki.Click += delegate
			{
				StartActivity(typeof(IbukiActivity));
			};
		}
	}
}

