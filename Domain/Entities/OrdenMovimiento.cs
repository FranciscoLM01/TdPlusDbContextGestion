
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

/// <summary>
/// Esta tabla tiene el propósito de almacenar las órdenes y los movimientos correspondientes y saber las afectaciones que van realizando en el saldo del participante
/// </summary>
public partial class OrdenMovimiento : BaseEntity
{

    public int nIdOrdenMovimiento {  get; set; }

    public int nIdOrden { get; set; }

    public int nIdMovimiento { get; set; }

    public DateTime dFecRegistro { get; set; }

    public DateTime dFecMovimiento { get; set; }

    public virtual Movimiento nIdMovimientoNavigation { get; set; }

    public virtual Orden nIdOrdenNavigation { get; set; }
}