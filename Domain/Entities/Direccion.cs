
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

public partial class Direccion : BaseEntity
{
    public int nIdDireccion { get; set; }

    public int nIdEstado { get; set; }

    public int nIdMunicipio { get; set; }

    public int nIdColonia { get; set; }

    public string sCalle { get; set; }

    public string sNumeroExterior { get; set; }

    public string sNumeroInterior { get; set; }

    public int nCodigoPostal { get; set; }

    public virtual ICollection<Beneficiario> Beneficiario { get; set; } = new List<Beneficiario>();

    public virtual Colonia nIdColoniaNavigation { get; set; }

    public virtual Estado nIdEstadoNavigation { get; set; }

    public virtual Municipio nIdMunicipioNavigation { get; set; }
}