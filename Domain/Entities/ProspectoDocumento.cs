
namespace TdPlusDbContextGestion.Domain.Entities;

public partial class ProspectoDocumento
{
    public int nIdSolicitud { get; set; }

    public int nIdSeccionDato { get; set; }

    public int nIdSeccionDatoEstado { get; set; }

    /// <summary>
    /// Esta columna corresponde al valor o data del documento
    /// </summary>
    public string sDato { get; set; }

    public string sKey { get; set; }

    public string Path { get; set; }

    public DateTime dFecRegistro { get; set; }

    public DateTime dFecMovimiento { get; set; }

    public virtual SeccionDatoEstado nIdSeccionDatoEstadoNavigation { get; set; }

    public virtual SeccionDato nIdSeccionDatoNavigation { get; set; }

    public virtual Solicitud nIdSolicitudNavigation { get; set; }
}