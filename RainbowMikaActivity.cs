
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
	[Activity(Label = "RainbowMikaActivity")]
	public class RainbowMikaActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your application here
			SetContentView(Resource.Layout.RainbowMika);

			// make the buttons change activities
			Button btnApproachRainbowMika = FindViewById<Button>(Resource.Id.btnApproachRainbowMika);
			btnApproachRainbowMika.Click += delegate
			{
				StartActivity(typeof(ApproachRainbowMikaActivity));

	    	  };

			Button btnFrameDataRainbowMika = FindViewById<Button>(Resource.Id.btnFrameDataRainbowMika);
			btnFrameDataRainbowMika.Click += delegate {
				StartActivity(typeof(FrameDataRainbowMikaActivity));
			};



		}
	}
}

