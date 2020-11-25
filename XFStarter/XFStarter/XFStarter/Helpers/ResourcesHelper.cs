using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XFStarter.Helpers
{
    public static class ResourcesHelper
    {
        public const string DynamicAccentColor = nameof(DynamicAccentColor);
        public const string DynamicTextColor = nameof(DynamicTextColor);
        public const string DynamicBackgroundColor = nameof(DynamicBackgroundColor);

        public static bool IsDarkMode;

        public static void SetDynamicResource(string targetResourceName, string sourceResourceName)
        {
            if (!Application.Current.Resources.TryGetValue(sourceResourceName, out var value))
            {
                throw new InvalidOperationException($"key {sourceResourceName} not found in the resource dictionary");
            }

            Application.Current.Resources[targetResourceName] = value;
        }

        public static void SetDynamicResource<T>(string targetResourceName, T value)
        {
            Application.Current.Resources[targetResourceName] = value;
        }

        public static void SetDarkMode()
        {
            SetDynamicResource(DynamicAccentColor, "DarkDynamicAccentColor");
            SetDynamicResource(DynamicTextColor, "DarkDynamicTextColor");
            SetDynamicResource(DynamicBackgroundColor, "DarkDynamicBackgroundColor");
            IsDarkMode = true;
        }

        public static void SetLightMode()
        {
            SetDynamicResource(DynamicAccentColor, "LightDynamicAccentColor");
            SetDynamicResource(DynamicTextColor, "LightDynamicTextColor");
            SetDynamicResource(DynamicBackgroundColor, "LightDynamicBackgroundColor");
            IsDarkMode = false;
        }

        public static void ToggleTheme()
        {
            if(IsDarkMode)
            {
                SetLightMode();
            }
            else
            {
                SetDarkMode();
            }
        }
    }
}