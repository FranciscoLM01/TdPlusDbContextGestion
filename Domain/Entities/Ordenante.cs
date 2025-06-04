
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

/// <summary>
/// Esta tabla almacena los ordenantes para las ordenes.
/// </summary>
public partial class Ordenante : BaseEntity
{
    public int nIdOrdenante { get; set; }

    /// <summary>
    /// Esta columna corresponde al ID único cuando se agregue un participante directo y un participante indirecto
    /// </summary>
    public int nIdParticipante { get; set; }


    public virtual ICollection<OrdenTransferencia> OrdenTransferencia { get; set; } = new List<OrdenTransferencia>();

    public virtual Participante nIdParticipanteNavigation { get; set; }
}