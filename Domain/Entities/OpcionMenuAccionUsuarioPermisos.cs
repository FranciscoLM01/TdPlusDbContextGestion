using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TdPlusDbContextGestion.Domain.Entities
{
    public class OpcionMenuAccionUsuarioPermisos
    {
        [Key]
        public int nIdOpcionMenuAccion { get; set; }  // Llave foránea

        [ForeignKey("UsuarioPermisos")]
        public int nIdUsuarioPermisos { get; set; }  // Llave foránea

        public virtual OpcionMenuAccion? OpcionMenuAccion { get; set; }
        public virtual UsuarioPermisos? UsuarioPermisos { get; set; }
    }
}
