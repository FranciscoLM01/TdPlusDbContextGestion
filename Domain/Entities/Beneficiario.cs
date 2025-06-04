using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

/// <summary>
/// Esta tabla tiene el propósito de almacenar la información del beneficiario del otro participante directo al que se le enviará la órden de transferencia
/// </summary>
public partial class Beneficiario : BaseEntity
{
    public int nIdBeneficiario { get; set; }

    public int nIdParticipante { get; set; }

    /// <summary>
    /// Las personas físicas se representan con un 2 y las personas morales con un 1
    /// </summary>
    public sbyte nTipoContribuyente { get; set; }

    public string sNombre { get; set; }

    /// <summary>
    /// Según el manual de integración de Banxico, a partir del 10 de abril del 2024, el RFC o CURP será obligatorio.
    /// </summary>
    public string sRFCCURP { get; set; }

    public string? sCorreo { get; set; } = null;

    public string? sTelefono { get; set; } = null;

    public int? nIdDireccion { get; set; }

    public virtual ICollection<Orden> Orden { get; set; } = new List<Orden>();

    public virtual Direccion nIdDireccionNavigation { get; set; }

    public virtual Participante nIdParticipanteNavigation { get; set; }
}
