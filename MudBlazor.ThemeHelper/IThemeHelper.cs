using MudBlazor;

namespace Community.MudBlazor.ThemeHelper
{
    public interface IThemeHelper<T> 
    {
        /// <summary>
        /// This method should return a defined theme that you want to use for your
        /// MudBlazor project
        /// </summary>
        /// <returns></returns>
        MudTheme GetTheme();

        /// <summary>
        /// This method should return a defined theme that you want to use for your
        /// MudBlazor project. Allows for async
        /// </summary>
        /// <returns></returns>
        Task<MudTheme> GetThemeAsync();
        
        /// <summary>
        /// Other Application Data that you can share across projects such as a Title, or name, etc
        /// Suggest a Dictionary<string, object>
        /// </summary>
        /// <returns></returns>
        T GetSharedAppData();

        /// <summary>
        /// Name of App
        /// </summary>
        /// <returns></returns>
        string AppName();
    }
}
