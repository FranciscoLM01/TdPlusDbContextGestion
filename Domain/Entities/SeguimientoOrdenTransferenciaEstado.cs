using System.ComponentModel.DataAnnotations.Schema;
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

public partial class SeguimientoOrdenTransferenciaEstado : BaseEntity
{

    public int nIdSeguimientoOrdenTransferenciaEstado { get; set; }

    /// <summary>
    /// Identificador de la transferencia
    /// </summary>
    public int nIdOrdenTransferencia { get; set; }

    /// <summary>
    /// Identificador del estado
    /// </summary>
    public int nIdOrdenTransferenciaEstado { get; set; }

    /// <summary>
    /// El identificar único del usuario actual que afectaría el nuevo estado o status de la orden de transferencia
    /// </summary>
    public int? nIdUsuario { get; set; }

    /// <summary>
    /// Motivo de este estado
    /// </summary>
    public string sMotivo { get; set; } = string.Empty;

    /// <summary>
    /// Fecha en el que se crea este registro
    /// </summary>
    public DateTime dFecRegistro { get; set; }

    public virtual OrdenTransferenciaEstado nIdOrdenTransferenciaEstadoNavigation { get; set; } =
        null!;

    public virtual OrdenTransferencia nIdOrdenTransferenciaNavigation { get; set; } = null!;

    public virtual Usuario nIdUsuarioNavigation { get; set; } = null!;
}
