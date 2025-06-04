
namespace TdPlusDbContextGestion.Domain.Entities;

public partial class UsuarioPermisoAccion
{
    public int nIdUsuario { get; set; }

    public int nIdPerfil { get; set; }

    public int nIdOpcionMenuAccion { get; set; }

    public DateTime dFecRegistro { get; set; }

    public DateTime dFecMovimiento { get; set; }

    public virtual OpcionMenuAccion nIdOpcionMenuAccionNavigation { get; set; }

    public virtual Perfil nIdPerfilNavigation { get; set; }

    public virtual Usuario nIdUsuarioNavigation { get; set; }
}