
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

public partial class Colonia : BaseEntity
{
    public int nIdColonia { get; set; }

    public int nIdMunicipio { get; set; }

    public string sNombre { get; set; }

    public string sNombreEstado { get; set; }

    public string sNombreMunicipio { get; set; }

    public string sTipoAsentamiento { get; set; }

    public string sTipoZona { get; set; }

    public int nCodigoPostal { get; set; }

    public virtual ICollection<Direccion> Direccion { get; set; } = new List<Direccion>();

    public virtual Municipio nIdMunicipioNavigation { get; set; }
}