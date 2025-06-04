
using System.ComponentModel.DataAnnotations;
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

public partial class Usuario : BaseEntity
{
    [Required]
    public int nIdUsuario { get; set; }

    [Required]
    [StringLength(128)]
    public string sExternalId { get; set; } = string.Empty;

    [Required]
    [StringLength(128)]
    public string sCorreoElectronico { get; set; } = string.Empty;

    [Required]
    public int nIdParticipante { get; set; }

    public int nIdPerfil { get; set; }

    [Required]
    [StringLength(128)]
    public string sNombre { get; set; }

    [Required]
    [StringLength(128)]
    public string sApellidoPaterno { get; set; }

    [Required]
    [StringLength(128)]
    public string sApellidoMaterno { get; set; }

    [Required]
    [StringLength(32)]
    public string sTelefono { get; set; }

    public int nIdTipoUsuario { get; set; }

    public virtual Perfil nIdPerfilNavigation { get; set; }
}
