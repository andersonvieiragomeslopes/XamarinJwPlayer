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
using JwPlayerXamarin.DependencyService;
using JwPlayerXamarin.Droid.DependencyService;
using Xamarin.Forms;

[assembly: Dependency(typeof(OpenJwPlayer))]

namespace JwPlayerXamarin.Droid.DependencyService
{
    public class OpenJwPlayer : Activity, IOpenJwPlayer
    {
        public void Open()
        {
            try
            {
                Intent intent = new Intent(Android.App.Application.Context, typeof(JwPlayerActivity));
                intent.SetFlags(ActivityFlags.NewTask);
                Android.App.Application.Context.StartActivity(intent);
            }
            catch (Exception)
            {
                // no implemented
                throw;
            }


        }
    }
}