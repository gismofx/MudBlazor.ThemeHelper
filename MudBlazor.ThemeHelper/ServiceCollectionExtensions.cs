using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudBlazor.ThemeHelper
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Create the ThemeHelper service as a Singleton to be injected throughout your app
        /// </summary>
        /// <typeparam name="TThemeHelper">Class that Implements IThemeHelper</typeparam>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddMudBlazorThemeHelper<TThemeHelper>(this IServiceCollection services) where TThemeHelper : IThemeHelper
        {
            return services.AddSingleton(typeof(IThemeHelper),typeof(TThemeHelper));
        }

        //public static IServiceCollection AddTransientRepository<TPoco>(this IServiceCollection services) where TPoco : class
        //{
        //    services.AddTransient(typeof(IRepository<TPoco>), typeof(Repository<TPoco>));
        //    return services;
        //}

    }
}
