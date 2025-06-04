using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities
{
    public class TipoCentroCosto : BaseEntity
    {
        public int nIdTipoCentroCosto { get; set; }
        public string sNombre { get; set; }
        public string sDescripcion { get; set; }

        public virtual ICollection<CentroCosto> CentrosCosto { get; set; }
    }
}
