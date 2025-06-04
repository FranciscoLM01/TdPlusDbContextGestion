
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

public partial class SeccionDatoEstado : BaseEntity
{
    public int nIdSeccionDatoEstado { get; set; }

    public string sNombre { get; set; }

    public string sDescripcion { get; set; }

}