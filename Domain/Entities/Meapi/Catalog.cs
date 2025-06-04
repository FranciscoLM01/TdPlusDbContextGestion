using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;

namespace TdPlusDbContextGestion.Domain.Entities.Meapi
{
    public class Catalog
    {
        // TODO: this fix is only to allow work with SPEI
        [NotMapped]
        public List<string>? encabezado { get; set; }
        public string? cuerpo { get; set; }
        public string? firma { get; set; }
        public string? clavePeticion { get; set; }
        public string? numeroEntidad { get; set; }
        public string? idClaveCifrado { get; set; }
    }
}
