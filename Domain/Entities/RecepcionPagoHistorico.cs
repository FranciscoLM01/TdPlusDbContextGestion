using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities
{
    public class RecepcionPagoHistorico : BaseEntity
    {
        public int nIdRecepcionPagoHistorico { get; set; }
        public int? nIdRecepcionPago { get; set; }
        public int nIdParticipante { get; set; }
        public int nIdCuentaClabe { get; set; }
        public string sCuentaClabe { get; set; }
        public string sProductoAsignado { get; set; }
        public string sRfcCurp { get; set; }
        public decimal nMonto { get; set; }
        public string sFechaOperacion { get; set; } = string.Empty;
        public string sClaveRastreo { get; set; } = string.Empty;
        public string urlCEP { get; set; } = string.Empty;
        public virtual RecepcionPago recepcionPagoNavigation { get; set; }

    }
}