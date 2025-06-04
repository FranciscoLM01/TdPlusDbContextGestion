
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

public partial class CuentaCliente
{
    public int nIdCliente { get; set; }

    public int nClaveTipoCuenta { get; set; }

    public bool? bActivo { get; set; }

    public string sCuenta { get; set; }

    public string sBanco { get; set; }

    public DateTime dFecRegistro { get; set; }

    public DateTime dFecMovimiento { get; set; }

    public virtual TipoCuenta nClaveTipoCuentaNavigation { get; set; }

    public virtual Cliente nIdClienteNavigation { get; set; }
}