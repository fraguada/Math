using Android.Opengl;

namespace AndroidMathApp
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var glView = FindViewById<GLSurfaceView>(Resource.Id.glView) ?? throw new InvalidOperationException("Cannot find GL view");

            if (glView != null)
            {
                glView.SetRenderer(new MyGLRenderer());
                glView.RenderMode = Rendermode.Continuously;
            }

            var textView = FindViewById<TextView>(Resource.Id.TextView);
            string res = "The result is: " + MathCommonNetCore.Utility.Add(5, 7).ToString();

            textView.Text = res;
        }
    }
}