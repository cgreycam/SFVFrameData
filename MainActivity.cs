using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace SFVFrameData
{
	[Activity(Label = "SFVFrameData", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button btnDefinition = FindViewById<Button>(Resource.Id.btnDefinition);
			btnDefinition.Click += delegate
			{
				StartActivity(typeof(DefinitionActivity));
			};

			Button btnAbout = FindViewById<Button>(Resource.Id.btnAbout);
			btnAbout.Click += delegate {
				StartActivity(typeof(AboutActivity));
			};

			Button btnFrameData = FindViewById<Button>(Resource.Id.btnFrameData);
			btnFrameData.Click += delegate {
				StartActivity(typeof(FrameDataActivity));
			};



		}
	}
}
