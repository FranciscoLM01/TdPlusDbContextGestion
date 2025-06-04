using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities
{
    public partial class CentroCosto : BaseEntity
    {
        public int nIdCentroCosto { get; set; }
        public int nIdEntidadProducto { get; set; }
        public int nIdTipoCentroCosto { get; set; }
        public string Alias { get; set; }
        public int? nCentro { get; set; }
        public string sCentro { get; set; }
        public int ? nUltimoIdentificadorCta { get; set; }
        public int nLimiteIdentificadorCta { get; set; }
        public string sCadenaBaseCentro { get; set; }
        public bool bPrincipal { get; set; }
        public int? nIdCuentaConcentradora { get; set; }


        public virtual ICollection<CuentaClabe> CuentaClabe { get; set; } = new List<CuentaClabe>();
        public virtual EntidadProducto nIdEntidadProductoNavigation { get; set; }

        public virtual TipoCentroCosto TipoCentroCosto { get; set; }
        public virtual CuentaConcentradora CuentaConcentradora { get; set; }

    }
}
