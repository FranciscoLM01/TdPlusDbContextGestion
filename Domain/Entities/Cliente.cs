
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

public partial class Cliente : BaseEntity
{
    public int nIdCliente { get; set; }

    public int nIdParticipante { get; set; }

    public int nIdCuentaConcentradora { get; set; }

    /// <summary>
    /// Esta columna corresponde al identificador único del centro de costos o cliente indirecto
    /// </summary>
    public int nClaveCuenta { get; set; }

    public string sNombre { get; set; }

    public virtual ICollection<BeneficiarioCliente> BeneficiarioCliente { get; set; } = new List<BeneficiarioCliente>();

    public virtual Participante nIdParticipanteNavigation { get; set; }
}