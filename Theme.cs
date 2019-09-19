using Oqtane.Themes;
using System.Collections.Generic;

namespace Oqtane.Theme.Custom
{
    public class Theme : ITheme
    {
        public Dictionary<string, string> Properties
        {
            get
            {
                Dictionary<string, string> properties = new Dictionary<string, string>
                {
                    { "Name", "Custom Theme" },
                    { "Version", "1.0.0" }
                };
                return properties;
            }
        }
    }
}
