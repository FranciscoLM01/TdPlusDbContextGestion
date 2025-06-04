
namespace TdPlusDbContextGestion.Domain.Entities;

public partial class ParticipanteCuentaConcentradora
{
    public int nIdParticipante { get; set; }

    public int nIdCuentaConcentradora { get; set; }

    public bool? bActivo { get; set; }

    public DateTime dFecRegistro { get; set; }

    public DateTime dFecMovimiento { get; set; }

    public virtual CuentaConcentradora nIdCuentaConcentradoraNavigation { get; set; }

    public virtual Participante nIdParticipanteNavigation { get; set; }
}