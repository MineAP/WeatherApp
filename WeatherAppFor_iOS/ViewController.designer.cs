// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace WeatherAppFor_iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton GetWeatherButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel HumidityLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel TempLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextZipCodeEdit { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel titleLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel VisivilityLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel WindLabel { get; set; }

        [Action ("GetWeatherButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void GetWeatherButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (GetWeatherButton != null) {
                GetWeatherButton.Dispose ();
                GetWeatherButton = null;
            }

            if (HumidityLabel != null) {
                HumidityLabel.Dispose ();
                HumidityLabel = null;
            }

            if (TempLabel != null) {
                TempLabel.Dispose ();
                TempLabel = null;
            }

            if (TextZipCodeEdit != null) {
                TextZipCodeEdit.Dispose ();
                TextZipCodeEdit = null;
            }

            if (titleLabel != null) {
                titleLabel.Dispose ();
                titleLabel = null;
            }

            if (VisivilityLabel != null) {
                VisivilityLabel.Dispose ();
                VisivilityLabel = null;
            }

            if (WindLabel != null) {
                WindLabel.Dispose ();
                WindLabel = null;
            }
        }
    }
}