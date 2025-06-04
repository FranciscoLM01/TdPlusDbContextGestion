
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

public partial class GiroNegocio : BaseEntity
{
    public int nIdGiroNegocio { get; set; }

    public string sDescripcion { get; set; }

}