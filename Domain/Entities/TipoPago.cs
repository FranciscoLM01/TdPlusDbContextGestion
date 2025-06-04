
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

/// <summary>
/// Esta tabla almacenará los tipos de pago de Banxico, por ejemplo, Tercero a tercero, Devolución, Retorno, entre otros.
/// </summary>
public partial class TipoPago : BaseEntity
{
    /// <summary>
    /// Esta columna corresponde al valor del campo clave del catalogo de Tipo de Pagos de Banxico. Por ejemplo: si la clave es 1, corresponde al pago Tercero a tercero.
    /// </summary>
    public int nClaveTipoPago { get; set; }

    public string sDescripcion { get; set; }

    public virtual ICollection<OrdenTransferencia> OrdenTransferencia { get; set; } = new List<OrdenTransferencia>();
}