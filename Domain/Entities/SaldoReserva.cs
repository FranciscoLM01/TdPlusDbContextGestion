
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

public partial class SaldoReserva : BaseEntity
{
    public int nIdSaldoReserva { get; set; }

    public int? nIdParticipante { get; set; }

    public decimal nSaldoActual { get; set; }

    /// <summary>
    /// Esta columna corresponde a la suma de los montos de las ordenes
    /// </summary>
    public decimal nSaldoReservado { get; set; }

    /// <summary>
    /// Esta columna corresponde al monto total de las ordenes que ya se han liquidado
    /// </summary>
    public decimal nTotalTransferido { get; set; }

    /// <summary>
    /// Esta columna es calculada haciendo una resta o diferencia con la colummna nSaldoReservado y nTotalTransferido (nSaldoReservado - nTotalTransferido)
    /// </summary>
    public decimal nSaldoReservadoDevolver { get; set; }

    public virtual Participante nIdParticipanteNavigation { get; set; }
}