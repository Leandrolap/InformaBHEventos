using InformaBH_Eventos.Model;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Windows.Input;

namespace InformaBH_Eventos.View;

public partial class FilmesCartaz : ContentPage
{
    private ObservableCollection<Filmes> _filmes;

    public ICommand ItemSelectedCommand { get; }
    public FilmesCartaz()
	{
		InitializeComponent();

        BindingContext = this;

        var assembly = typeof(FilmesCartaz).GetTypeInfo().Assembly;
        Stream stream = assembly.GetManifestResourceStream("InformaBH_Eventos.allFilme.json");

        using (var reader = new System.IO.StreamReader(stream))
        {
            var json = reader.ReadToEnd();

            List<Filmes> allfilme = JsonConvert.DeserializeObject<List<Filmes>>(json);
            _filmes = new ObservableCollection<Filmes>(allfilme);
            LtvFilmes.ItemsSource = _filmes;
            
            foreach (var classf in allfilme) 
            {
                if (classf.FaixaEtaria == "Livre")
                {
                    classf.CorEtaria = "Green";
                }
                else if (classf.FaixaEtaria == "10 anos")
                {
                    classf.CorEtaria = "blue";
                }
                else if (classf.FaixaEtaria == "12 anos")
                {
                    classf.CorEtaria = "#FFD700";
                }
                else if (classf.FaixaEtaria == "14 anos")
                {
                    classf.CorEtaria = "orange";
                }
                else if (classf.FaixaEtaria == "16 anos")
                {
                    classf.CorEtaria = "red";
                }
                else if (classf.FaixaEtaria == "18 anos")
                {
                    classf.CorEtaria = "black";
                }

            }
        }
    }

    private async void OnTappedDetalhe(object sender, TappedEventArgs e)
    {
        var selectedItem = (sender as Image)?.BindingContext as Filmes; // Substitua SeuModelo pelo tipo real do seu item
        if (selectedItem != null)
        {
            await Navigation.PushAsync(new DetalhesFilmes(selectedItem));
        }
    }
}