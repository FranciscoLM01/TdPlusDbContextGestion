
using System.ComponentModel.DataAnnotations;

namespace TdPlusDbContextGestion.Domain.Entities.TranSPEi;

public partial class Ordenant
{
    public int OrdenantId { get; set; }
    public string? OrdenantName { get; set; }
    public string? RfcCurp { get; set; }
    public int AccountType { get; set; }
    public int? Account { get; set; }
}
