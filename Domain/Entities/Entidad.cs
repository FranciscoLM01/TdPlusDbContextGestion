using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities
{
    public partial class Entidad : BaseEntity
    {

        public int nIdEntidad { get; set; }
        public int nIdControlParticipante { get; set; }
        public int nIdParticipante { get; set; }
        public string Alias { get; set; }
        public int nConstante { get; set; }
        public int nEntidad { get; set; }
        public string sEntidad { get; set; }
        public bool bPrincipal { get; set; }


        public virtual ICollection<EntidadProducto> EntidadProducto { get; set; } = new List<EntidadProducto>();

        public virtual ControlParticipante nIdControlParticipanteNavigation { get; set; }
        public virtual Participante nIdParticipanteNavigation { get; set; }
        public virtual ICollection<CuentaClabeEntidad> CuentasClabeEntidad { get; set; }

    }
}
