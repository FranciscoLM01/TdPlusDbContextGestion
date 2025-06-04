
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

public partial class Solicitud : BaseEntity
{
    public int nIdSolicitud { get; set; }

    public int nIdProspecto { get; set; }

    public int nIdSolicitudEstado { get; set; }

    public bool bValidacionComercialCumplimiento { get; set; }

    public string sObservaciones { get; set; }

    public DateTime? dFechaAprobacion { get; set; }

    public virtual ICollection<SolicitudConfidencialidad> SolicitudConfidencialidad { get; set; } = new List<SolicitudConfidencialidad>();

    public virtual Prospecto nIdProspectoNavigation { get; set; }

    public virtual SolicitudEstado nIdSolicitudEstadoNavigation { get; set; }
}