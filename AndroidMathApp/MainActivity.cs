namespace AndroidMathApp
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            TextView? view = FindViewById<TextView>(Resource.Id.TextView);

            string res = "The result is: " + MathCommonNetCore.Utility.Add(5, 7).ToString();
            view.Text = res;

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
        }
    }
}