
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

public partial class OpcionMenu : BaseEntity
{
    public int nIdMenuOpcion { get; set; }

    public string sNombre { get; set; }

    public string sDescripcion { get; set; }

    /// <summary>
    /// Esta columna corresponde a la URL o ruta relativa de la opción. Está precedida por una barra diagonal y, por convención, debe se escribirse en minusculas sin caracteres especiales ni espacios.
    /// </summary>
    public string sRuta { get; set; }

    public virtual ICollection<OpcionMenuAccion> OpcionMenuAccion { get; set; } = new List<OpcionMenuAccion>();
}
