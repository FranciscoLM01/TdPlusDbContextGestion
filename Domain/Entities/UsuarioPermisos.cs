using System.ComponentModel.DataAnnotations;
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities
{
    /// <summary>
    /// Representa los permisos otorgados por el usuario al sistema.
    /// </summary>
    public class UsuarioPermisos : BaseEntity
    {
        public int nIdUsuarioPermisos { get; set; }

        public string? sNombre { get; set; }

        public string? sDetalle { get; set; }
    }
}
