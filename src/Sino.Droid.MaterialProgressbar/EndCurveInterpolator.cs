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
    public class EndCurveInterpolator : AccelerateDecelerateInterpolator
    {
        public override float GetInterpolation(float input)
        {
            return base.GetInterpolation(Math.Max(0, (input - 0.5f) * 2.0f));
        }
    }
}