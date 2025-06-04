using Microsoft.EntityFrameworkCore;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext;

public partial class TDPlusContext : Microsoft.EntityFrameworkCore.DbContext
{
    public TDPlusContext(DbContextOptions<TDPlusContext> options)
        : base(options) { }

    public virtual DbSet<AutorizacionOpcionMenu> AutorizacionOpcionMenu { get; set; }

    public virtual DbSet<Beneficiario> Beneficiario { get; set; }

    public virtual DbSet<BeneficiarioCliente> BeneficiarioCliente { get; set; }

    public virtual DbSet<BeneficiarioCuenta> BeneficiarioCuenta { get; set; }

    public virtual DbSet<CausaDevolucion> CausaDevolucion { get; set; }

    public virtual DbSet<ClaveCifrado> ClaveCifrado { get; set; }

    public virtual DbSet<Cliente> Cliente { get; set; }

    public virtual DbSet<ClienteCuentaConcentradora> ClienteCuentaConcentradora { get; set; }

    public virtual DbSet<Colonia> Colonia { get; set; }

    public virtual DbSet<CuentaCliente> CuentaCliente { get; set; }

    public virtual DbSet<CuentaConcentradora> CuentaConcentradora { get; set; }

    public virtual DbSet<Direccion> Direccion { get; set; }

    public virtual DbSet<Estado> Estado { get; set; }

    public virtual DbSet<GiroNegocio> GiroNegocio { get; set; }

    public virtual DbSet<Institucion> Institucion { get; set; }

    public virtual DbSet<Movimiento> Movimiento { get; set; }

    public virtual DbSet<Municipio> Municipio { get; set; }

    public virtual DbSet<NotificacionWebhook> NotificacionWebhook { get; set; }

    public virtual DbSet<OpcionMenu> OpcionMenu { get; set; }

    public virtual DbSet<OpcionMenuAccion> OpcionMenuAccion { get; set; }

    public virtual DbSet<OpcionMenuJerarquica> OpcionMenuJerarquica { get; set; }

    public virtual DbSet<Orden> Orden { get; set; }

    public virtual DbSet<OrdenEstado> OrdenEstado { get; set; }

    public virtual DbSet<OrdenMovimiento> OrdenMovimiento { get; set; }

    public virtual DbSet<OrdenTransferencia> OrdenTransferencia { get; set; }

    public virtual DbSet<OrdenTransferenciaEstado> OrdenTransferenciaEstado { get; set; }

    public virtual DbSet<Ordenante> Ordenante { get; set; }

    public virtual DbSet<Parametro> Parametro { get; set; }

    public virtual DbSet<Participante> Participante { get; set; }

    public virtual DbSet<ParticipanteCuentaConcentradora> ParticipanteCuentaConcentradora { get; set; }

    public virtual DbSet<ParticipanteInicioSaldoOperacion> ParticipanteInicioSaldoOperacion { get; set; }

    public virtual DbSet<Perfil> Perfil { get; set; }

    public virtual DbSet<Plaza> Plaza { get; set; }

    public virtual DbSet<ProductoFinanciero> ProductoFinanciero { get; set; }

    public virtual DbSet<Prospecto> Prospecto { get; set; }

    public virtual DbSet<ProspectoDato> ProspectoDato { get; set; }

    public virtual DbSet<ProspectoDocumento> ProspectoDocumento { get; set; }

    public virtual DbSet<ProspectoPerfiles> ProspectoPerfiles { get; set; }

    public virtual DbSet<ProspectoResponsableCuenta> ProspectoResponsableCuenta { get; set; }

    public virtual DbSet<ProspectoResponsableJuridicoCumplimiento> ProspectoResponsableJuridicoCumplimiento { get; set; }

    public virtual DbSet<ProspectoResponsableOperativo> ProspectoResponsableOperativo { get; set; }

    public virtual DbSet<ProspectoResponsableSistema> ProspectoResponsableSistema { get; set; }

    public virtual DbSet<SaldoReserva> SaldoReserva { get; set; }

    public virtual DbSet<Seccion> Seccion { get; set; }

    public virtual DbSet<SeccionDato> SeccionDato { get; set; }

    public virtual DbSet<SeccionDatoEstado> SeccionDatoEstado { get; set; }

    public virtual DbSet<Secuencia> Secuencia { get; set; }

    public virtual DbSet<SeguimientoOrdenEstado> SeguimientoOrdenEstado { get; set; }

    public virtual DbSet<SeguimientoOrdenTransferenciaEstado> SeguimientoOrdenTransferenciaEstado { get; set; }

    public virtual DbSet<Solicitud> Solicitud { get; set; }

    public virtual DbSet<SolicitudConfidencialidad> SolicitudConfidencialidad { get; set; }

    public virtual DbSet<SolicitudEstado> SolicitudEstado { get; set; }

    public virtual DbSet<SolicitudSeccion> SolicitudSeccion { get; set; }

    public virtual DbSet<TipoCuenta> TipoCuenta { get; set; }

    public virtual DbSet<TipoMovimiento> TipoMovimiento { get; set; }

    public virtual DbSet<TipoOperacion> TipoOperacion { get; set; }

    public virtual DbSet<TipoPago> TipoPago { get; set; }

    public virtual DbSet<TipoParticipacion> TipoParticipacion { get; set; }

    public virtual DbSet<TipoSociedad> TipoSociedad { get; set; }

    public virtual DbSet<Usuario> Usuario { get; set; }

