using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace Gen0623_Barcos.Modelos
{
    public class BarcosController
    {
        public class barcoJL
        {
            [Key]            
            [Required(ErrorMessage = "El Id es requerido")]
            public int Id { get; set; }
            [Required(ErrorMessage = "El Nombre es requerido")]
            public string Nombre { get; set; }
            [Required(ErrorMessage = "El tipo del barco es requerido")]
            public string Tipo { get; set; }
            public string CapacidadToneladas { get; set; }
            public Estatus Status { get; set; }
        }
    }
}
