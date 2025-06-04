using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdPlusDbContextGestion.Domain.Entities.TranSPEi
{
    public class AccountStatement: AccountStatementTotalRecords
    {
        public int AccountStatementId { get; set; } 
        public int IndirectParticipantId { get; set; }
        public int TransferOrderId { get; set; }
        public string? Description { get; set; }
        public string? MovementType { get; set; }
        public decimal Amount { get; set; }
        public DateTime MovementDate { get; set; }
        public decimal PreviousBalance { get; set; }
        public decimal Payment { get; set; }
        public decimal Charge { get; set; }
        public decimal Balance { get; set; }
        public string? CreatedDate { get; set; }

    }

    public class AccountStatementTotalRecords
    { 
        public int TotalRecords { get; set; }
    }
}
