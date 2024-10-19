namespace Evaluacion3AJAX.DTO
{
    public class AsignacionHerramientaDTO
    {
        public int Id { get; set; }

        public int UnidadHerramientaId { get; set; }

        public int UsuarioId { get; set; }

        public DateTime FechaAsignacion { get; set; }

        public DateTime? FechaDevolucion { get; set; }
    }

}
