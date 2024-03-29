using InformaBH_Eventos.Model;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Reflection;

namespace InformaBH_Eventos.View;

public partial class FilmesCartaz : ContentPage
{
    private ObservableCollection<Filmes> _filmes;
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
        }
    }
}