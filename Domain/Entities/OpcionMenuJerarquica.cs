
namespace TdPlusDbContextGestion.Domain.Entities;

public partial class OpcionMenuJerarquica
{
    public int nIdOpcionMenuPadre { get; set; }

    public int nIdOpcionMenuHija { get; set; }

    public virtual OpcionMenu nIdOpcionMenuHijaNavigation { get; set; }

    public virtual OpcionMenu nIdOpcionMenuPadreNavigation { get; set; }
}