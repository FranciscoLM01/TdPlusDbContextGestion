
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities;

/// <summary>
/// Esta tabla almacenará las claves de cfrado (clave simétrica y vector de inicialización) para el algoritmo AES 128 en modo CBC y llevar a cabo el cifrado y descifrado de los datos.
/// </summary>
public partial class ClaveCifrado : BaseEntity
{
    public int nIdClaveCifrado { get; set; }

    public string sIdentificador { get; set; }

    public string sClaveSimetrica { get; set; }

    public string sVectorInicializacion { get; set; }

}