using BatCell.Models;

namespace BatCell.Pages;

public partial class VilõesPage : ContentPage
{
    public VilõesPage()
    {
        InitializeComponent();

        var vilões = new List<ItemModel>
        {
            new ItemModel { Nome = "CORINGA", Descricao = "O mestre químico do Batman, maníaco e louco, vive para desafiar o Batman e seu equilíbrio mental.", CorDestaque = "#FFC300" },
            new ItemModel { Nome = "ARLEQUINA", Descricao = "Doutora do asilo Arkham, foi seduzida pelo Coringa, tornando-se uma aliada na violência em seus crimes.", CorDestaque = "#E91E63" },
            new ItemModel { Nome = "ESPANTALHO", Descricao = "Ex-professor de psicologia, usa o gás do medo para aumentar e manipular os piores medos das suas vítimas.", CorDestaque = "#8BC34A" },
            new ItemModel { Nome = "PINGUIM", Descricao = "Um dos maiores chefes do crime de Gotham, um hábil negociador e chantagista para manter poder e influência.", CorDestaque = "#2196F3" }
        };

            VilõesList.ItemsSource = vilões;
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}