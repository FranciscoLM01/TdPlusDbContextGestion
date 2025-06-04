using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdPlusDbContextGestion.Domain.Entities.TranSPEi
{
    public class Month
    {
        public int Number { get; set; }
        public string? Name { get; set; }
        public string? InitialDate { get; set; }
        public string? FinalDate { get; set; }
    }
}
