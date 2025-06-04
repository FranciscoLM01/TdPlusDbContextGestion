
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

/// <summary>
/// Esta tabla corresponde a los números de plaza dónde se está aperturando una cuenta de un participante directo.
/// </summary>
public partial class Plaza : BaseEntity
{
    public int nIdPlaza { get; set; }

    public int nClave { get; set; }

    public string sDescripcion { get; set; }

}