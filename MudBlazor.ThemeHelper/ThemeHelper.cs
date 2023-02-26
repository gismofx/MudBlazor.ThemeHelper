using MudBlazor;
namespace MudBlazor.ThemeHelper
{
    public class ThemeHelperExample : IThemeHelper
    {
        public MudTheme GetTheme()
        {
            //Define your theme here!
            return new MudTheme();
        }

        public object GetSharedAppData()
        {
            return new Dictionary<string, object>() {
                {"Title", "MudTheme Helper!"}
            };
        }
    }
}