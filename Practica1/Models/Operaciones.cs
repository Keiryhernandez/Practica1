using System.ComponentModel.DataAnnotations;

namespace Practica1.Models
{
    public class Operaciones
    {
        [Required]
        [Display(Name = "Primer Dato")]
        public double PrimerDato { get; set; } = 0;


        public double Resultado { get; set; }
        public int TipoOperacionId { get; set; } = 0;
        public List<TiposOperacion> ListaOperaciones { get; set; }
        public Operaciones()
        {
            ListaOperaciones = new List<TiposOperacion>
            {
                new TiposOperacion{Id= 1, Nombre= "Kilometro a Millas "},
                new TiposOperacion{Id= 2, Nombre= "Millas a Kilometros"},
                new TiposOperacion{Id= 3, Nombre= "Metros a Pies"},
                new TiposOperacion{Id= 4, Nombre= "Pies a metros"},
            };
        }

    }
}
