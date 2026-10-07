namespace MudBlazor.ThemeManager;

/// <summary>
/// Default palette used when no theme has been saved/activated yet, and by the editor's reset.
/// Replaces MudBlazor's stock purple primary with the NeoSiCAF black/gray scheme.
/// </summary>
public static class ThemeDefaults
{
    public const string Primary = "#111111";
    public const string PrimaryHover = "#2b2b2b";
    public const string PrimaryContrastText = "#ffffff";
    public const string AppbarBackground = "#111111";
    public const string AppbarText = "#ffffff";

    public static PaletteLight CreatePaletteLight() => new()
    {
        Primary = Primary,
        // MudBlazor uses PrimaryDarken as the hover color of filled primary components.
        PrimaryDarken = PrimaryHover,
        PrimaryContrastText = PrimaryContrastText,
        AppbarBackground = AppbarBackground,
        AppbarText = AppbarText
    };

    public static MudTheme CreateTheme() => new()
    {
        PaletteLight = CreatePaletteLight()
    };
}
