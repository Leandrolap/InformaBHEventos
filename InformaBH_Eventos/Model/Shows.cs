using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformaBH_Eventos.Model
{
    public class Shows
    {
        public string? ID { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public string? DataShow { get; set; }
        public string? Local { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public ImageSource? Imagem { get; set; }

       
    }
}
