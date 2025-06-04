
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

public partial class BeneficiarioCuenta
{
    public int nIdBeneficiario { get; set; }

    public int nClaveTipoCuenta { get; set; }

    public int nClaveInstitucion { get; set; }

    public bool? bActivo { get; set; }

    /// <summary>
    /// Corresponde al número de cuenta (CLABE)
    /// </summary>
    public string sCuenta { get; set; }

    /// <summary>
    /// Nombre del banco
    /// </summary>
    public string sBanco { get; set; }

    public DateTime dFecRegistro { get; set; }

    public DateTime dFecMovimiento { get; set; }

    public virtual Institucion nClaveInstitucionNavigation { get; set; }

    public virtual TipoCuenta nClaveTipoCuentaNavigation { get; set; }

    public virtual Beneficiario nIdBeneficiarioNavigation { get; set; }
}