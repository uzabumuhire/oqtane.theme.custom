using Oqtane.Themes;

namespace Oqtane.Theme.Custom
{
    public class ThemeInfo : ITheme
    {
        public Models.Theme Theme => new Models.Theme
        {
            Name = "Custom Theme",
            Version = "0.9.0"
        };
    }
}
