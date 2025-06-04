
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

/// <summary>
/// Esta tabla se refiere a la parametrización de valores y funciones que requieran los aplicativos.
/// </summary>
public partial class Parametro : BaseEntity
{
    public int nIdParametro { get; set; }

    /// <summary>
    /// Esta columna se refiere al nombre del parámetro, tiene que ser único y no debe de tener espacios ni caracteres especiales
    /// </summary>
    public string sClave { get; set; }

    /// <summary>
    /// Esta columna se refiere a la aplicación o módulo que hace uso del parámetro o en qué aplicaciones o modulos se aplicará el parámetro
    /// </summary>
    public string sModulo { get; set; }

    /// <summary>
    /// Esta columna se refiere a  la descripción dónde se explique el uso del parámetro
    /// </summary>
    public string sDescripcion { get; set; }

    /// <summary>
    /// Esta columna se refiere al valor del parámetro
    /// </summary>
    public string sValor { get; set; }

}