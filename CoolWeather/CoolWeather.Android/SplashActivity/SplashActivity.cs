using System;
using Android.Animation;
using Android.App;
using Android.Content;
using Android.OS;
using Com.Airbnb.Lottie;

namespace CoolWeather.Droid.SplashActivity
{
    [Activity(Label = "SplashScreen",
        Theme = "@style/CoolWeather.SplashScreenWeatherAnimationStyle",
        MainLauncher = true,
        NoHistory = true)]
    public class SplashActivity : Activity, Animator.IAnimatorListener
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.WeatherAnnimationSplashScreenLayout);

            var animationView = FindViewById<LottieAnimationView>(Resource.Id.SplashScreenWeatherAnimation);
            animationView.AddAnimatorListener(this);
            animationView.RepeatCount = 2;
            animationView.PlayAnimation();
        }
        public void OnAnimationCancel(Animator animation)
        {

        }

        public void OnAnimationEnd(Animator animation)
        {
            StartActivity(new Intent(this, typeof(MainActivity)));
        }

        public void OnAnimationRepeat(Animator animation)
        {

        }

        public void OnAnimationStart(Animator animation)
        {

        }
    }
}
