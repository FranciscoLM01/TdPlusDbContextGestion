using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

public class UsuarioWebhook : BaseEntity
{
    [Key]
    public long nIdUsuarioWebhook { get; set; }

    [Required]
    public string Url { get; set; } = null!;

    [Required]
    public string Auth { get; set; } = null!;

    [Required]
    public int nIdParticipante { get; set; }

    [Required]
    public int nIdCreadoPor { get; set; }

    public int? nIdCentroCostos { get; set; } = null;

    public int? nIdActualizadoPor { get; set; } = null;

    [ForeignKey("nIdParticipante")]
    [DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual Participante nIdParticipanteNavigation { get; set; }

    [ForeignKey("nIdCentroCostos")]
    [DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual CentroCosto nIdCentroCostosNavigation { get; set; }
}
