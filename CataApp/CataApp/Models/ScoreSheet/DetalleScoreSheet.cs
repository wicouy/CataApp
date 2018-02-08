using System;
using System.Collections.Generic;
using System.Text;

namespace CataApp.Models.Cata
{
    class DetalleScoreSheet
    {
        public int Id { get; set; }
        public int IdScoreSheet { get; set; }
        public int IdDefecto { get; set; }
        public string Aroma { get; set; }
        public string Apariencia { get; set; }
        public string Flavor { get; set; }
        public string SensacionBoca { get; set; }
        public string ImpresionGeneral { get; set; }

        public int PuntajeAroma { get; set; }
        public int PuntajeApariencia { get; set; }
        public int PuntajeFlavor { get; set; }
        public int PuntajeSensacionBoca { get; set; }
        public int PuntajeImpresionGeneral { get; set; }

        public int IdExactitud { get; set; }
        public int IdMerido { get; set; }
        public int IdIntangibles { get; set; }
    }
}
