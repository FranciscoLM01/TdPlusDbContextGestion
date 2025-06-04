
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

/// <summary>
/// Esta tabla tiene el propósito de almacenar las cuentas de los participantes indirectos y las cuentas de los clientes de los participantes indirectos.
/// </summary>
public partial class CuentaConcentradora : BaseEntity
{
    public int nIdCuentaConcentradora { get; set; }

    public int nClaveTipoCuenta { get; set; }

    public decimal nSaldo { get; set; }

    /// <summary>
    /// Esta columna corresponde al identificador (alias) de una cuenta concentradora. Por ejemplo: cuantacontradoraclienteindirecto1 Producto
    /// </summary>
    public string sAlias { get; set; }

    public virtual TipoCuenta nClaveTipoCuentaNavigation { get; set; }
    public virtual CentroCosto CentroCosto { get; set; }
    public virtual ICollection<CuentaClabeEntidad> CuentasClabeEntidad { get; set; }

}