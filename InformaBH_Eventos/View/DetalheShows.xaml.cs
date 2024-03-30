using InformaBH_Eventos.Model;

namespace InformaBH_Eventos.View;

public partial class DetalheShows : ContentPage
{
	public DetalheShows(Shows selectedItem)
	{
		InitializeComponent();

		Shows shows = selectedItem as Shows;

		TShows.Text = shows.Titulo;
		ImageDetalhes.Source = shows.Imagem;
		LblLocal.Text = shows.Local;
		Detalhes.Text = shows.Descricao;
	}
}