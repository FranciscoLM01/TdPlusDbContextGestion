namespace TdPlusDbContextGestion.Domain.Common
{
    /// <summary>
    /// Elementos básicos para auditoría
    /// </summary>
    public class BaseEntity : IKeyable
    {
        /// <summary>
        ///
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Indica si el registro está activo
        /// </summary>
        public bool bActivo { get; set; } = true;

        /// <summary>
        /// Fecha de cuándo se actualizó creó el registro
        /// </summary>
        public DateTime dFecRegistro { get; set; }

        /// <summary>
        /// Fecha de cuándo se actualizó el registro
        /// </summary>
        public DateTime dFecMovimiento { get; set; }

        public BaseEntity()
        {
            Key = GenerateKey();
        }

        public string GenerateKey()
        {
            return Guid.NewGuid().ToString("D").Substring(24);
        }
    }
}
