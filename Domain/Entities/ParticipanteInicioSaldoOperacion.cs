
namespace TdPlusDbContextGestion.Domain.Entities;

/// <summary>
/// Esta es la tabla que almacena el saldo del participante en función del cambio de la fecha de operación del SPEI
/// </summary>
public partial class ParticipanteInicioSaldoOperacion
{
    public int nIdParticipante { get; set; }

    /// <summary>
    /// Esta columna hace referencia al saldo inicial del participante conforme cambia la fecha de operación
    /// </summary>
    public decimal nSaldoInicio { get; set; }

    public DateTime dFechaOperacion { get; set; }

    public DateTime dFecRegistro { get; set; }

    public virtual Participante nIdParticipanteNavigation { get; set; }
}