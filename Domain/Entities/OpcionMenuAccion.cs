
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

public partial class OpcionMenuAccion : BaseEntity
{
    public int nIdOpcionMenuAccion { get; set; }

    public int nIdOpcionMenu { get; set; }

    public int nIdAccion { get; set; }

    public string sNombre { get; set; }

    public string sDescripcion { get; set; }

    public virtual OpcionMenu nIdOpcionMenuNavigation { get; set; }
}