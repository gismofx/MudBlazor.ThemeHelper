# MudBlazor.ThemeHelper

A simple library to make sharing a single MudBlazor theme across multiple projects and into Razor Class Libraries that use MudBlazor.

## Usage:
```csharp
using Mudblazor.ThemeHelper;
```

### Create a class in your main project that implements `IThemeHelper`
*This is where you will define your theme
```csharp
public class ThemeHelperExample : IThemeHelper
{
  public MudTheme GetTheme()
      {
        return new MudTheme()
          {
              Palette = new Palette()
              {
                  Primary = Colors.Blue.Default,
                  Secondary = Colors.Green.Accent4,
                  AppbarBackground = Colors.Red.Default,
              },
              PaletteDark = new PaletteDark()
              {
                  Primary = Colors.Blue.Lighten1
              },
              LayoutProperties = new LayoutProperties()
              {
                  DrawerWidthLeft = "260px",
                  DrawerWidthRight = "300px"
              }
          };
      }
}
```

### Add the IThemeHelper help class(created above) to Services
Somewhere in your `program.cs` or when setting up DI, call the Extension Method
```csharp
//Add Theme Helper
services.AddMudBlazorThemeHelper<ThemeHelperExample>();
```

### And in your Razor Layouts:
```razor
@using Mudblazor.ThemeHelper
...
<MudThemeProvider Theme="@MyCustomTheme" @ref="@_mudThemeProvider" @bind-IsDarkMode="@_isDarkMode" />

```csharp
 @code{
...
    [Inject]
    public IThemeHelper ThemeHelper { get; set; }

    bool _isDarkMode;
    private MudThemeProvider _mudThemeProvider = new MudThemeProvider();

    private MudTheme MyCustomTheme = null;

    protected override async Task OnInitializedAsync()
    {
        MyCustomTheme = ThemeHelper.GetTheme();
    }
...
}


