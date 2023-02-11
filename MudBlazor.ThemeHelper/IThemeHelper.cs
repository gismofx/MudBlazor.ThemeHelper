using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MudBlazor;

namespace MudBlazor.ThemeHelper
{
    public interface IThemeHelper
    {
        /// <summary>
        /// This method should return a defined theme that you want to use for your
        /// MudBlazor project
        /// </summary>
        /// <returns></returns>
        MudTheme GetTheme();
    }
}
