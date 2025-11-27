using BatCell.Models;

namespace BatCell.Pages;

public partial class GadgetsPage : ContentPage
{
    public GadgetsPage()
    {
        InitializeComponent();

        var equipamentos = new List<ItemModel>
        {
            new ItemModel { Nome = "A CAPA", Descricao = "A capa, feita de tecido memory-cloth e fibras resistentes, pode enrijecer ou relaxar em segundos. Crucial para planadores (glide) e para camuflagem.", CorDestaque = "#CCCCCC" },
            new ItemModel { Nome = "CINTO DE UTILIDADES", Descricao = "Utilizado para carregar todos os equipamentos, desde gel explosivo, bat-arpeis, respiradores e outros. Reabastecido com base nas necessidades.", CorDestaque = "#FFC300" },
            new ItemModel { Nome = "BAT-ARRANQUE", Descricao = "Dispositivo em forma de morcego utilizado para prender-se a objetos, puxar inimigos ou transportar-se. Essencial para movimentação rápida.", CorDestaque = "#9E9E9E" },
            new ItemModel { Nome = "BOMBAS DE FUMAÇA", Descricao = "Usadas para criar distrações, encobrir movimentos ou desorientar inimigos. São cruciais para a tática de 'surpresa' do Batman.", CorDestaque = "#AAAAAA" }
        };

        GadgetsList.ItemsSource = equipamentos;
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}