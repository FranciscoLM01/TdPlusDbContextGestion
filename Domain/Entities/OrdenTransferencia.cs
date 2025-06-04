using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

/// <summary>
/// Orden de transferencia
/// </summary>
public partial class OrdenTransferencia : BaseEntity
{
    /// <summary>
    /// Id de la orden de transferencia
    /// </summary>
    public int nIdOrdenTransferencia { get; set; }

    /// <summary>
    /// Esta columna se refiere al ordenante de la orden de transferencia, es importante señalar que un ordenante puede ser un participante directo o un participante indirecto
    /// </summary>
    public int nIdOrdenante { get; set; }

    /// <summary>
    /// Identificador del tipo de pago
    /// </summary>
    public int nClaveTipoPago { get; set; }

    /// <summary>
    /// Esta columna corrresponde al identificador único que se le asigna a un participante indirecto
    /// </summary>
    public int nNumeroEntidad { get; set; }

    /// <summary>
    /// Corresponde a la clave de petición del request a MEAPI. Por ejemplo, si el objetivo es registrar un pago se hace una petición con número 19.
    /// </summary>
    public int nClavePeticion { get; set; }

    /// <summary>
    /// Esta columna corresponde al ID de clave de cifrado, es decir, es una concatenación del año, mes, día, hora, minutos, segundos y milisegundos.
    /// </summary>
    [Column(TypeName = "varchar(20)")]
    [MaxLength(20)]
    public string sClaveCifrado { get; set; } = string.Empty;

    /// <summary>
    /// Entidad de la orden de transferencia
    /// </summary>
    public int nIdEntidad { get; set; }

    /// <summary>
    /// Secuencia de la orden de transferencia
    /// </summary>
    public int nIdSecuencia { get; set; }

    /// <summary>
    /// Fecha de operación de la orden de transferencia
    /// </summary>
    public int nFechaOperacion { get; set; }

    public virtual ICollection<Orden> Orden { get; set; } = new List<Orden>();

    public virtual TipoPago nClaveTipoPagoNavigation { get; set; } = null!;

    public virtual Ordenante nIdOrdenanteNavigation { get; set; } = null!;
}
