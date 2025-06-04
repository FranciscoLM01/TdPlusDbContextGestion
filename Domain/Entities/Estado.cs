
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

public partial class Estado : BaseEntity
{
    public int nIdEstado { get; set; }

    public string sNombre { get; set; }

    public string sClave { get; set; }

    public string sCodigoEstado { get; set; }

    public long nIdCatPais { get; set; }

    public virtual ICollection<Direccion> Direccion { get; set; } = new List<Direccion>();

    public virtual ICollection<Municipio> Municipio { get; set; } = new List<Municipio>();
}