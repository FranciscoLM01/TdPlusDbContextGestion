
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

/// <summary>
/// Esta corresponde al tipo de participante, por ejemplo, directo o indirecto
/// </summary>
public partial class TipoParticipacion : BaseEntity
{
    public int nIdTipoParticipante { get; set; }

    public int nIdentificador { get; set; }

    public string sFormato { get; set; }

    /// <summary>
    /// Esta columna se refiere al nombre del tipo de participante: directo o indirecto
    /// </summary>
    public string sNombre { get; set; }

    public virtual ICollection<ProductoFinanciero> ProductosFinancieros { get; set; } = new List<ProductoFinanciero>();

    public virtual ICollection<ControlParticipante> ControlParticipante { get; set; } = new List<ControlParticipante>();

    public virtual ICollection<Participante> Participante { get; set; } = new List<Participante>();
}