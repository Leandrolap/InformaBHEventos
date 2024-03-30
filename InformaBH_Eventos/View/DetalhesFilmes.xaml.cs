using InformaBH_Eventos.Model;

namespace InformaBH_Eventos.View;

public partial class DetalhesFilmes : ContentPage
{

    public DetalhesFilmes(Filmes selectedItem)
	{
		InitializeComponent();

        Filmes filmes = selectedItem as Filmes;

        TFilme.Text = filmes.Titulo;
        LblElenco.Text = filmes.Elenco;
        WebVideo.Source = filmes.TrailerUri;
        DSinopse.Text = filmes.Sinopse;
        LblDirecao.Text = filmes.Direcao;
        LblDuracao.Text = filmes.Duracao;
	}
}