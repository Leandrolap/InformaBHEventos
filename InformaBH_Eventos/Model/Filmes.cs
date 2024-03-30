using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformaBH_Eventos.Model
{
    public class Filmes
    {
        public string? ID { get; set; }
        public string? Titulo { get; set; }
        public string? Genero { get; set; }
        public string? FaixaEtaria { get; set; }
        public string? Sinopse { get; set; }
        public string? TrailerUri { get; set; }
        public string? Elenco { get; set; }
        public string? Direcao { get; set; }
        public string? CorEtaria { get; set; }
        public string? Duracao {  get; set; }
        public ImageSource? ImageFilme { get; set; }

    }
}
