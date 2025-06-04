using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

/// <summary>
/// This is to generate the order tracking
/// </summary>
[Index("dFechaOperacion", IsUnique = true)]
public partial class Secuencia : BaseEntity
{
    [Required]
    public long nIdSecuencia { get; set; }

    [Required]
    [StringLength(128)]
    public string sNombre { get; set; } = string.Empty;

    [Required]
    [StringLength(12)]
    public string dFechaOperacion { get; set; } = string.Empty;

    /// <summary>
    /// This is the value to generate the order's tracking ID
    /// </summary>
    [Required]
    public long nSecuencia { get; set; } = 0;
}
