using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformaBH_Eventos.Model
{
    public class Filmes
    {
        public String? ID { get; set; }
        public String? Titulo { get; set; }
        public String? Genero { get; set; }
        public String? FaixaEtaria { get; set; }
        public String? Sinopse { get; set; }
        public string? TrailerUri { get; set; }
        public ImageSource? ImageFilme { get; set; }

    }
}
