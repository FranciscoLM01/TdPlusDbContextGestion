using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities
{
    public partial class RecepcionPago : BaseEntity
    {
        public int nIdRecepcion { get; set; }
        public int nIdParticipante { get; set; }
        public int nIdCuentaClabe { get; set; }
        public string? sProductoAsignado { get; set; }
        public bool? bRecurrente { get; set; }// true = "recuerrente"   false= "un solo uso"
        public string? sRfcCurp { get; set; }
        public bool bRecepcionActiva { get; set; }
        public DateTime? dVigencia { get; set; }
        public DateTime? dFechaAsignacion { get; set; }
        public DateTime? dFechaLiberacion { get; set; }
        public DateTime? dFechaPago { get; set; }
        public int nIdEstatus { get; set; }
        public Decimal? nMonto { get; set; }
        public virtual Participante nIdParticipanteNavigation { get; set; }
        public virtual CuentaClabe nIdCuentaClabeNavigation { get; set; }
        public virtual ICollection<RecepcionPagoHistorico> RecepcionPagoHistorico { get; set; } = new List<RecepcionPagoHistorico>();
    }
}
