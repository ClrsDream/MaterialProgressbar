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
using Android.Views.Animations;

namespace Sino.Droid.MaterialProgressbar
{
    public class StartCurveInterpolator : AccelerateDecelerateInterpolator
    {
        public override float GetInterpolation(float input)
        {
            return base.GetInterpolation(Math.Min(1, input * 2.0f));
        }
    }
}