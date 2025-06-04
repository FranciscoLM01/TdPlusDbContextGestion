
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

/// <summary>
/// Esta tabla corresponde a los posibles estatus que puede tomar una orden, por ejemplo, la orden puede estar en Cola de envío, Liquidado, Abonado, etc.
/// </summary>
public partial class OrdenEstado : BaseEntity
{
    public int nIdOrdenEstado { get; set; }

    public int nClave { get; set; }

    public string sNombre { get; set; }

    public string sDescripcion { get; set; }

}