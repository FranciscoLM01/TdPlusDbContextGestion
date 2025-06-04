using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

/// <summary>
/// Esta tabla corresponde a las posibles causas de devolución cuando se hace un proceso de devolución de una orden
/// </summary>
public partial class CausaDevolucion : BaseEntity
{
    /// <summary>
    /// Esta columna corresponde al valor del campo clave del catalogo de Causa devolución de Banxico. Por ejemplo: si la clave es 1, corresponde a Cuenta inexistente.
    /// </summary>
    public int nClaveCausaDevolucion { get; set; }
    public string sDescripcion { get; set; }

}