
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

/// <summary>
/// Esta tabla almacenará el catalogos de los participantes o instituciones que están registrados en Banxico.
/// </summary>
public partial class Institucion : BaseEntity
{
    public int nClaveInstitucion { get; set; }

    public string sDescripcion { get; set; }

    public virtual ICollection<BeneficiarioCliente> BeneficiarioCliente { get; set; } = new List<BeneficiarioCliente>();
}