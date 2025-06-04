using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdPlusDbContextGestion.Domain.Entities.TranSPEi.StoreProcedures
{
    public class Beneficiario
    {
        public int nIdBeneficiario { get; set; }
        public string? sNombre { get; set; }
        public string? sRFCCURP { get; set; }
        public int? nTipoCuenta { get; set; }
        public string? sCuenta { get; set; }
        public string? sBanco { get; set; }
    }

}
