
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

public partial class Seccion : BaseEntity
{
    public int nIdSeccion { get; set; }

    public string sNombre { get; set; }

    public string sDescripcion { get; set; }

    public virtual ICollection<SeccionDato> SeccionDato { get; set; } = new List<SeccionDato>();
}