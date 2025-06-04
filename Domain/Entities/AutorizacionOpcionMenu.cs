namespace TdPlusDbContextGestion.Domain.Entities;

public partial class AutorizacionOpcionMenu
{
    public int nIdOpcionMenu { get; set; }

    public int nIdPerfil { get; set; }

    public DateTime dFecRegistro { get; set; }

    public DateTime dFecMovimiento { get; set; }

    public virtual OpcionMenu? nIdOpcionMenuNavigation { get; set; }

    public virtual Perfil? nIdPerfilNavigation { get; set; }
}