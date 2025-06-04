using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdPlusDbContextGestion.Domain.Entities.TranSPEi
{
    public class UserApp
    {
        public int UserId { get; set; } 
        public int IndirectParticipantId { get; set; }
        public string? ProfileId { get; set; }
        public string? Name { get; set; }
        public string? FatherLastName { get; set; }
        public string? MotherLastName { get; set; }
        public string? Email {  get; set; }
        public string? Phone { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set;}
        public int InternalUserId { get; set; } = 2;
    }
}
