using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities
{
    /// <summary>
    /// Catálogo para los tipos de cuentas concentradoras principales de la Entidad, ya sea Principal o Secundaria.
    /// </summary>
    public class TipoCuentaEntidad : BaseEntity
    {
        public int nIdTipoCuentaEntidad { get; set; }
        public string sDescripcion { get; set; }
        public virtual ICollection<CuentaClabeEntidad> CuentasClabeEntidad { get; set; } = new List<CuentaClabeEntidad>();
    }
}
