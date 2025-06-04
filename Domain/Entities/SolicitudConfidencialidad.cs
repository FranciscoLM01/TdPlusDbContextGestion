
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

public partial class SolicitudConfidencialidad : BaseEntity
{
    public int nIdSeccion { get; set; }

    public int nIdSolicitud { get; set; }

    public string sNombre { get; set; }

    public string sDescripcion { get; set; }

    public virtual Solicitud nIdSolicitudNavigation { get; set; }
}