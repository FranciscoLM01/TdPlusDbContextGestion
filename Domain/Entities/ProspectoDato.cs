
namespace TdPlusDbContextGestion.Domain.Entities;

public partial class ProspectoDato
{
    public int nIdSolicitud { get; set; }

    public int nIdSeccionDato { get; set; }

    public int nIdSeccionDatoEstado { get; set; }

    public string sDato { get; set; }

    public DateTime dFecRegistro { get; set; }

    public DateTime dFecMovimiento { get; set; }

    public virtual SeccionDatoEstado nIdSeccionDatoEstadoNavigation { get; set; }

    public virtual SeccionDato nIdSeccionDatoNavigation { get; set; }

    public virtual Solicitud nIdSolicitudNavigation { get; set; }
}