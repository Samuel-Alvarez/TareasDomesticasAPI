using NuGet.Packaging.Signing;
using System.ComponentModel.DataAnnotations;

namespace AplicacionDistribuidaAPI.Models
{
    public class Tareas
    {
        [Key]
        public int TareaId { get; set; }
        public int EmpleadoId { get; set; }
        public string? Descripcion { get; set; }
        public string? Fecha { get; set; }
        public string? Nombre { get; set; }
        public string? Estado { get; set; }
        public string? CodigoAcceso { get; set; }

    }
        
}
