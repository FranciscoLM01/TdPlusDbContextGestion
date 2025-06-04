
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

public partial class Municipio : BaseEntity
{
    public int nIdMunicipio { get; set; }

    public int nIdEstado { get; set; }

    public string sNombre { get; set; }

    public int? nCodigoCiudad { get; set; }

    public virtual ICollection<Colonia> Colonia { get; set; } = new List<Colonia>();

    public virtual ICollection<Direccion> Direccion { get; set; } = new List<Direccion>();

    public virtual Estado nIdEstadoNavigation { get; set; }
}