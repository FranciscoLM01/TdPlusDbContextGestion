using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities
{
    public partial class ControlParticipante : BaseEntity
    {
        public int nIdControlParticipante { get; set; }
        public int nIdTipoParticipante { get; set; }
        public int nClaveSpei { get; set; }
        public int? nConstante { get; set; }
        public int? nLimiteConstante { get; set; }
        public int? nUltimaEntidad { get; set; }
        public string? sUltimaEntidad { get; set; }
        public int nLongitudEntidad { get; set; }
        public int nLimiteEntidad { get; set; }
        public int nLongitudCentro { get; set; }
        public int nLongitudIdentificadorCuenta { get; set; }
        public int nLongitudVerificador { get; set; }
        public bool bAgotado { get; set; }

        public virtual ICollection<Entidad> Entidad { get; set; } = new List<Entidad>();
        public virtual TipoParticipacion nIdTipoParticipanteNavigation { get; set; }
    }
}
