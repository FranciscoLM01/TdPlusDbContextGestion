using System.ComponentModel.DataAnnotations;

namespace TdPlusDbContextGestion.Domain.Entities.TranSPEi;

public partial class Beneficiary
{
    //Beneficiario
    public int BeneficiaryId { get; set; }
    public string? BeneficiaryName { get; set; }
    public string? RfcCurp { get; set; }
    public int AccountType { get; set; }
    public string? Account { get; set; }
    public string? BankName { get; set; }

    //Tipos de sociedades
    public int SocietyTypeId { get; set; }
    public string? Key { get; set; }
    public string? Description { get; set; }

    //Dirección
    public int AddressId { get; set; }
    public int StateId { get; set; }
    public int MunicipalityId { get; set; }
    public int ColonyId { get; set; }
    public string? Street { get; set; }
    public string? ExternalNumber { get; set; }
    public string? InternalNumber { get; set; }
    public int PostalCode { get; set; }
    public string? Colony { get; set; }
    public string? Municipality { get; set; }
    public string? State { get; set; }
}
