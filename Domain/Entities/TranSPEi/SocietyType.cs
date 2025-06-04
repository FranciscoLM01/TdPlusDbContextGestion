using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdPlusDbContextGestion.Domain.Entities.TranSPEi
{
    public class SocietyType
    {
        public int SocietyTypeId { get; set; }
        public string? Clave { get; set; }
        public string? Description { get; set; }
        public int Active { get; set; }
        public string? Key { get; set; }
        public DateTime? Created { get; set; }
    }
}
