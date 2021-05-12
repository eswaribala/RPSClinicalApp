using System;
using Xamarin.Forms;
namespace RPSClinicalApp.Themes
{
    public class ThemeManager
    {
        public static void ChangeTheme(string themeName)
        {
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Clear();
            var type = typeof(ThemeManager);
            var uri = $"{type.Assembly.GetName().Name}.Themes.{themeName}";
            var theme = Type.GetType(uri);
            Application.Current.Resources.MergedWith = theme;
        }
    }
}
