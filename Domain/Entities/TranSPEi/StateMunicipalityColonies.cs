using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdPlusDbContextGestion.Domain.Entities.TranSPEi
{
    public class StateMunicipalityColonies
    {
        public int ColonyId { get; set; }
        public string? ColonyName { get; set; }
        public int MunicipalityId { get; set; }
        public string? MunicipalityName { get; set; }
        public int StateId { get; set; }
        public string? StateName { get; set; }
    }

    public class States
    {
        public int StateId { get; set; }
        public string? StateName { get; set; }
    }

    public class Municipalities
    {
        public int MunicipalityId { get; set; }
        public string? MunicipalityName { get; set; }
    }

    public class Colonies
    {
        public int ColonyId { get; set; }
        public int PostalCode { get; set; }
        public string? ColonyName { get; set; }
    }
}
