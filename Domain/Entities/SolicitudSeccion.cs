
namespace TdPlusDbContextGestion.Domain.Entities;

public partial class SolicitudSeccion
{
    public int nIdSolicitud { get; set; }

    public int nIdSeccion { get; set; }

    public virtual Seccion nIdSeccionNavigation { get; set; }

    public virtual Solicitud nIdSolicitudNavigation { get; set; }
}