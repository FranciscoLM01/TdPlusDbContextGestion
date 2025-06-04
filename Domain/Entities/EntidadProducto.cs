using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities
{
    public partial class EntidadProducto : BaseEntity
    {
        public int nIdEntidadProducto { get; set; }
        public int nIdEntidad { get; set; }
        public int nIdProductoFinanciero { get; set; }
        public int? nUltimoCentro { get; set; }
        public int nLimiteCentroCosto { get; set; }
        public string sCadenaBaseEntidad { get; set; }

        public virtual ICollection<CentroCosto> CentroCosto { get; set; } = new List<CentroCosto>();
        public virtual Entidad nIdEntidadNavigation { get; set; }
    }
}
