
namespace TdPlusDbContextGestion.Domain.Entities;

public partial class ProspectoResponsableOperativo
{
    public int nIdSolicitud { get; set; }

    public string sNombre { get; set; }

    public string sApellidoPaterno { get; set; }

    public string sApellidoMaterno { get; set; }

    public string sCorreoElectronico { get; set; }

    public string sTelefono { get; set; }

    public string sExtension { get; set; }

    public DateTime dFecRegistro { get; set; }

    public DateTime dFecMovimiento { get; set; }

    public virtual Solicitud nIdSolicitudNavigation { get; set; }
}