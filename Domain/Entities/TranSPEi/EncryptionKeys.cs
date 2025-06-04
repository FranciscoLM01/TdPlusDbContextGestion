using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdPlusDbContextGestion.Domain.Entities.TranSPEi
{
    public class EncryptionKey
    {
        public string? Identifier { get; set; }
        public string? Key { get; set; }
        public string? Vector { get; set; }
    }
}
