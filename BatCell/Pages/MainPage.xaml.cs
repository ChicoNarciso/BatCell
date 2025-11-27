namespace BatCell.Pages;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnCriminososTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(VilõesPage));
    }

    private async void OnAliadosTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AliadosPage));
    }

    private async void OnEquipamentosTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(GadgetsPage));
    }
}