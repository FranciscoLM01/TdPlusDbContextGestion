using System.ComponentModel.DataAnnotations.Schema;
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

/// <summary>
/// Esta tabla tiene el propósito de almacenar las órdenes que se enviarán a Banco de México
/// </summary>
public partial class Orden : BaseEntity
{
    /// <summary>
    /// Esta columna corresponde a la llave primaria de la tabla. Esta columna es auto incrementable.
    /// </summary>
    public int nIdOrden { get; set; }

    public int nIdBeneficiario { get; set; }

    public int nIdOrdenTransferencia { get; set; }

    /// <summary>
    /// Esta columna corresponde al monto de la órden de transferencia.
    /// </summary>
    public decimal nMonto { get; set; }

    /// <summary>
    /// Esta columna corresponde al importe del IVA correspondientes al pago.
    /// </summary>
    public decimal nIVA { get; set; }

    /// <summary>
    /// Esta columna corresponde a un número de secuencia (1, 2, 3, 4, n) que se le asigna a una orden para que sea capaz de actualizarse el status de una orden. Es una columna que tiene el propósito de ser apoyo.
    /// </summary>
    public int nNumeroSecuencia { get; set; }

    /// <summary>
    /// Esta columna corresponde al motivo concepto de pago por el que se está haciendo la orden de transferencia, es decir, el motivo por el que el ordenante hace el pago al beneficiario
    /// </summary>
    public string sConceptoPago { get; set; } = string.Empty;

    /// <summary>
    /// Esta columna corresponse al dato numerico que sirve al ordenante para identificar el pago. Cabe mencionar, que si en caso el pago tenga como tipo de cuenta beneficiario un número de línea de telefonía móvil esta columna es opcional.
    /// </summary>
    public string sReferenciaNumerica { get; set; } = string.Empty;

    public string sReferenciaCobranza { get; set; } = string.Empty;

    public string sClaveRastreo { get; set; } = string.Empty;

    /// <summary>
    /// Entidad de la orden
    /// </summary>
    public int nIdEntidad { get; set; }

    /// <summary>
    /// Secuencia de la orden
    /// </summary>
    public int nIdSecuencia { get; set; }

    /// <summary>
    /// Fecha de operación de la orden
    /// </summary>
    public int nFechaOperacion { get; set; }

    /// <summary>
    /// Esta columna identifica si la orden se creó a través de una carga masiva
    /// </summary>
    public sbyte bCargaMasiva { get; set; }

    /// <summary>
    /// Fecha de operación
    /// </summary>
    public DateTime dFechaOperacion { get; set; }

    public virtual Beneficiario nIdBeneficiarioNavigation { get; set; }

    public virtual OrdenTransferencia nIdOrdenTransferenciaNavigation { get; set; }
}
