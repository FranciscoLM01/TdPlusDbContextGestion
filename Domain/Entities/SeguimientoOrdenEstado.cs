using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

/// <summary>
///
/// </summary>
public partial class SeguimientoOrdenEstado : BaseEntity
{

    public int nIdSeguimientoOrdenEstado { get; set; }

    /// <summary>
    /// Identificador de la orden
    /// </summary>
    public int nIdOrden { get; set; }

    /// <summary>
    /// Identificador del estado
    /// </summary>
    public int nIdOrdenEstado { get; set; }

    /// <summary>
    /// Identificador del usuario que registró el estado
    /// </summary>
    public int? nIdUsuario { get; set; }

    /// <summary>
    /// Detalle que motivó el estado
    /// </summary>
    public string sMotivo { get; set; } = string.Empty;

    /// <summary>
    /// Fecha de registro del estado
    /// </summary>
    public DateTime dFecRegistro { get; set; }

    /// <summary>
    /// Entidad de la orden
    /// </summary>
    public int nIdEntidad { get; set; }

    /// <summary>
    /// Secuencia de la orden
    /// </summary>
    public int nIdSecuencia { get; set; }

    /// <summary>
    /// Fecha de operación de la orden. Se espera el registro de una fecha 20000101, que está dentro del límite de un entero.
    /// </summary>
    public int nFechaOperacion { get; set; }

    public virtual OrdenEstado nIdOrdenEstadoNavigation { get; set; }

    public virtual Orden nIdOrdenNavigation { get; set; }

    public virtual Usuario nIdUsuarioNavigation { get; set; }
}