    public virtual DbSet<UsuarioPermisoAccion> UsuarioPermisoAccion { get; set; }
    public virtual DbSet<OpcionMenuUsuarioPermisos> OpcionMenuUsuarioPermisos { get; set; }
    public virtual DbSet<OpcionMenuAccionUsuarioPermisos> OpcionMenuAccionUsuarioPermisos { get; set; }
    public virtual DbSet<UsuarioPermisos> UsuarioPermisos { get; set; }

    public virtual DbSet<CentroCosto> CentroCosto { get; set; }
    public virtual DbSet<ControlParticipante> ControlParticipante { get; set; }
    public virtual DbSet<CuentaClabe> CuentaClabe { get; set; }
    public virtual DbSet<Entidad> Entidad { get; set; }
    public virtual DbSet<EntidadProducto> EntidadProducto { get; set; }
    public DbSet<TipoCentroCosto> TipoCentroCosto { get; set; }
    public DbSet<RecepcionPago> RecepcionPago { get; set; }
    public DbSet<RecepcionPagoHistorico> RecepcionPagoHistorico { get; set; }
    public DbSet<UsuarioWebhook> UsuarioWebhook { get; set; }
    public DbSet<CuentaClabeEntidad> CuentaClabeEntidad { get; set; }
    public DbSet<TipoCuentaEntidad> TipoCuentaEntidad { get; set; }
    public DbSet<ValorUDIBanxico> ValorUDIBanxico { get; set; }
    public DbSet<HistoricoValorUDIBanxico> HistoricoValorUDIBanxico { get; set; }
    public DbSet<Devolucion> Devoluciones { get; set; }
    public DbSet<OperacionCompensacion> OperacionCompensacion { get; set; }

    public async Task<bool> SaveAsync()
    {
        return await SaveChangesAsync() > 0;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new Configurations.AutorizacionOpcionMenuConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.BeneficiarioConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.BeneficiarioClienteConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.BeneficiarioCuentaConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.CausaDevolucionConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ClaveCifradoConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ClienteConfiguration());
        modelBuilder.ApplyConfiguration(
            new Configurations.ClienteCuentaConcentradoraConfiguration()
        );
        modelBuilder.ApplyConfiguration(new Configurations.ColoniaConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.CuentaClienteConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.CuentaConcentradoraConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.DireccionConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EstadoConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.GiroNegocioConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.InstitucionConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.MovimientoConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.MunicipioConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.NotificacionWebhookConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.OpcionMenuConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.OpcionMenuAccionConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.OpcionMenuJerarquicaConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.OrdenConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.OrdenEstadoConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.OrdenMovimientoConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.OrdenTransferenciaConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.OrdenTransferenciaEstadoConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.OrdenanteConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ParametroConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ParticipanteConfiguration());
        modelBuilder.ApplyConfiguration(
            new Configurations.ParticipanteCuentaConcentradoraConfiguration()
        );
        modelBuilder.ApplyConfiguration(
            new Configurations.ParticipanteInicioSaldoOperacionConfiguration()
        );
        modelBuilder.ApplyConfiguration(new Configurations.PerfilConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.PlazaConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ProductoFinancieroConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ProspectoConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ProspectoDatoConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ProspectoDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ProspectoPerfilesConfiguration());
        modelBuilder.ApplyConfiguration(
            new Configurations.ProspectoResponsableCuentaConfiguration()
        );
        modelBuilder.ApplyConfiguration(
            new Configurations.ProspectoResponsableJuridicoCumplimientoConfiguration()
        );
        modelBuilder.ApplyConfiguration(
            new Configurations.ProspectoResponsableOperativoConfiguration()
        );
        modelBuilder.ApplyConfiguration(
            new Configurations.ProspectoResponsableSistemaConfiguration()
        );
        modelBuilder.ApplyConfiguration(new Configurations.SaldoReservaConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SeccionConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SeccionDatoConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SeccionDatoEstadoConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SecuenciaConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SeguimientoOrdenEstadoConfiguration());
        modelBuilder.ApplyConfiguration(
            new Configurations.SeguimientoOrdenTransferenciaEstadoConfiguration()
        );
        modelBuilder.ApplyConfiguration(new Configurations.SolicitudConfiguration());
        modelBuilder.ApplyConfiguration(
            new Configurations.SolicitudConfidencialidadConfiguration()
        );
        modelBuilder.ApplyConfiguration(new Configurations.SolicitudEstadoConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SolicitudSeccionConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.TipoCuentaConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.TipoMovimientoConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.TipoOperacionConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.TipoPagoConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.TipoParticipacionConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.TipoSociedadConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.UsuarioConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.UsuarioPermisoAccionConfiguration());
        modelBuilder.ApplyConfiguration(
            new Configurations.OpcionMenuUsuarioPermisosConfiguration()
        );
        modelBuilder.ApplyConfiguration(new Configurations.UsuarioPermisoAccionConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.UsuarioPermisosConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.CentroCostoConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ControlParticipanteConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.CuentaClabeConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EntidadConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EntidadProductoConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.TipoCentroCostoConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.RecepcionPagoConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.RecepcionPagoHistoricoConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.CuentaClabeEntidadConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.TipoCuentaEntidadConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ValorUDIBanxicoConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.HistoricoValorUDIBanxicoConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.DevolucionConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.CausaDevolucionConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.OperacionCompensacionConfiguration());

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
