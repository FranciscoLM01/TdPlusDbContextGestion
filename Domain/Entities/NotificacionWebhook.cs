
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

public partial class NotificacionWebhook : BaseEntity
{
    public int nIdNotificacion { get; set; }

    public int? nIdParticipante { get; set; }

    public string nDescripcion { get; set; }

    public virtual Participante nIdParticipanteNavigation { get; set; }
}