using Oqtane.Themes;

namespace Oqtane.Theme.Custom
{
    public class ThemeInfo : ITheme
    {
        public Models.Theme Theme => new Models.Theme
        {
            Name = "Oqtane Theme",
            Version = "1.0.0"
        };
    }
}
