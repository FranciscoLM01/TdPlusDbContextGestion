
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

public partial class TipoSociedad : BaseEntity
{
    public int nIdTipoSociedad { get; set; }

    public string sDescripcion { get; set; }
}