
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

public partial class Movimiento : BaseEntity
{
    public int nIdMovimiento { get; set; }

    public int nIdParticipante { get; set; }

    public int nIdTipoOperacion { get; set; }

    public int nIdTipoMovimiento { get; set; }

    /// <summary>
    /// Esta columna corresponde al saldo antes de aplicar el movimiento
    /// </summary>
    public decimal nSaldoInicial { get; set; }

    public decimal nMonto { get; set; }

    /// <summary>
    /// Esta columna corresponde al saldo que queda disponible tomando en cuenta el último saldo disponible menos la diferencia del monto (en este caso, ya sea, un cargo o un abono).
    /// </summary>
    public decimal nSaldoFinal { get; set; }

    public string sConcepto { get; set; }

    public virtual Participante nIdParticipanteNavigation { get; set; }

    public virtual TipoMovimiento nIdTipoMovimientoNavigation { get; set; }

    public virtual TipoOperacion nIdTipoOperacionNavigation { get; set; }
}