
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

public partial class BeneficiarioCliente : BaseEntity
{
    public int nIdBeneficiarioCliente { get; set; }

    public int nIdCliente { get; set; }

    public int nTipoCuenta { get; set; }

    public int nClaveInstitucion { get; set; }

    public string sNombre { get; set; }

    public string sCuenta { get; set; }


    public virtual Institucion? nClaveInstitucionNavigation { get; set; }

    public virtual Cliente? nIdClienteNavigation { get; set; }
}