using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities
{
    public class CuentaClabeEntidad :BaseEntity
    {
        public int nIdEntidad { get; set; }
        public int nIdCuentaClabe { get; set; }
        public int nIdCuentaConcentradora { get; set; }
        public int nIdTipoCuentaEntidad { get; set; }

        public virtual Entidad nIdEntidadNavigation { get; set; }
        public virtual CuentaClabe nIdCuentaClabeNavigation { get; set; }
        public virtual CuentaConcentradora nIdCuentaConcentradoraNavigation { get; set; }
        public virtual TipoCuentaEntidad nIdTipoCuentaEntidadNavigation { get; set; }

    }
}
