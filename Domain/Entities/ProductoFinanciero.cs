
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

/// <summary>
/// Esta tabla corresponde al catalogo de productos financieros aplicables a los servicios de participación indirecta
/// </summary>
public partial class ProductoFinanciero : BaseEntity
{
    public int nIdProductoFinanciero { get; set; }

    /// <summary>
    /// Esta columna corresponde al identificador único del producto financiero
    /// </summary>
    public int nClave { get; set; }

    /// <summary>
    /// Esta columna corresponde a la descripción del producto financiero
    /// </summary>
    public string sDescripción { get; set; }

    public int nIdTipoParticipante { get; set; }
    public virtual TipoParticipacion TipoParticipante { get; set; }

}