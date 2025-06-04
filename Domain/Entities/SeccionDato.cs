
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

public partial class SeccionDato : BaseEntity
{
    public int nIdSeccionDato { get; set; }

    public int nIdSeccion { get; set; }

    /// <summary>
    /// Esta columna corresponde al identificador del control, ya sea, un campo de texto, una lista desplegable. Con el proposito de identificar de que control viene la data o información.
    /// </summary>
    public string sIdentificador { get; set; }

    public virtual Seccion nIdSeccionNavigation { get; set; }
}