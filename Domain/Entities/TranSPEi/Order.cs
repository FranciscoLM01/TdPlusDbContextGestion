using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TdPlusDbContextGestion.Domain.Entities.TranSPEi;

public class Order
{
    public int TransferOrderId { get; set; }
    public int RequestKey { get; set; }
    public string? EntityNumber { get; set; }
    public string? EncryptionKeyId { get; set; }
    public DateTime CreationDateTime { get; set; }
    public int OrderId { get; set; }
    public int OrdenantId { get; set; }
    public int BeneficiaryId { get; set; }
    public int KeyParticipantIssuer { get; set; }
    public int KeyParticipantRecipient { get; set; }
    public string? Date { get; set; }
    public string? KeyTracking { get; set; }
    public int KeyTypePayment { get; set; }
    public double Amount { get; set; }
    public string? DestinationEntityNumber { get; set; }
    public int StateOriginId { get; set; }
    public int OrderStateId { get; set; }
    public int StateOrderTransferId { get; set; }
    public string? PaymentConcept {  get; set; }    
    public decimal? IVA { get; set; }
    public string? NumericalReference { get; set; }
    public string? CollectionReference { get; set; }
    public List<int>? TransferOrderIdList {  get; set; }
    public string? Motive {  get; set; }

}

public class TransferOrderStatus
{
    public int IdTransferOrderStatus { get; set; }
    public string? TransferOrderStatusCol { get; set; }
}
