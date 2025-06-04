
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

public partial class TipoMovimiento : BaseEntity
{
    public int nIdTipoMovimiento { get; set; }

    /// <summary>
    /// Este campo almacena el tipo de movimiento, por ejemplo, C corrresponde  a Crédito y D a Débito.
    /// </summary>
    public string sNombre { get; set; }

    public string sDescripcion { get; set; }

    public virtual ICollection<Movimiento> Movimiento { get; set; } = new List<Movimiento>();
}