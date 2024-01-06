using MudBlazor;

namespace Community.MudBlazor.ThemeHelper.Example
{
    public class ThemeHelperExample : IThemeHelper<object>
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

        public string AppName()
        {
            return "Demo Application";
        }

        public async Task<MudTheme> GetThemeAsync()
        {
            return await Task.Run(() => GetTheme());
        }
    }
}