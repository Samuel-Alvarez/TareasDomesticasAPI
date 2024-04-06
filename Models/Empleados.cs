using System.ComponentModel.DataAnnotations;

namespace AplicacionDistribuidaAPI.Models
{
    public class Empleados
    {
        [Key]
        public int EmpleadoId { get; set; }
        public string? Nombre { get; set; }
        public string? Email { get; set; }
        public string? Clave { get; set; }
    }
}
