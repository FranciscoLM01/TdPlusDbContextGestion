
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

public partial class ClienteCuentaConcentradora
{
    public int nIdCliente { get; set; }

    public int nIdCuentaConcentradora { get; set; }

    public bool? bActivo { get; set; }

    public DateTime dFecRegistro { get; set; }

    public DateTime dFecMovimiento { get; set; }

    public virtual Cliente nIdClienteNavigation { get; set; }

    public virtual CuentaConcentradora nIdCuentaConcentradoraNavigation { get; set; }
}