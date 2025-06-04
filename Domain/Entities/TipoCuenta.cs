
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

/// <summary>
/// Esta tabla almacenará el catalógo de tipos de cuenta, por ejemplo, si el tipo de cuenta es una CLABE, tarjeta de débito o un teléfono celular.
/// </summary>
public partial class TipoCuenta : BaseEntity
{
    /// <summary>
    /// Esta columna corresponde a la clave que se le asigna a un item del catalogo de Tipos de cuenta
    /// </summary>
    public int nClaveTipoCuenta { get; set; }

    /// <summary>
    /// Esta columna corresponde al nombre del tipo de cuenta, por ejemplo, si el tipo de cuenta es CLABE, Número celular, entro otros.
    /// </summary>
    public string sDescripcion { get; set; }

    public virtual ICollection<CuentaConcentradora> CuentaConcentradora { get; set; } = new List<CuentaConcentradora>();
}