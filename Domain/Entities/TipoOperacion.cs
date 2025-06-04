
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

public partial class TipoOperacion : BaseEntity
{
    public int nIdTipoOperacion { get; set; }

    /// <summary>
    /// Esta columna corresponde al tipo de operación, por ejemplo, si el tipo de operación es de tipo C (Crédito) corresponde  a un cargo y si es D (Débito) corresponde a un abono.
    /// </summary>
    public string sNombre { get; set; }

    public string sDescripcion { get; set; }

    public virtual ICollection<Movimiento> Movimiento { get; set; } = new List<Movimiento>();
}