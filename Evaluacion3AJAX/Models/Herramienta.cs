using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Evaluacion3AJAX.Models
{
    public class Herramienta
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Modelo { get; set; }

        [Required]
        [StringLength(50)]
        public string Marca { get; set; }

        [Required]
        public int CantidadTotal { get; set; }

        public int Disponibles { get; set; }

        public ICollection<UnidadHerramienta> Unidades { get; set; }
    }
}
