using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

public partial class Participante : BaseEntity
{
    public int nIdParticipante { get; set; }

    public int nIdCuentaConcentradora { get; set; }

    /// <summary>
    /// Esta columna corresponde al tipo de participante, ya sea directo o indirecto
    /// </summary>
    public int nIdTipoParticipante { get; set; }

    public string sRFC { get; set; }

    public string sRazonSocial { get; set; }

    
    public string sNombre {  get; set; }
    
    public string sTelefono {  get; set; }
    
    public string sContacto {  get; set; }
    
    public string sCorreo {  get; set; }
    
    public DateTime dFechaIngreso {  get; set; }
    
    public int nNumeroEntidad {  get; set; }
    
    public virtual ICollection<Entidad> Entidad { get; set; } = new List<Entidad>();

    public virtual ICollection<Beneficiario> Beneficiario { get; set; } = new List<Beneficiario>();

    public virtual ICollection<Cliente> Cliente { get; set; } = new List<Cliente>();

    public virtual ICollection<Movimiento> Movimiento { get; set; } = new List<Movimiento>();

    public virtual ICollection<NotificacionWebhook> NotificacionWebhook { get; set; } = new List<NotificacionWebhook>();

    public virtual ICollection<Ordenante> Ordenante { get; set; } = new List<Ordenante>();

    public virtual ICollection<SaldoReserva> SaldoReserva { get; set; } = new List<SaldoReserva>();
    public virtual ICollection<RecepcionPago> RecepcionPago { get; set; } = new List<RecepcionPago>();

    public virtual TipoParticipacion nIdTipoParticipanteNavigation { get; set; }
}