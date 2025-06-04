using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

/// <summary>
/// Los posibles estados de una orden de transferencia
/// </summary>
public partial class OrdenTransferenciaEstado : BaseEntity
{
    /// <summary>
    /// Identificador del estado de la orden de transferencia
    /// </summary>
    public int nIdOrdenTransferenciaEstado { get; set; }

    /// <summary>
    /// Nombre del estado
    /// </summary>
    public string sNombre { get; set; } = string.Empty;

    /// <summary>
    /// Descripción del estado
    /// </summary>
    public string sDescripcion { get; set; } = string.Empty;
}
