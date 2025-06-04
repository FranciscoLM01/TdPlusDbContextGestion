using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities
{
    public class Devolucion : BaseEntity
    {
        public int nIdDevolucion { get; set; }
        public int nIdParticipante { get; set; }
        public int nIdTipoOperacion { get; set; }
        public int nIdTipoMovimiento { get; set; }
        public decimal nMonto { get; set; }
        public string sConcepto { get; set; }
        public int nIdCausaDevolucion { get; set; } // FK
        public string sClaveRastreo { get; set; }
        public string sEstatus { get; set; }
        public DateTime dFechaAplicacion { get; set; }
        public TimeSpan dTiempoDeRespuesta { get; set; }
        public string SestadoPeticionOrdenDescripcion { get; set; } = string.Empty!;
        public string urlCEP { get; set; } = string.Empty!;
        public string sCuentaClabe { get; set; } = string.Empty!;


        public CausaDevolucion CausaDevolucion { get; set; }
    }
}
