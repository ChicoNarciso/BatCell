using BatCell.Pages;

namespace BatCell;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(VilõesPage), typeof(VilõesPage));
        Routing.RegisterRoute(nameof(AliadosPage), typeof(AliadosPage));
        Routing.RegisterRoute(nameof(GadgetsPage), typeof(GadgetsPage));
    }
}