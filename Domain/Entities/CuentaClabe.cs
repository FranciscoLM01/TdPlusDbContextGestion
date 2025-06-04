using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities
{
    public partial class CuentaClabe : BaseEntity
    {
        public int nIdCuentaClabe { get; set; }
        public int nIdCentroCosto { get; set; }
        public int nIdentificadorCta { get; set; }
        public string sIdentificadorCta { get; set; }
        public string sCadenaBaseCta { get; set; }
        public int nDigitoVerificador { get; set; }
        public string sCuentaClabe { get; set; }
        public bool bReutilizar { get; set; }
        public int nIdStatus { get; set; }

        public virtual CentroCosto nIdCentroCostoNavigation { get; set; }
        public virtual ICollection<RecepcionPago> RecepcionPago { get; set; } = new List<RecepcionPago>();
        public virtual ICollection<CuentaClabeEntidad> CuentasClabeEntidad { get; set; }



    }
}
