using Evaluacion3AJAX.DTO;

namespace Evaluacion3AJAX.Models.DTO
{
    public class HerramientaDTO
    {
        public int Id { get; set; }

        public string Modelo { get; set; }

        public string Marca { get; set; }

        public int CantidadTotal { get; set; }

        public int Disponibles { get; set; }

        public List<UnidadHerramientaDTO> Unidades { get; set; }
    }
}
