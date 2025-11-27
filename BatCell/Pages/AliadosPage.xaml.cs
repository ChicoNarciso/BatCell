using BatCell.Models;

namespace BatCell.Pages;

public partial class AliadosPage : ContentPage
{
    public AliadosPage()
    {
        InitializeComponent();

        var aliados = new List<ItemModel>
        {
            new ItemModel { Nome = "CAPUZ VERMELHO", Descricao = "Jason Todd, um ex-Robin que volta como vigilante letal, com um código de honra complexo e brutal.", CorDestaque = "#F44336" },
            new ItemModel { Nome = "ROBIN", Descricao = "O parceiro do Batman, rápido e acrobático. Equilibra o peso do legado de ser o sidekick e o futuro protetor de Gotham.", CorDestaque = "#FFEB3B" },
            new ItemModel { Nome = "MULHER-GATO", Descricao = "Ladrã ágil e moralmente ambígua. Possui uma relação complexa e recorrente com o Batman, sendo aliada em algumas vezes, e rival em outras.", CorDestaque = "#9E9E9E" },
            new ItemModel { Nome = "BATGIRL", Descricao = "Brilhante e talentosa, combina artes marciais com tecnologia para combater o crime e inspirar a cidade.", CorDestaque = "#673AB7" },
            new ItemModel { Nome = "ASA NOTURNA", Descricao = "O primeiro Robin, Dick Grayson, que cresceu, se tornou independente e luta para proteger Bludhaven e Gotham.", CorDestaque = "#00BCD4" }
        };

        AliadosList.ItemsSource = aliados;
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}