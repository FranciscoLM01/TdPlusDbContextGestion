
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

public partial class Prospecto : BaseEntity
{
    public int nIdProspecto { get; set; }

    public string sNombre { get; set; }

    public string sApellidoPaterno { get; set; }

    public string sApellidoMaterno { get; set; }

    public string sTelefono { get; set; }

    public string sCorreoElectronico { get; set; }

    public string sObservaciones { get; set; }

    public virtual ICollection<Solicitud> Solicitud { get; set; } = new List<Solicitud>();
}