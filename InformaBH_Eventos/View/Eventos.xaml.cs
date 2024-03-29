using InformaBH_Eventos.Model;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Reflection;

namespace InformaBH_Eventos.View;

public partial class Eventos : ContentPage
{
    private ObservableCollection<Shows> _shows;

    public Eventos()
	{
		InitializeComponent();

        BindingContext = this;

        var assembly = typeof(Eventos).GetTypeInfo().Assembly;
        Stream stream = assembly.GetManifestResourceStream("InformaBH_Eventos.allShow.json");

        using (var reader = new System.IO.StreamReader(stream))
        {
            var json = reader.ReadToEnd();

            List<Shows> allshow = JsonConvert.DeserializeObject<List<Shows>>(json);
            _shows = new ObservableCollection<Shows>(allshow);
            LtvShow.ItemsSource = _shows;
        }
    }
}