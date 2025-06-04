using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TdPlusDbContextGestion.Domain.Entities
{
    /// <summary>
    /// Representa los permisos requeridos por las opciones del menú.
    /// </summary>
    public class OpcionMenuUsuarioPermisos
    {
        [Key, ForeignKey("OpcionMenu")]
        public int nIdMenuOpcion { get; set; }  // FK

        [Key, ForeignKey("UsuarioPermisos")]
        public int nIdUsuarioPermisos { get; set; }  // FK

        public virtual OpcionMenu OpcionMenu { get; set; }
        public virtual UsuarioPermisos UsuarioPermisos { get; set; }
    }
}
