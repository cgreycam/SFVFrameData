
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
	[Activity(Label = "IbukiActivity")]
	public class IbukiActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your application here
			SetContentView(Resource.Layout.Ibuki);

			// make the buttons change activities
			Button btnApproachIbuki = FindViewById<Button>(Resource.Id.btnApproachIbuki);
			btnApproachIbuki.Click += delegate
			{
				StartActivity(typeof(ApproachIbukiActivity));

			};

			Button btnFrameDataIbuki = FindViewById<Button>(Resource.Id.btnFrameDataIbuki);
			btnFrameDataIbuki.Click += delegate
			{
				StartActivity(typeof(FrameDataIbukiActivity));

			};

		}
	}
}

