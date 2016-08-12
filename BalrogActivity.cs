
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
	[Activity(Label = "BalrogActivity")]
	public class BalrogActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your application here
			SetContentView(Resource.Layout.Balrog);

			Button btnApproachBalrog = FindViewById<Button>(Resource.Id.btnApproachBalrog);
			btnApproachBalrog.Click += delegate
	{
		StartActivity(typeof(ApproachBalrogActivity));

	};
			Button btnFrameDataBalrog = FindViewById<Button>(Resource.Id.btnFrameDataBalrog);
			btnFrameDataBalrog.Click += delegate
	{
		StartActivity(typeof(FrameDataBalrogActivity));

	};


		}
	}
}

