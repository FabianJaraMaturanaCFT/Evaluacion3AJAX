using System.ComponentModel.DataAnnotations.Schema;
namespace Evaluacion3AJAX.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // Relación uno a muchos entre Usuario y Rol, o sea, un usuario puede tener un rol

        [ForeignKey("Rol")]
        public int RolId { get; set; }
    }
}