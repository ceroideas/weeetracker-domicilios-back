using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WeeeTrackerAPI.Models
{
    public partial class GVRBD3Context : DbContext
    {
        public GVRBD3Context(DbContextOptions<GVRBD3Context> options) : base(options)
        {
        }

        public virtual DbSet<AccesosTemporalesGvr> AccesosTemporalesGvr { get; set; }
        public virtual DbSet<AndroidCentros> AndroidCentros { get; set; }
        public virtual DbSet<AndroidMarcas> AndroidMarcas { get; set; }
        public virtual DbSet<AndroidResiduos> AndroidResiduos { get; set; }
        public virtual DbSet<AndroidServiciosSinRetirada> AndroidServiciosSinRetirada { get; set; }
        public virtual DbSet<AndroidUsuarios> AndroidUsuarios { get; set; }
        public virtual DbSet<AsignacionesEntrega> AsignacionesEntrega { get; set; }
        public virtual DbSet<AuxProcesarAutorizaciones> AuxProcesarAutorizaciones { get; set; }
        public virtual DbSet<Ccaa> Ccaa { get; set; }
        public virtual DbSet<Ccaaprovincia> Ccaaprovincia { get; set; }
        public virtual DbSet<Certificados> Certificados { get; set; }
        public virtual DbSet<CertificadosCompletos> CertificadosCompletos { get; set; }
        public virtual DbSet<CertificadosTratamiento> CertificadosTratamiento { get; set; }
        public virtual DbSet<CertificadosTratamientoOk> CertificadosTratamientoOk { get; set; }
        public virtual DbSet<ConfigPortal> ConfigPortal { get; set; }
        public virtual DbSet<ContactosDireccionTercero> ContactosDireccionTercero { get; set; }
        public virtual DbSet<ControlEtiquetasRemesas> ControlEtiquetasRemesas { get; set; }
        public virtual DbSet<ControlEtiquetasTerceros> ControlEtiquetasTerceros { get; set; }
        public virtual DbSet<CoordenadasErroneas> CoordenadasErroneas { get; set; }
        public virtual DbSet<DireccionesTercero> DireccionesTercero { get; set; }
        public virtual DbSet<DireccionesTerceroContactosDireccionTercero> DireccionesTerceroContactosDireccionTercero { get; set; }
        public virtual DbSet<DireccionesTerceroTiposTercero> DireccionesTerceroTiposTercero { get; set; }
        public virtual DbSet<EstadosCertificado> EstadosCertificado { get; set; }
        public virtual DbSet<EstadosIncidencia> EstadosIncidencia { get; set; }
        public virtual DbSet<EstadosRaee> EstadosRaee { get; set; }
        public virtual DbSet<EstadosRemesa> EstadosRemesa { get; set; }
        public virtual DbSet<FirmasCertificado> FirmasCertificado { get; set; }
        public virtual DbSet<FotosRaeecertificado> FotosRaeecertificado { get; set; }
        public virtual DbSet<Fracciones> Fracciones { get; set; }
        public virtual DbSet<FraccionesTiposContenedor> FraccionesTiposContenedor { get; set; }
        public virtual DbSet<GraficaOnlineWeeeTrace> GraficaOnlineWeeeTrace { get; set; }
        public virtual DbSet<GraficaPortal> GraficaPortal { get; set; }
        public virtual DbSet<HistoricoCambios> HistoricoCambios { get; set; }
        public virtual DbSet<HistoricoCambiosCertificados> HistoricoCambiosCertificados { get; set; }
        public virtual DbSet<HistoricoCambiosTiposCertificado> HistoricoCambiosTiposCertificado { get; set; }
        public virtual DbSet<HistoricoPesadas> HistoricoPesadas { get; set; }
        public virtual DbSet<HistoricoPesosRaee> HistoricoPesosRaee { get; set; }
        public virtual DbSet<I49EmisorOrigen> I49EmisorOrigen { get; set; }
        public virtual DbSet<Incidencias> Incidencias { get; set; }
        public virtual DbSet<IndicadoresDireccionTerceroFraccion> IndicadoresDireccionTerceroFraccion { get; set; }
        public virtual DbSet<InformeCicloVida> InformeCicloVida { get; set; }
        public virtual DbSet<InformeCicloVidaFiltrado> InformeCicloVidaFiltrado { get; set; }
        public virtual DbSet<Informes> Informes { get; set; }
        public virtual DbSet<InventariosFisicos> InventariosFisicos { get; set; }
        public virtual DbSet<InventariosFisicosRaees> InventariosFisicosRaees { get; set; }
        public virtual DbSet<LksJobsCompletarCertificadosIndentificacionTerceros> LksJobsCompletarCertificadosIndentificacionTerceros { get; set; }
        public virtual DbSet<LksRaeesProblemaEtiquetas> LksRaeesProblemaEtiquetas { get; set; }
        public virtual DbSet<LksTratarRaeesFormaManual> LksTratarRaeesFormaManual { get; set; }
        public virtual DbSet<LogEventoPortal> LogEventoPortal { get; set; }
        public virtual DbSet<LogRepartoPesadas> LogRepartoPesadas { get; set; }
        public virtual DbSet<Marcas> Marcas { get; set; }
        public virtual DbSet<Municipios> Municipios { get; set; }
        public virtual DbSet<ObservacionesIncidencia> ObservacionesIncidencia { get; set; }
        public virtual DbSet<ObservacionesRaee> ObservacionesRaee { get; set; }
        public virtual DbSet<Paises> Paises { get; set; }
        public virtual DbSet<PaisesCodigoRaee> PaisesCodigoRaee { get; set; }
        public virtual DbSet<ParametrosGlobales> ParametrosGlobales { get; set; }
        public virtual DbSet<Permisos> Permisos { get; set; }
        public virtual DbSet<Pesadas> Pesadas { get; set; }
        public virtual DbSet<PesosEnviados> PesosEnviados { get; set; }
        public virtual DbSet<Provincias> Provincias { get; set; }
        public virtual DbSet<Raees> Raees { get; set; }
        public virtual DbSet<RaeesAlbaranesEcotrazo> RaeesAlbaranesEcotrazo { get; set; }
        public virtual DbSet<RaeesAReutilizar> RaeesAReutilizar { get; set; }
        public virtual DbSet<RaeesCertificados> RaeesCertificados { get; set; }
        public virtual DbSet<RaeesPrimerCertificado> RaeesPrimerCertificado { get; set; }
        public virtual DbSet<RaeesPruebas> RaeesPruebas { get; set; }
        public virtual DbSet<RaeesUltimaUbicacion> RaeesUltimaUbicacion { get; set; }
        public virtual DbSet<Remesas> Remesas { get; set; }
        public virtual DbSet<Residuos> Residuos { get; set; }
        public virtual DbSet<ResiduosEspecificos> ResiduosEspecificos { get; set; }
        public virtual DbSet<ResponsabilidadesRecogidaEntrega> ResponsabilidadesRecogidaEntrega { get; set; }
        public virtual DbSet<ResponsabilidadesTratamiento> ResponsabilidadesTratamiento { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<RolesPermisos> RolesPermisos { get; set; }
        public virtual DbSet<Sigs> Sigs { get; set; }
        public virtual DbSet<Solicitudes> Solicitudes { get; set; }
        public virtual DbSet<Terceros> Terceros { get; set; }
        public virtual DbSet<TercerosExcluidos> TercerosExcluidos { get; set; }
        public virtual DbSet<TercerosReutilizacion2017> TercerosReutilizacion2017 { get; set; }
        public virtual DbSet<TercerosTiposTercero> TercerosTiposTercero { get; set; }
        public virtual DbSet<Terminales> Terminales { get; set; }
        public virtual DbSet<TiposCertificado> TiposCertificado { get; set; }
        public virtual DbSet<TiposContenedor> TiposContenedor { get; set; }
        public virtual DbSet<TiposDestino> TiposDestino { get; set; }
        public virtual DbSet<TiposEtiqueta> TiposEtiqueta { get; set; }
        public virtual DbSet<TiposIncidencia> TiposIncidencia { get; set; }
        public virtual DbSet<TiposLectura> TiposLectura { get; set; }
        public virtual DbSet<TiposLecturaTratamiento> TiposLecturaTratamiento { get; set; }
        public virtual DbSet<TiposOperativa> TiposOperativa { get; set; }
        public virtual DbSet<TiposServicio> TiposServicio { get; set; }
        public virtual DbSet<TiposTercero> TiposTercero { get; set; }
        public virtual DbSet<Tratamientos> Tratamientos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<V3v2CambiosDetallesTercerosFicticios> V3v2CambiosDetallesTercerosFicticios { get; set; }
        public virtual DbSet<V3v2DireccionTercerosConversion> V3v2DireccionTercerosConversion { get; set; }
        public virtual DbSet<V3v2ProcTablasBorrar> V3v2ProcTablasBorrar { get; set; }
        public virtual DbSet<V3v2TercerosConversion> V3v2TercerosConversion { get; set; }
        public virtual DbSet<V4v3Mapeos2016> V4v3Mapeos2016 { get; set; }
        public virtual DbSet<VersionesPda> VersionesPda { get; set; }
        public virtual DbSet<VersionesPublicaciones> VersionesPublicaciones { get; set; }
        public virtual DbSet<VideosRaeeConfigRutas> VideosRaeeConfigRutas { get; set; }
        public virtual DbSet<WtkCambioEstado> WtkCambioEstado { get; set; }
        public virtual DbSet<WtkCambioEstadoFirma> WtkCambioEstadoFirma { get; set; }
        public virtual DbSet<WtkCambioEstadoFotografia> WtkCambioEstadoFotografia { get; set; }
        public virtual DbSet<WtkPerfil> WtkPerfil { get; set; }
        public virtual DbSet<WtkResiduoespecifico> WtkResiduoespecifico { get; set; }
        public virtual DbSet<WtkTextoLopd> WtkTextoLopd { get; set; }
        public virtual DbSet<WtkUsuario> WtkUsuario { get; set; }
        public virtual DbSet<WtkUsuarioDirecciones> WtkUsuarioDirecciones { get; set; }
        public virtual DbSet<WtkUsuarioPerfiles> WtkUsuarioPerfiles { get; set; }

        // Unable to generate entity type for table 'dbo.Tlog'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AndroidMaquinas'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AndroidContadores'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Version'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Configuraciones'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ECOAPP_Certificados_20140513'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RemesasCopia'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temporal'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RAEES_PRUEBA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PesadasErroneas'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RAEEsCertificados_UltimoID'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TratamientosError'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VideosRAEE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Prueba'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LKS_ECOAPP_Comprobacion_Centros'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LKS_ECOAPP_Comprobacion_Terceros'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AndroidActualizaciones'. Please see the warning messages.
 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccesosTemporalesGvr>(entity =>
            {
                entity.HasKey(e => e.AccesoId);

                entity.ToTable("AccesosTemporalesGVR");

                entity.Property(e => e.Certificado)
                    .IsRequired()
                    .HasColumnName("certificado")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Codigoacceso)
                    .IsRequired()
                    .HasColumnName("codigoacceso")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Creacion)
                    .HasColumnName("creacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pesada)
                    .HasColumnName("pesada")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnName("usuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Validez)
                    .HasColumnName("validez")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<AndroidCentros>(entity =>
            {
                entity.HasKey(e => e.PidDireccionTercero);

                entity.Property(e => e.PidDireccionTercero)
                    .HasColumnName("pidDireccionTercero")
                    .ValueGeneratedNever();

                entity.Property(e => e.Activo).HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SidDireccionGenerica).HasColumnName("sidDireccionGenerica");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<AndroidMarcas>(entity =>
            {
                entity.HasKey(e => e.PidMarca);

                entity.Property(e => e.PidMarca)
                    .HasColumnName("pidMarca")
                    .ValueGeneratedNever();

                entity.Property(e => e.Activa)
                    .HasColumnName("activa")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<AndroidResiduos>(entity =>
            {
                entity.HasKey(e => e.PidResiduoAndroid);

                entity.Property(e => e.PidResiduoAndroid)
                    .HasColumnName("pidResiduoAndroid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Activo).HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidResiduo).HasColumnName("sidResiduo");

                entity.Property(e => e.SidResiduoEspecifico).HasColumnName("sidResiduoEspecifico");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<AndroidServiciosSinRetirada>(entity =>
            {
                entity.HasKey(e => e.PidCertificado);

                entity.Property(e => e.PidCertificado)
                    .HasColumnName("pidCertificado")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.GpsX).HasColumnName("gpsX");

                entity.Property(e => e.GpsY).HasColumnName("gpsY");

                entity.Property(e => e.GpsZ).HasColumnName("gpsZ");

                entity.Property(e => e.NroCertificadoReferencia)
                    .HasColumnName("nroCertificadoReferencia")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.NumCertOrigen)
                    .HasColumnName("numCertOrigen")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumFirmas).HasColumnName("numFirmas");

                entity.Property(e => e.Servicio).HasDefaultValueSql("((0))");

                entity.Property(e => e.SidDireccionTerceroDestinatario).HasColumnName("sidDireccionTerceroDestinatario");

                entity.Property(e => e.SidDireccionTerceroEmisor).HasColumnName("sidDireccionTerceroEmisor");

                entity.Property(e => e.SidDireccionTerceroSolicitante).HasColumnName("sidDireccionTerceroSolicitante");

                entity.Property(e => e.SidEstadoCertificado).HasColumnName("sidEstadoCertificado");

                entity.Property(e => e.SidFirmaProcedencia)
                    .HasColumnName("sidFirmaProcedencia")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.SidFirmaTransporte)
                    .HasColumnName("sidFirmaTransporte")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.SidTerceroDestinatario).HasColumnName("sidTerceroDestinatario");

                entity.Property(e => e.SidTerceroEmisor).HasColumnName("sidTerceroEmisor");

                entity.Property(e => e.SidTerceroSolicitante).HasColumnName("sidTerceroSolicitante");
            });

            modelBuilder.Entity<AndroidUsuarios>(entity =>
            {
                entity.HasKey(e => e.PidUsuario);

                entity.Property(e => e.PidUsuario)
                    .HasColumnName("pidUsuario")
                    .ValueGeneratedNever();

                entity.Property(e => e.Activo).HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<AsignacionesEntrega>(entity =>
            {
                entity.HasKey(e => e.PidAsignacionEntrega);

                entity.HasIndex(e => e.Estado)
                    .HasName("Estado_AsignacionesEntrega");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_316839420")
                    .IsUnique();

                entity.Property(e => e.PidAsignacionEntrega)
                    .HasColumnName("pidAsignacionEntrega")
                    .ValueGeneratedNever();

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidDireccionTerceroDestino).HasColumnName("sidDireccionTerceroDestino");

                entity.Property(e => e.SidDireccionTerceroOrigen).HasColumnName("sidDireccionTerceroOrigen");

                entity.Property(e => e.SidFraccionOrigen).HasColumnName("sidFraccionOrigen");

                entity.Property(e => e.SidTerceroDestino).HasColumnName("sidTerceroDestino");

                entity.Property(e => e.SidTerceroOrigen).HasColumnName("sidTerceroOrigen");
            });

            modelBuilder.Entity<AuxProcesarAutorizaciones>(entity =>
            {
                entity.HasKey(e => e.PidAutorizacion);

                entity.ToTable("AuxProcesar_Autorizaciones");

                entity.Property(e => e.PidAutorizacion)
                    .HasColumnName("pidAutorizacion")
                    .ValueGeneratedNever();

                entity.Property(e => e.FechaFin)
                    .HasColumnName("fechaFin")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("fechaInicio")
                    .HasColumnType("datetime");

                entity.Property(e => e.Operacion).HasColumnName("operacion");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<Ccaa>(entity =>
            {
                entity.ToTable("CCAA");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ccaaprovincia>(entity =>
            {
                entity.HasKey(e => new { e.Ccaaid, e.ProvinciaId });

                entity.ToTable("CCAAProvincia");

                entity.Property(e => e.Ccaaid).HasColumnName("CCAAId");
            });

            modelBuilder.Entity<Certificados>(entity =>
            {
                entity.HasKey(e => e.PidCertificado);

                entity.HasIndex(e => e.Fecha)
                    .HasName("IX_FECHA");

                entity.HasIndex(e => e.SidDireccionTerceroDestinatario)
                    .HasName("IX_DESTINATARIO");

                entity.HasIndex(e => new { e.Fecha, e.SidTipoCertificado })
                    .HasName("IX_FECHA_TIPO");

                entity.HasIndex(e => new { e.PidCertificado, e.Fecha })
                    .HasName("IX_CERT_FECHA")
                    .IsUnique();

                entity.HasIndex(e => new { e.PidCertificado, e.NumRaees })
                    .HasName("IX_CERT_NUMRAEES")
                    .IsUnique();

                entity.HasIndex(e => new { e.PidCertificado, e.SidEstadoCertificado })
                    .HasName("IX_PID_ESTADO")
                    .IsUnique();

                entity.HasIndex(e => new { e.SidTerceroDestinatario, e.SidDireccionTerceroDestinatario })
                    .HasName("IX_DESTINATARIO_T_D");

                entity.HasIndex(e => new { e.PidCertificado, e.SidTerceroDestinatario, e.SidDireccionTerceroDestinatario })
                    .HasName("IX_CERT_DESTINA")
                    .IsUnique();

                entity.HasIndex(e => new { e.PidCertificado, e.SidEstadoCertificado, e.SidTerceroSolicitante, e.SidTerceroEmisor })
                    .HasName("IX_PID_ESTADO_ORIGEN_EMISOR")
                    .IsUnique();

                entity.HasIndex(e => new { e.SidTipoCertificado, e.SidSolicitud, e.SidTerceroSolicitante, e.SidDireccionTerceroSolicitante, e.SidTerceroDestinatario, e.SidDireccionTerceroDestinatario, e.SidEstadoCertificado })
                    .HasName("IX_GENERAL");

                entity.Property(e => e.PidCertificado)
                    .HasColumnName("pidCertificado")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AuxDireccion)
                    .HasColumnName("auxDireccion")
                    .HasMaxLength(256);

                entity.Property(e => e.AuxEntidad)
                    .HasColumnName("auxEntidad")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.AuxLocalidad)
                    .HasColumnName("auxLocalidad")
                    .HasMaxLength(256);

                entity.Property(e => e.AuxNif)
                    .HasColumnName("auxNIF")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AuxPais)
                    .HasColumnName("auxPais")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.AuxProvincia)
                    .HasColumnName("auxProvincia")
                    .HasMaxLength(256);

                entity.Property(e => e.AuxReferencia)
                    .HasColumnName("auxReferencia")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.AuxTelefono)
                    .HasColumnName("auxTelefono")
                    .HasMaxLength(20);

                entity.Property(e => e.Completado)
                    .HasColumnName("completado")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaLiquidacion)
                    .HasColumnName("fechaLiquidacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaOperacion)
                    .HasColumnName("fechaOperacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.NroCertificado)
                    .HasColumnName("nroCertificado")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NroCertificadoReferencia)
                    .HasColumnName("nroCertificadoReferencia")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.NumCertOrigen)
                    .HasColumnName("numCertOrigen")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumFirmas)
                    .HasColumnName("numFirmas")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NumRaees).HasColumnName("numRaees");

                entity.Property(e => e.Observaciones)
                    .HasColumnName("observaciones")
                    .IsUnicode(false);

                entity.Property(e => e.PesoEnviado).HasColumnName("pesoEnviado");

                entity.Property(e => e.Servicio).HasDefaultValueSql("((0))");

                entity.Property(e => e.SidDireccionTerceroDestinatario).HasColumnName("sidDireccionTerceroDestinatario");

                entity.Property(e => e.SidDireccionTerceroEmisor).HasColumnName("sidDireccionTerceroEmisor");

                entity.Property(e => e.SidDireccionTerceroSolicitante).HasColumnName("sidDireccionTerceroSolicitante");

                entity.Property(e => e.SidEstadoCertificado).HasColumnName("sidEstadoCertificado");

                entity.Property(e => e.SidFirmaDestino)
                    .HasColumnName("sidFirmaDestino")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.SidFirmaProcedencia)
                    .HasColumnName("sidFirmaProcedencia")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.SidFirmaTransporte)
                    .HasColumnName("sidFirmaTransporte")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.SidSig).HasColumnName("sidSIG");

                entity.Property(e => e.SidSolicitud).HasColumnName("sidSolicitud");

                entity.Property(e => e.SidTerceroDestinatario).HasColumnName("sidTerceroDestinatario");

                entity.Property(e => e.SidTerceroEmisor).HasColumnName("sidTerceroEmisor");

                entity.Property(e => e.SidTerceroSolicitante).HasColumnName("sidTerceroSolicitante");

                entity.Property(e => e.SidTipoCertificado).HasColumnName("sidTipoCertificado");

                entity.Property(e => e.TransportistaCodigo)
                    .HasColumnName("transportistaCodigo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransportistaConductor)
                    .HasColumnName("transportistaConductor")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.TransportistaDni)
                    .HasColumnName("transportistaDNI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransportistaDocControl)
                    .HasColumnName("transportistaDocControl")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TransportistaExpedicion)
                    .HasColumnName("transportistaExpedicion")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransportistaMatricula)
                    .HasColumnName("transportistaMatricula")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransportistaNif)
                    .HasColumnName("transportistaNIF")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransportistaNombre)
                    .HasColumnName("transportistaNombre")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.UltimaActualizacion)
                    .HasColumnName("ultimaActualizacion")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.ServicioNavigation)
                    .WithMany(p => p.Certificados)
                    .HasForeignKey(d => d.Servicio)
                    .HasConstraintName("FK_Certificados_TiposServicio");

                entity.HasOne(d => d.SidDireccionTerceroDestinatarioNavigation)
                    .WithMany(p => p.CertificadosSidDireccionTerceroDestinatarioNavigation)
                    .HasForeignKey(d => d.SidDireccionTerceroDestinatario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Certificados_DireccionesTerceroDestinatario");

                entity.HasOne(d => d.SidDireccionTerceroSolicitanteNavigation)
                    .WithMany(p => p.CertificadosSidDireccionTerceroSolicitanteNavigation)
                    .HasForeignKey(d => d.SidDireccionTerceroSolicitante)
                    .HasConstraintName("FK_Certificados_DireccionesTerceroSolicitante");

                entity.HasOne(d => d.SidEstadoCertificadoNavigation)
                    .WithMany(p => p.Certificados)
                    .HasForeignKey(d => d.SidEstadoCertificado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Certificados_EstadosCertificado");

                entity.HasOne(d => d.SidFirmaDestinoNavigation)
                    .WithMany(p => p.CertificadosSidFirmaDestinoNavigation)
                    .HasForeignKey(d => d.SidFirmaDestino)
                    .HasConstraintName("FK_Certificados_FirmasCertificadoDestino");

                entity.HasOne(d => d.SidFirmaProcedenciaNavigation)
                    .WithMany(p => p.CertificadosSidFirmaProcedenciaNavigation)
                    .HasForeignKey(d => d.SidFirmaProcedencia)
                    .HasConstraintName("FK_Certificados_FirmasCertificadoProcedencia");

                entity.HasOne(d => d.SidFirmaTransporteNavigation)
                    .WithMany(p => p.CertificadosSidFirmaTransporteNavigation)
                    .HasForeignKey(d => d.SidFirmaTransporte)
                    .HasConstraintName("FK_Certificados_FirmasCertificadoTransporte");

                entity.HasOne(d => d.SidSigNavigation)
                    .WithMany(p => p.Certificados)
                    .HasForeignKey(d => d.SidSig)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Certificados_SIGs");

                entity.HasOne(d => d.SidTerceroEmisorNavigation)
                    .WithMany(p => p.Certificados)
                    .HasForeignKey(d => d.SidTerceroEmisor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Certificados_TercerosEmisor");

                entity.HasOne(d => d.SidTipoCertificadoNavigation)
                    .WithMany(p => p.Certificados)
                    .HasForeignKey(d => d.SidTipoCertificado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Certificados_TiposCertificado");
            });

            modelBuilder.Entity<CertificadosCompletos>(entity =>
            {
                entity.HasKey(e => e.PidCertificado);

                entity.Property(e => e.PidCertificado)
                    .HasColumnName("pidCertificado")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.NraeesCertificado).HasColumnName("NRAEEsCertificado");
            });

            modelBuilder.Entity<CertificadosTratamiento>(entity =>
            {
                entity.HasKey(e => e.PidCertificadoTratamiento);

                entity.HasIndex(e => new { e.PidCertificadoTratamiento, e.FechaTratamiento })
                    .HasName("IX_FECHA");

                entity.HasIndex(e => new { e.SidTercero, e.FechaTratamiento })
                    .HasName("IX_TER_FECHA");

                entity.HasIndex(e => new { e.SidTercero, e.SidDireccionTercero, e.FechaTratamiento })
                    .HasName("IX_GENERAL");

                entity.HasIndex(e => new { e.SidTercero, e.FechaTratamiento, e.SidDireccionTercero, e.SidTipoLecturaTratamiento, e.GrabacionVideo })
                    .HasName("IX_TRATAMIENTOS");

                entity.Property(e => e.PidCertificadoTratamiento).HasColumnName("pidCertificadoTratamiento");

                entity.Property(e => e.CodigoInstalacionTratamiento).HasColumnName("codigoInstalacionTratamiento");

                entity.Property(e => e.FechaTratamiento)
                    .HasColumnName("fechaTratamiento")
                    .HasColumnType("datetime");

                entity.Property(e => e.Incidencia).HasColumnName("incidencia");

                entity.Property(e => e.ObservacionesIncidencia)
                    .HasColumnName("observacionesIncidencia")
                    .IsUnicode(false);

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SidTipoLecturaTratamiento).HasColumnName("sidTipoLecturaTratamiento");

                entity.HasOne(d => d.SidDireccionTerceroNavigation)
                    .WithMany(p => p.CertificadosTratamiento)
                    .HasForeignKey(d => d.SidDireccionTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CertificadosTratamiento_DireccionesTercero");

                entity.HasOne(d => d.SidTerceroNavigation)
                    .WithMany(p => p.CertificadosTratamiento)
                    .HasForeignKey(d => d.SidTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CertificadosTratamiento_Terceros1");

                entity.HasOne(d => d.SidTipoLecturaTratamientoNavigation)
                    .WithMany(p => p.CertificadosTratamiento)
                    .HasForeignKey(d => d.SidTipoLecturaTratamiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CertificadosTratamiento_TiposLecturaTratamiento");
            });

            modelBuilder.Entity<CertificadosTratamientoOk>(entity =>
            {
                entity.HasKey(e => e.PidCertificadoTratamiento);

                entity.ToTable("CertificadosTratamiento_OK");

                entity.Property(e => e.PidCertificadoTratamiento).HasColumnName("pidCertificadoTratamiento");

                entity.Property(e => e.CodigoInstalacionTratamiento).HasColumnName("codigoInstalacionTratamiento");

                entity.Property(e => e.FechaTratamiento)
                    .HasColumnName("fechaTratamiento")
                    .HasColumnType("datetime");

                entity.Property(e => e.Incidencia).HasColumnName("incidencia");

                entity.Property(e => e.ObservacionesIncidencia)
                    .HasColumnName("observacionesIncidencia")
                    .IsUnicode(false);

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SidTipoLecturaTratamiento).HasColumnName("sidTipoLecturaTratamiento");
            });

            modelBuilder.Entity<ConfigPortal>(entity =>
            {
                entity.HasKey(e => e.Proceso);

                entity.Property(e => e.Proceso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Detalles).IsUnicode(false);
            });

            modelBuilder.Entity<ContactosDireccionTercero>(entity =>
            {
                entity.HasKey(e => e.PidContactoDireccionTercero);

                entity.HasIndex(e => e.Estado)
                    .HasName("Estado_ContactorDireccionTercero");

                entity.HasIndex(e => e.PidContactoDireccionTercero)
                    .HasName("IX_FK_DireccionesTercerosContactosDireccionTercero")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_659792637")
                    .IsUnique();

                entity.Property(e => e.PidContactoDireccionTercero)
                    .HasColumnName("pidContactoDireccionTercero")
                    .ValueGeneratedNever();

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasColumnName("apellidos");

                entity.Property(e => e.CodGtr).HasColumnName("codGTR");

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasColumnName("contrasena");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.PerfilGvr).HasColumnName("perfilGVR");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(15);

                entity.HasOne(d => d.SidTerceroNavigation)
                    .WithMany(p => p.ContactosDireccionTercero)
                    .HasForeignKey(d => d.SidTercero)
                    .HasConstraintName("FK_ContactosDireccionTercero_Terceros");
            });

            modelBuilder.Entity<ControlEtiquetasRemesas>(entity =>
            {
                entity.HasKey(e => e.PidRemesa);

                entity.ToTable("ControlEtiquetas_Remesas");

                entity.Property(e => e.PidRemesa)
                    .HasColumnName("pidRemesa")
                    .ValueGeneratedNever();

                entity.Property(e => e.TotConsumidos).HasColumnName("totConsumidos");

                entity.Property(e => e.TotEntregados).HasColumnName("totEntregados");

                entity.Property(e => e.TotPerdidos).HasColumnName("totPerdidos");
            });

            modelBuilder.Entity<ControlEtiquetasTerceros>(entity =>
            {
                entity.HasKey(e => new { e.SidTercero, e.SidDireccionTercero, e.TodasRemesas });

                entity.ToTable("ControlEtiquetas_Terceros");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.TodasRemesas).HasColumnName("todasRemesas");

                entity.Property(e => e.TotConsumidos).HasColumnName("totConsumidos");

                entity.Property(e => e.TotEntregados).HasColumnName("totEntregados");

                entity.Property(e => e.TotPerdidos).HasColumnName("totPerdidos");
            });

            modelBuilder.Entity<CoordenadasErroneas>(entity =>
            {
                entity.HasKey(e => e.IdCoordError);

                entity.Property(e => e.Latitud).HasColumnName("latitud");

                entity.Property(e => e.Longitud).HasColumnName("longitud");
            });

            modelBuilder.Entity<DireccionesTercero>(entity =>
            {
                entity.HasKey(e => e.PidDireccionTercero);

                entity.HasIndex(e => e.Estado)
                    .HasName("Estado_DireccionesTercero");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_341887514")
                    .IsUnique();

                entity.HasIndex(e => e.SidPais)
                    .HasName("IX_FK_PaisDireccionesTerceros");

                entity.HasIndex(e => e.SidProvincia)
                    .HasName("IX_PROVINCIA");

                entity.HasIndex(e => new { e.SidTercero, e.PidDireccionTercero })
                    .HasName("IX_terceros")
                    .IsUnique();

                entity.Property(e => e.PidDireccionTercero)
                    .HasColumnName("pidDireccionTercero")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodGtr).HasColumnName("codGTR");

                entity.Property(e => e.CodTipo).HasColumnName("codTipo");

                entity.Property(e => e.CodigoPostal)
                    .HasColumnName("codigoPostal")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CoordenadaX).HasColumnName("coordenadaX");

                entity.Property(e => e.CoordenadaY).HasColumnName("coordenadaY");

                entity.Property(e => e.DiasPesado).HasColumnName("diasPesado");

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Inventario).HasColumnName("inventario");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pesado).HasColumnName("pesado");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidMunicipio).HasColumnName("sidMunicipio");

                entity.Property(e => e.SidPais).HasColumnName("sidPais");

                entity.Property(e => e.SidProvincia).HasColumnName("sidProvincia");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.TipoDireccion)
                    .HasColumnName("tipoDireccion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoVia)
                    .HasColumnName("tipoVia")
                    .HasMaxLength(50);

                entity.Property(e => e.UsoRefTercero).HasColumnName("usoRefTercero");

                entity.HasOne(d => d.SidMunicipioNavigation)
                    .WithMany(p => p.DireccionesTercero)
                    .HasForeignKey(d => d.SidMunicipio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DireccionesTercero_Municipios");

                entity.HasOne(d => d.SidPaisNavigation)
                    .WithMany(p => p.DireccionesTercero)
                    .HasForeignKey(d => d.SidPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaisDireccionesTerceros");

                entity.HasOne(d => d.SidProvinciaNavigation)
                    .WithMany(p => p.DireccionesTercero)
                    .HasForeignKey(d => d.SidProvincia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProvinciaDireccionesTerceros");

                entity.HasOne(d => d.SidTerceroNavigation)
                    .WithMany(p => p.DireccionesTercero)
                    .HasForeignKey(d => d.SidTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DireccionesTercero_Terceros");
            });

            modelBuilder.Entity<DireccionesTerceroContactosDireccionTercero>(entity =>
            {
                entity.HasKey(e => e.PidDireccionTerceroContactoDireccionTercero);

                entity.HasIndex(e => e.Estado)
                    .HasName("Estado_DireccionesTerceroContactosDireccionTercero");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_1555795829")
                    .IsUnique();

                entity.Property(e => e.PidDireccionTerceroContactoDireccionTercero)
                    .HasColumnName("pidDireccionTerceroContactoDireccionTercero")
                    .ValueGeneratedNever();

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidContactoDireccionTercero).HasColumnName("sidContactoDireccionTercero");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.HasOne(d => d.SidContactoDireccionTerceroNavigation)
                    .WithMany(p => p.DireccionesTerceroContactosDireccionTercero)
                    .HasForeignKey(d => d.SidContactoDireccionTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DireccionesTerceroContactosDireccionTercero_ContactosDireccionTercero");

                entity.HasOne(d => d.SidDireccionTerceroNavigation)
                    .WithMany(p => p.DireccionesTerceroContactosDireccionTercero)
                    .HasForeignKey(d => d.SidDireccionTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DireccionesTerceroContactosDireccionTercero_DireccionesTercero");
            });

            modelBuilder.Entity<DireccionesTerceroTiposTercero>(entity =>
            {
                entity.HasKey(e => e.PidDireccionTerceroTipoTercero);

                entity.HasIndex(e => e.Estado)
                    .HasName("Estado_DireccionesTerceroTiposTercero");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_1475795544")
                    .IsUnique();

                entity.Property(e => e.PidDireccionTerceroTipoTercero)
                    .HasColumnName("pidDireccionTerceroTipoTercero")
                    .ValueGeneratedNever();

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidDireccionesTercero).HasColumnName("sidDireccionesTercero");

                entity.Property(e => e.SidTipoTercero).HasColumnName("sidTipoTercero");

                entity.HasOne(d => d.SidDireccionesTerceroNavigation)
                    .WithMany(p => p.DireccionesTerceroTiposTercero)
                    .HasForeignKey(d => d.SidDireccionesTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DireccionesTerceroTiposTercero_DireccionesTercero");

                entity.HasOne(d => d.SidTipoTerceroNavigation)
                    .WithMany(p => p.DireccionesTerceroTiposTercero)
                    .HasForeignKey(d => d.SidTipoTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DireccionesTerceroTiposTercero_TiposTercero");
            });

            modelBuilder.Entity<EstadosCertificado>(entity =>
            {
                entity.HasKey(e => e.PidEstadoCertificado);

                entity.Property(e => e.PidEstadoCertificado)
                    .HasColumnName("pidEstadoCertificado")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EstadosIncidencia>(entity =>
            {
                entity.HasKey(e => e.PidEstadoIncidencia);

                entity.Property(e => e.PidEstadoIncidencia)
                    .HasColumnName("pidEstadoIncidencia")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EstadosRaee>(entity =>
            {
                entity.HasKey(e => e.PidEstadoRaee);

                entity.ToTable("EstadosRAEE");

                entity.Property(e => e.PidEstadoRaee)
                    .HasColumnName("pidEstadoRAEE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(255);

                entity.Property(e => e.Orden).HasColumnName("orden");
            });

            modelBuilder.Entity<EstadosRemesa>(entity =>
            {
                entity.HasKey(e => e.PidEstadoRemesa);

                entity.Property(e => e.PidEstadoRemesa).HasColumnName("pidEstadoRemesa");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FirmasCertificado>(entity =>
            {
                entity.HasKey(e => e.PidFirmaCertificado);

                entity.Property(e => e.PidFirmaCertificado)
                    .HasColumnName("pidFirmaCertificado")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Cargo)
                    .HasColumnName("cargo")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Firma)
                    .HasColumnName("firma")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FotosRaeecertificado>(entity =>
            {
                entity.HasKey(e => e.PidFotoRaeecertificado);

                entity.ToTable("FotosRAEECertificado");

                entity.Property(e => e.PidFotoRaeecertificado)
                    .HasColumnName("pidFotoRAEECertificado")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.NombreFichero)
                    .IsRequired()
                    .HasColumnName("nombreFichero")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.SidRaeecertificado)
                    .IsRequired()
                    .HasColumnName("sidRAEECertificado")
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fracciones>(entity =>
            {
                entity.HasKey(e => e.PidFraccion);

                entity.HasIndex(e => e.Estado)
                    .HasName("Estado_Fracciones");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_851793321")
                    .IsUnique();

                entity.Property(e => e.PidFraccion)
                    .HasColumnName("pidFraccion")
                    .ValueGeneratedNever();

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(255);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<FraccionesTiposContenedor>(entity =>
            {
                entity.HasKey(e => e.PidFraccionTipoContenedor);

                entity.HasIndex(e => e.Estado)
                    .HasName("Estado_FraccionesTiposContenedor");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_364839591")
                    .IsUnique();

                entity.Property(e => e.PidFraccionTipoContenedor)
                    .HasColumnName("pidFraccionTipoContenedor")
                    .ValueGeneratedNever();

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PesoMedio).HasColumnName("pesoMedio");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidTipoContenedor).HasColumnName("sidTipoContenedor");
            });

            modelBuilder.Entity<GraficaOnlineWeeeTrace>(entity =>
            {
                entity.HasKey(e => e.PidGrafica);

                entity.ToTable("GraficaOnline_WeeeTrace");

                entity.HasIndex(e => e.Fecha)
                    .HasName("IX_FECHA")
                    .IsUnique();

                entity.Property(e => e.PidGrafica).HasColumnName("pidGrafica");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<GraficaPortal>(entity =>
            {
                entity.HasKey(e => e.Pid);

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<HistoricoCambios>(entity =>
            {
                entity.HasKey(e => e.PidHistoricoCambio);

                entity.HasIndex(e => e.SidResiduoEspecificoAntes)
                    .HasName("IX_RES_ESP_ANTES");

                entity.HasIndex(e => new { e.Fecha, e.SidRaee })
                    .HasName("IX_FECHA");

                entity.HasIndex(e => new { e.Fecha, e.CanibalizadoAntes, e.SidRaee })
                    .HasName("IX_FECHA_CANI");

                entity.Property(e => e.PidHistoricoCambio)
                    .HasColumnName("pidHistoricoCambio")
                    .ValueGeneratedNever();

                entity.Property(e => e.CanibalizadoAntes).HasColumnName("canibalizadoAntes");

                entity.Property(e => e.CanibalizadoDespues).HasColumnName("canibalizadoDespues");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.SidCertificado)
                    .HasColumnName("sidCertificado")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SidEstadoAntes).HasColumnName("sidEstadoAntes");

                entity.Property(e => e.SidEstadoDespues).HasColumnName("sidEstadoDespues");

                entity.Property(e => e.SidRaee)
                    .HasColumnName("sidRAEE")
                    .HasMaxLength(50);

                entity.Property(e => e.SidRaeecertificado)
                    .HasColumnName("sidRAEECertificado")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.SidResiduoEspecificoAntes).HasColumnName("sidResiduoEspecificoAntes");

                entity.Property(e => e.SidResiduoEspecificoDespues).HasColumnName("sidResiduoEspecificoDespues");

                entity.Property(e => e.SidTipoDeContenedorAntes).HasColumnName("sidTipoDeContenedorAntes");

                entity.Property(e => e.SidTipoDeContenedorDespues).HasColumnName("sidTipoDeContenedorDespues");

                entity.HasOne(d => d.SidCertificadoNavigation)
                    .WithMany(p => p.HistoricoCambios)
                    .HasForeignKey(d => d.SidCertificado)
                    .HasConstraintName("FK_HistoricoCambios_Certificados");

                entity.HasOne(d => d.SidEstadoAntesNavigation)
                    .WithMany(p => p.HistoricoCambiosSidEstadoAntesNavigation)
                    .HasForeignKey(d => d.SidEstadoAntes)
                    .HasConstraintName("FK_HistoricoCambios_EstadosRAEEAntes");

                entity.HasOne(d => d.SidEstadoDespuesNavigation)
                    .WithMany(p => p.HistoricoCambiosSidEstadoDespuesNavigation)
                    .HasForeignKey(d => d.SidEstadoDespues)
                    .HasConstraintName("FK_HistoricoCambios_EstadosRAEEDespues");

                entity.HasOne(d => d.SidRaeeNavigation)
                    .WithMany(p => p.HistoricoCambios)
                    .HasForeignKey(d => d.SidRaee)
                    .HasConstraintName("FK_HistoricoCambios_RAEEs");

                entity.HasOne(d => d.SidResiduoEspecificoAntesNavigation)
                    .WithMany(p => p.HistoricoCambiosSidResiduoEspecificoAntesNavigation)
                    .HasForeignKey(d => d.SidResiduoEspecificoAntes)
                    .HasConstraintName("FK_HistoricoCambios_ResiduosEspecificosAntes");

                entity.HasOne(d => d.SidResiduoEspecificoDespuesNavigation)
                    .WithMany(p => p.HistoricoCambiosSidResiduoEspecificoDespuesNavigation)
                    .HasForeignKey(d => d.SidResiduoEspecificoDespues)
                    .HasConstraintName("FK_HistoricoCambios_ResiduosEspecificosDespues");

                entity.HasOne(d => d.SidTipoDeContenedorAntesNavigation)
                    .WithMany(p => p.HistoricoCambiosSidTipoDeContenedorAntesNavigation)
                    .HasForeignKey(d => d.SidTipoDeContenedorAntes)
                    .HasConstraintName("FK_HistoricoCambios_TiposContenedorAntes");

                entity.HasOne(d => d.SidTipoDeContenedorDespuesNavigation)
                    .WithMany(p => p.HistoricoCambiosSidTipoDeContenedorDespuesNavigation)
                    .HasForeignKey(d => d.SidTipoDeContenedorDespues)
                    .HasConstraintName("FK_HistoricoCambios_TiposContenedorDespues");
            });

            modelBuilder.Entity<HistoricoCambiosCertificados>(entity =>
            {
                entity.HasKey(e => e.PidHistoricoCambioCertificado);

                entity.Property(e => e.PidHistoricoCambioCertificado).HasColumnName("pidHistoricoCambioCertificado");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.SidCertificado)
                    .HasColumnName("sidCertificado")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SidEstadoAntes).HasColumnName("sidEstadoAntes");

                entity.Property(e => e.SidEstadoDespues).HasColumnName("sidEstadoDespues");

                entity.HasOne(d => d.SidCertificadoNavigation)
                    .WithMany(p => p.HistoricoCambiosCertificados)
                    .HasForeignKey(d => d.SidCertificado)
                    .HasConstraintName("FK_HistoricoCambiosCertificados_Certificados");

                entity.HasOne(d => d.SidEstadoAntesNavigation)
                    .WithMany(p => p.HistoricoCambiosCertificadosSidEstadoAntesNavigation)
                    .HasForeignKey(d => d.SidEstadoAntes)
                    .HasConstraintName("FK_HistoricoCambiosCertificados_EstadosCertificado_ANTES");

                entity.HasOne(d => d.SidEstadoDespuesNavigation)
                    .WithMany(p => p.HistoricoCambiosCertificadosSidEstadoDespuesNavigation)
                    .HasForeignKey(d => d.SidEstadoDespues)
                    .HasConstraintName("FK_HistoricoCambiosCertificados_EstadosCertificado_DESPUES");
            });

            modelBuilder.Entity<HistoricoCambiosTiposCertificado>(entity =>
            {
                entity.HasKey(e => e.PidCambioTipoCertificado);

                entity.Property(e => e.PidCambioTipoCertificado).HasColumnName("pidCambioTipoCertificado");

                entity.Property(e => e.AnteriorCertificado)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.NuevoCertificado)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HistoricoPesadas>(entity =>
            {
                entity.HasKey(e => e.PidPesada);

                entity.Property(e => e.PidPesada).HasColumnName("pidPesada");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.Peso).HasColumnName("peso");

                entity.Property(e => e.SidCertificado)
                    .IsRequired()
                    .HasColumnName("sidCertificado")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SidCertificadoSubordinado)
                    .HasColumnName("sidCertificadoSubordinado")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SidDireccion).HasColumnName("sidDireccion");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.HasOne(d => d.SidDireccionNavigation)
                    .WithMany(p => p.HistoricoPesadas)
                    .HasForeignKey(d => d.SidDireccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HistoricoPesadas_DireccionesTercero");

                entity.HasOne(d => d.SidFraccionNavigation)
                    .WithMany(p => p.HistoricoPesadas)
                    .HasForeignKey(d => d.SidFraccion)
                    .HasConstraintName("FK_HistoricoPesadas_Fracciones");

                entity.HasOne(d => d.SidTerceroNavigation)
                    .WithMany(p => p.HistoricoPesadas)
                    .HasForeignKey(d => d.SidTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HistoricoPesadas_Terceros");
            });

            modelBuilder.Entity<HistoricoPesosRaee>(entity =>
            {
                entity.HasKey(e => e.PidHistorico);

                entity.ToTable("HistoricoPesosRAEE");

                entity.Property(e => e.PidHistorico).HasColumnName("pidHistorico");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.Peso).HasColumnName("peso");

                entity.Property(e => e.SidCertificado)
                    .IsRequired()
                    .HasColumnName("sidCertificado")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SidRaee)
                    .IsRequired()
                    .HasColumnName("sidRAEE")
                    .HasMaxLength(50);

                entity.HasOne(d => d.SidCertificadoNavigation)
                    .WithMany(p => p.HistoricoPesosRaee)
                    .HasForeignKey(d => d.SidCertificado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HistoricoPesosRAEE_Certificados");

                entity.HasOne(d => d.SidRaeeNavigation)
                    .WithMany(p => p.HistoricoPesosRaee)
                    .HasForeignKey(d => d.SidRaee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HistoricoPesosRAEE_RAEEs");
            });

            modelBuilder.Entity<I49EmisorOrigen>(entity =>
            {
                entity.HasKey(e => new { e.EmisorTercero, e.EmisorDireccion, e.OrigenTercero, e.OrigenDireccion });

                entity.ToTable("i49_EmisorOrigen");
            });

            modelBuilder.Entity<Incidencias>(entity =>
            {
                entity.HasKey(e => e.PidIncidencia);

                entity.HasIndex(e => e.Fecha)
                    .HasName("IX_FECHA");

                entity.HasIndex(e => e.SidCertificado)
                    .HasName("IX_CERTIFICADO");

                entity.HasIndex(e => e.SidRaee)
                    .HasName("IX_RAEE");

                entity.HasIndex(e => e.SidTercero)
                    .HasName("IX_TERCERO");

                entity.HasIndex(e => new { e.Fecha, e.SidTipoIncidencia })
                    .HasName("IX_FECHA_TIPO");

                entity.Property(e => e.PidIncidencia)
                    .HasColumnName("pidIncidencia")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCambioEstado)
                    .HasColumnName("fechaCambioEstado")
                    .HasColumnType("datetime");

                entity.Property(e => e.SidCertificado)
                    .HasColumnName("sidCertificado")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SidEstadoIncidencia).HasColumnName("sidEstadoIncidencia");

                entity.Property(e => e.SidRaee)
                    .HasColumnName("sidRAEE")
                    .HasMaxLength(50);

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SidTipoIncidencia).HasColumnName("sidTipoIncidencia");

                entity.HasOne(d => d.SidCertificadoNavigation)
                    .WithMany(p => p.Incidencias)
                    .HasForeignKey(d => d.SidCertificado)
                    .HasConstraintName("FK_Incidencias_Certificados");
            });

            modelBuilder.Entity<IndicadoresDireccionTerceroFraccion>(entity =>
            {
                entity.HasKey(e => e.PidIndicadorDireccionTerceroFraccion);

                entity.HasIndex(e => new { e.Mes, e.Anyo, e.SidDireccionTercero, e.SidFraccion })
                    .HasName("IX_MES_ANIO_DIR_FRA");

                entity.Property(e => e.PidIndicadorDireccionTerceroFraccion).HasColumnName("pidIndicadorDireccionTerceroFraccion");

                entity.Property(e => e.Anyo).HasColumnName("anyo");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.NumRaeeconFoto).HasColumnName("NumRAEEconFoto");

                entity.Property(e => e.NumRaeelecturas).HasColumnName("NumRAEELecturas");

                entity.Property(e => e.NumRaeeperdidos).HasColumnName("NumRAEEPerdidos");

                entity.Property(e => e.NumRaeerecogido).HasColumnName("NumRAEERecogido");

                entity.Property(e => e.NumRaeerecogidoCanibalizado).HasColumnName("NumRAEERecogidoCanibalizado");

                entity.Property(e => e.NumRaeerecogidoInicial).HasColumnName("NumRAEERecogidoInicial");

                entity.Property(e => e.NumRaeetratado).HasColumnName("NumRAEETratado");

                entity.Property(e => e.NumRaeetratadoComoPlanta).HasColumnName("NumRAEETratadoComoPlanta");

                entity.Property(e => e.NumRaeetratadoComoPlantaCanibalizado).HasColumnName("NumRAEETratadoComoPlantaCanibalizado");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SumVidaRaee).HasColumnName("SumVidaRAEE");

                entity.Property(e => e.SumVidaRaeetercero).HasColumnName("SumVidaRAEETercero");

                entity.Property(e => e.SumVidaRaeetratadoComoPlanta).HasColumnName("SumVidaRAEETratadoComoPlanta");

                entity.Property(e => e.Trimestre).HasColumnName("trimestre");

                entity.HasOne(d => d.SidDireccionTerceroNavigation)
                    .WithMany(p => p.IndicadoresDireccionTerceroFraccion)
                    .HasForeignKey(d => d.SidDireccionTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IndicadoresDireccionTerceroFraccion_DireccionesTercero");

                entity.HasOne(d => d.SidFraccionNavigation)
                    .WithMany(p => p.IndicadoresDireccionTerceroFraccion)
                    .HasForeignKey(d => d.SidFraccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IndicadoresDireccionTerceroFraccion_Fracciones");
            });

            modelBuilder.Entity<InformeCicloVida>(entity =>
            {
                entity.HasKey(e => e.PidInformeCicloVida);

                entity.Property(e => e.PidInformeCicloVida).HasColumnName("pidInformeCicloVida");

                entity.Property(e => e.CerTratCcaaTratamiento)
                    .HasColumnName("CerTrat_CCAA_Tratamiento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CerTratDireccionGestor)
                    .HasColumnName("CerTrat_DireccionGestor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CerTratFecha)
                    .HasColumnName("CerTrat_Fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.CerTratGestor)
                    .HasColumnName("CerTrat_Gestor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CerTratMunicipioTratamiento)
                    .HasColumnName("CerTrat_Municipio_Tratamiento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CerTratProvTratamiento)
                    .HasColumnName("CerTrat_Prov_Tratamiento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CerTratSidDireccionGestor).HasColumnName("CerTrat_sidDireccionGestor");

                entity.Property(e => e.CerTratSidGestor).HasColumnName("CerTrat_sidGestor");

                entity.Property(e => e.CerTratSidTipoLectura).HasColumnName("CerTrat_sidTipoLectura");

                entity.Property(e => e.CerTratTipo)
                    .HasColumnName("CerTrat_Tipo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CerTratVideo).HasColumnName("CerTrat_Video");

                entity.Property(e => e.CerTratYear).HasColumnName("CerTrat_YEAR");

                entity.Property(e => e.DiasIdentificacionTorecogRecept).HasColumnName("DiasIdentificacionTORecogRecept");

                entity.Property(e => e.DiasRecogReceptTotratamiento).HasColumnName("DiasRecogReceptTOTratamiento");

                entity.Property(e => e.FechaInforme).HasColumnType("datetime");

                entity.Property(e => e.NcerEntre).HasColumnName("NCer_Entre");

                entity.Property(e => e.NcerIdent).HasColumnName("NCer_Ident");

                entity.Property(e => e.NcerRecep).HasColumnName("NCer_Recep");

                entity.Property(e => e.NcerRecog).HasColumnName("NCer_Recog");

                entity.Property(e => e.NcerTrata).HasColumnName("NCer_Trata");

                entity.Property(e => e.PcCcaaOrigen)
                    .HasColumnName("PC_CCAA_Origen")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcDirOrigen)
                    .HasColumnName("PC_Dir_Origen")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcMunicipioOrigen)
                    .HasColumnName("PC_Municipio_Origen")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcNcer)
                    .HasColumnName("PC_NCer")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PcNcerGvr)
                    .HasColumnName("PC_NCerGVR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcProvOrigen)
                    .HasColumnName("PC_Prov_Origen")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcSidDirOrigen).HasColumnName("PC_sidDir_Origen");

                entity.Property(e => e.PcSidTerOrigen).HasColumnName("PC_sidTer_Origen");

                entity.Property(e => e.PcTerOrigen)
                    .HasColumnName("PC_Ter_Origen")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Pcident)
                    .HasColumnName("PCIdent")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PcidentCcaaEmisor)
                    .HasColumnName("PCIdent_CCAA_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcidentDirEmisor)
                    .HasColumnName("PCIdent_DirEmisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcidentEmisor)
                    .HasColumnName("PCIdent_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcidentFecha)
                    .HasColumnName("PCIdent_Fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.PcidentMunicipioEmisor)
                    .HasColumnName("PCIdent_Municipio_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcidentNcerGvr)
                    .HasColumnName("PCIdent_NCerGVR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcidentProvEmisor)
                    .HasColumnName("PCIdent_Prov_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcidentSidDirEmisor).HasColumnName("PCIdent_sidDirEmisor");

                entity.Property(e => e.PcidentSidEmisor).HasColumnName("PCIdent_sidEmisor");

                entity.Property(e => e.PcrcRda)
                    .HasColumnName("PCRcRda")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PcrcRdaAlbaranOrigen)
                    .HasColumnName("PCRcRda_AlbaranOrigen")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcrcRdaCcaaEmisor)
                    .HasColumnName("PCRcRda_CCAA_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcrcRdaCcaaOrigen)
                    .HasColumnName("PCRcRda_CCAA_Origen")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcrcRdaDirEmisor)
                    .HasColumnName("PCRcRda_DirEmisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcrcRdaDirOrigen)
                    .HasColumnName("PCRcRda_DirOrigen")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcrcRdaEmisor)
                    .HasColumnName("PCRcRda_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcrcRdaFecha)
                    .HasColumnName("PCRcRda_Fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.PcrcRdaMunicipioEmisor)
                    .HasColumnName("PCRcRda_Municipio_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcrcRdaMunicipioOrigen)
                    .HasColumnName("PCRcRda_Municipio_Origen")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcrcRdaNcerGvr)
                    .HasColumnName("PCRcRda_NCerGVR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcrcRdaProvEmisor)
                    .HasColumnName("PCRcRda_Prov_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcrcRdaProvOrigen)
                    .HasColumnName("PCRcRda_Prov_Origen")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcrcRdaSidDirEmisor).HasColumnName("PCRcRda_sidDirEmisor");

                entity.Property(e => e.PcrcRdaSidDirOrigen).HasColumnName("PCRcRda_sidDirOrigen");

                entity.Property(e => e.PcrcRdaSidEmisor).HasColumnName("PCRcRda_sidEmisor");

                entity.Property(e => e.PcrcRdaSidTerOrigen).HasColumnName("PCRcRda_sidTerOrigen");

                entity.Property(e => e.PcrcRdaTerOrigen)
                    .HasColumnName("PCRcRda_TerOrigen")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Raee)
                    .HasColumnName("RAEE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RaeeDestino)
                    .HasColumnName("RAEE_Destino")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RaeeDireccionGestorActual)
                    .HasColumnName("RAEE_DireccionGestorActual")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RaeeEcotrazo)
                    .HasColumnName("RAEE_Ecotrazo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RaeeEstadoRaee)
                    .HasColumnName("RAEE_EstadoRAEE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RaeeFraccion)
                    .HasColumnName("RAEE_Fraccion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RaeeGestorActual)
                    .HasColumnName("RAEE_GestorActual")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RaeeMarca)
                    .HasColumnName("RAEE_Marca")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RaeePesoEstimado).HasColumnName("RAEE_pesoEstimado");

                entity.Property(e => e.RaeePesoReal).HasColumnName("RAEE_pesoReal");

                entity.Property(e => e.RaeeResiduo)
                    .HasColumnName("RAEE_Residuo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RaeeResiduoEspecifico)
                    .HasColumnName("RAEE_ResiduoEspecifico")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RaeeSerie)
                    .HasColumnName("RAEE_Serie")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RaeeSidDireccionGestorActual).HasColumnName("RAEE_sidDireccionGestorActual");

                entity.Property(e => e.RaeeSidEstadoRaee).HasColumnName("RAEE_sidEstadoRAEE");

                entity.Property(e => e.RaeeSidFraccion).HasColumnName("RAEE_sidFraccion");

                entity.Property(e => e.RaeeSidGestorActual).HasColumnName("RAEE_sidGestorActual");

                entity.Property(e => e.RaeeSidResiduo).HasColumnName("RAEE_sidResiduo");

                entity.Property(e => e.RaeeSidResiduoEspecifico).HasColumnName("RAEE_sidResiduoEspecifico");

                entity.Property(e => e.UcCcaaEmisor)
                    .HasColumnName("UC_CCAA_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UcDirEmisor)
                    .HasColumnName("UC_Dir_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UcMunicipioEmisor)
                    .HasColumnName("UC_Municipio_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UcNcer)
                    .HasColumnName("UC_NCer")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UcNcerGvr)
                    .HasColumnName("UC_NCerGVR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UcProvEmisor)
                    .HasColumnName("UC_Prov_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UcSidDirEmisor).HasColumnName("UC_sidDir_Emisor");

                entity.Property(e => e.UcSidTerEmisor).HasColumnName("UC_sidTer_Emisor");

                entity.Property(e => e.UcTerEmisor)
                    .HasColumnName("UC_Ter_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UcrcRda)
                    .HasColumnName("UCRcRda")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UcrcRdaCcaaEmisor)
                    .HasColumnName("UCRcRda_CCAA_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UcrcRdaDirEmisor)
                    .HasColumnName("UCRcRda_DirEmisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UcrcRdaEmisor)
                    .HasColumnName("UCRcRda_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UcrcRdaFecha)
                    .HasColumnName("UCRcRda_Fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.UcrcRdaMunicipioEmisor)
                    .HasColumnName("UCRcRda_Municipio_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UcrcRdaNcerGvr)
                    .HasColumnName("UCRcRda_NCerGVR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UcrcRdaProvEmisor)
                    .HasColumnName("UCRcRda_Prov_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UcrcRdaSidDirEmisor).HasColumnName("UCRcRda_sidDirEmisor");

                entity.Property(e => e.UcrcRdaSidEmisor).HasColumnName("UCRcRda_sidEmisor");
            });

            modelBuilder.Entity<InformeCicloVidaFiltrado>(entity =>
            {
                entity.HasKey(e => e.PidInformeCicloVida);

                entity.ToTable("InformeCicloVida_Filtrado");

                entity.Property(e => e.PidInformeCicloVida).HasColumnName("pidInformeCicloVida");

                entity.Property(e => e.CerTratCcaaTratamiento)
                    .HasColumnName("CerTrat_CCAA_Tratamiento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CerTratDireccionGestor)
                    .HasColumnName("CerTrat_DireccionGestor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CerTratFecha)
                    .HasColumnName("CerTrat_Fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.CerTratGestor)
                    .HasColumnName("CerTrat_Gestor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CerTratMunicipioTratamiento)
                    .HasColumnName("CerTrat_Municipio_Tratamiento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CerTratProvTratamiento)
                    .HasColumnName("CerTrat_Prov_Tratamiento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CerTratSidDireccionGestor).HasColumnName("CerTrat_sidDireccionGestor");

                entity.Property(e => e.CerTratSidGestor).HasColumnName("CerTrat_sidGestor");

                entity.Property(e => e.CerTratSidTipoLectura).HasColumnName("CerTrat_sidTipoLectura");

                entity.Property(e => e.CerTratTipo)
                    .HasColumnName("CerTrat_Tipo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CerTratVideo).HasColumnName("CerTrat_Video");

                entity.Property(e => e.CerTratYear).HasColumnName("CerTrat_YEAR");

                entity.Property(e => e.DiasIdentificacionTorecogRecept).HasColumnName("DiasIdentificacionTORecogRecept");

                entity.Property(e => e.DiasRecogReceptTotratamiento).HasColumnName("DiasRecogReceptTOTratamiento");

                entity.Property(e => e.FechaInforme).HasColumnType("datetime");

                entity.Property(e => e.NcerEntre).HasColumnName("NCer_Entre");

                entity.Property(e => e.NcerIdent).HasColumnName("NCer_Ident");

                entity.Property(e => e.NcerRecep).HasColumnName("NCer_Recep");

                entity.Property(e => e.NcerRecog).HasColumnName("NCer_Recog");

                entity.Property(e => e.NcerTrata).HasColumnName("NCer_Trata");

                entity.Property(e => e.PcCcaaOrigen)
                    .HasColumnName("PC_CCAA_Origen")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcDirOrigen)
                    .HasColumnName("PC_Dir_Origen")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcMunicipioOrigen)
                    .HasColumnName("PC_Municipio_Origen")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcNcer)
                    .HasColumnName("PC_NCer")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PcNcerGvr)
                    .HasColumnName("PC_NCerGVR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcProvOrigen)
                    .HasColumnName("PC_Prov_Origen")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcSidDirOrigen).HasColumnName("PC_sidDir_Origen");

                entity.Property(e => e.PcSidTerOrigen).HasColumnName("PC_sidTer_Origen");

                entity.Property(e => e.PcTerOrigen)
                    .HasColumnName("PC_Ter_Origen")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Pcident)
                    .HasColumnName("PCIdent")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PcidentCcaaEmisor)
                    .HasColumnName("PCIdent_CCAA_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcidentDirEmisor)
                    .HasColumnName("PCIdent_DirEmisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcidentEmisor)
                    .HasColumnName("PCIdent_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcidentFecha)
                    .HasColumnName("PCIdent_Fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.PcidentMunicipioEmisor)
                    .HasColumnName("PCIdent_Municipio_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcidentNcerGvr)
                    .HasColumnName("PCIdent_NCerGVR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcidentProvEmisor)
                    .HasColumnName("PCIdent_Prov_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcidentSidDirEmisor).HasColumnName("PCIdent_sidDirEmisor");

                entity.Property(e => e.PcidentSidEmisor).HasColumnName("PCIdent_sidEmisor");

                entity.Property(e => e.PcrcRda)
                    .HasColumnName("PCRcRda")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PcrcRdaAlbaranOrigen)
                    .HasColumnName("PCRcRda_AlbaranOrigen")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcrcRdaCcaaEmisor)
                    .HasColumnName("PCRcRda_CCAA_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcrcRdaCcaaOrigen)
                    .HasColumnName("PCRcRda_CCAA_Origen")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcrcRdaDirEmisor)
                    .HasColumnName("PCRcRda_DirEmisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcrcRdaDirOrigen)
                    .HasColumnName("PCRcRda_DirOrigen")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcrcRdaEmisor)
                    .HasColumnName("PCRcRda_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcrcRdaFecha)
                    .HasColumnName("PCRcRda_Fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.PcrcRdaMunicipioEmisor)
                    .HasColumnName("PCRcRda_Municipio_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcrcRdaMunicipioOrigen)
                    .HasColumnName("PCRcRda_Municipio_Origen")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcrcRdaNcerGvr)
                    .HasColumnName("PCRcRda_NCerGVR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcrcRdaProvEmisor)
                    .HasColumnName("PCRcRda_Prov_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcrcRdaProvOrigen)
                    .HasColumnName("PCRcRda_Prov_Origen")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PcrcRdaSidDirEmisor).HasColumnName("PCRcRda_sidDirEmisor");

                entity.Property(e => e.PcrcRdaSidDirOrigen).HasColumnName("PCRcRda_sidDirOrigen");

                entity.Property(e => e.PcrcRdaSidEmisor).HasColumnName("PCRcRda_sidEmisor");

                entity.Property(e => e.PcrcRdaSidTerOrigen).HasColumnName("PCRcRda_sidTerOrigen");

                entity.Property(e => e.PcrcRdaTerOrigen)
                    .HasColumnName("PCRcRda_TerOrigen")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Raee)
                    .HasColumnName("RAEE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RaeeDestino)
                    .HasColumnName("RAEE_Destino")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RaeeDireccionGestorActual)
                    .HasColumnName("RAEE_DireccionGestorActual")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RaeeEcotrazo)
                    .HasColumnName("RAEE_Ecotrazo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RaeeEstadoRaee)
                    .HasColumnName("RAEE_EstadoRAEE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RaeeFraccion)
                    .HasColumnName("RAEE_Fraccion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RaeeGestorActual)
                    .HasColumnName("RAEE_GestorActual")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RaeeMarca)
                    .HasColumnName("RAEE_Marca")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RaeePesoEstimado).HasColumnName("RAEE_pesoEstimado");

                entity.Property(e => e.RaeePesoReal).HasColumnName("RAEE_pesoReal");

                entity.Property(e => e.RaeeResiduo)
                    .HasColumnName("RAEE_Residuo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RaeeResiduoEspecifico)
                    .HasColumnName("RAEE_ResiduoEspecifico")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RaeeSerie)
                    .HasColumnName("RAEE_Serie")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RaeeSidDireccionGestorActual).HasColumnName("RAEE_sidDireccionGestorActual");

                entity.Property(e => e.RaeeSidEstadoRaee).HasColumnName("RAEE_sidEstadoRAEE");

                entity.Property(e => e.RaeeSidFraccion).HasColumnName("RAEE_sidFraccion");

                entity.Property(e => e.RaeeSidGestorActual).HasColumnName("RAEE_sidGestorActual");

                entity.Property(e => e.RaeeSidResiduo).HasColumnName("RAEE_sidResiduo");

                entity.Property(e => e.RaeeSidResiduoEspecifico).HasColumnName("RAEE_sidResiduoEspecifico");

                entity.Property(e => e.UcCcaaEmisor)
                    .HasColumnName("UC_CCAA_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UcDirEmisor)
                    .HasColumnName("UC_Dir_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UcMunicipioEmisor)
                    .HasColumnName("UC_Municipio_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UcNcer)
                    .HasColumnName("UC_NCer")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UcNcerGvr)
                    .HasColumnName("UC_NCerGVR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UcProvEmisor)
                    .HasColumnName("UC_Prov_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UcSidDirEmisor).HasColumnName("UC_sidDir_Emisor");

                entity.Property(e => e.UcSidTerEmisor).HasColumnName("UC_sidTer_Emisor");

                entity.Property(e => e.UcTerEmisor)
                    .HasColumnName("UC_Ter_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UcrcRda)
                    .HasColumnName("UCRcRda")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UcrcRdaCcaaEmisor)
                    .HasColumnName("UCRcRda_CCAA_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UcrcRdaDirEmisor)
                    .HasColumnName("UCRcRda_DirEmisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UcrcRdaEmisor)
                    .HasColumnName("UCRcRda_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UcrcRdaFecha)
                    .HasColumnName("UCRcRda_Fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.UcrcRdaMunicipioEmisor)
                    .HasColumnName("UCRcRda_Municipio_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UcrcRdaNcerGvr)
                    .HasColumnName("UCRcRda_NCerGVR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UcrcRdaProvEmisor)
                    .HasColumnName("UCRcRda_Prov_Emisor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UcrcRdaSidDirEmisor).HasColumnName("UCRcRda_sidDirEmisor");

                entity.Property(e => e.UcrcRdaSidEmisor).HasColumnName("UCRcRda_sidEmisor");
            });

            modelBuilder.Entity<Informes>(entity =>
            {
                entity.HasKey(e => e.PidInforme);

                entity.Property(e => e.PidInforme).HasColumnName("pidInforme");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ruta)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Server)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo).HasDefaultValueSql("((1))");

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InventariosFisicos>(entity =>
            {
                entity.HasKey(e => e.PidInventarioFisico);

                entity.Property(e => e.PidInventarioFisico)
                    .HasColumnName("pidInventarioFisico")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Auditor).HasColumnName("auditor");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.HasOne(d => d.SidDireccionTerceroNavigation)
                    .WithMany(p => p.InventariosFisicos)
                    .HasForeignKey(d => d.SidDireccionTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventariosFisicos_DireccionesTercero");

                entity.HasOne(d => d.SidTerceroNavigation)
                    .WithMany(p => p.InventariosFisicos)
                    .HasForeignKey(d => d.SidTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventariosFisicos_Terceros");
            });

            modelBuilder.Entity<InventariosFisicosRaees>(entity =>
            {
                entity.HasKey(e => e.PidInventarioFisicoRaee);

                entity.ToTable("InventariosFisicosRAEEs");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_502552053")
                    .IsUnique();

                entity.Property(e => e.PidInventarioFisicoRaee)
                    .HasColumnName("pidInventarioFisicoRAEE")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidInventarioFisico)
                    .IsRequired()
                    .HasColumnName("sidInventarioFisico")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.SidRaee)
                    .IsRequired()
                    .HasColumnName("sidRAEE")
                    .HasMaxLength(50);

                entity.HasOne(d => d.SidInventarioFisicoNavigation)
                    .WithMany(p => p.InventariosFisicosRaees)
                    .HasForeignKey(d => d.SidInventarioFisico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventariosFisicosRAEEs_InventariosFisicos");
            });

            modelBuilder.Entity<LksJobsCompletarCertificadosIndentificacionTerceros>(entity =>
            {
                entity.HasKey(e => e.SidTercero);

                entity.ToTable("LKS_Jobs_Completar_Certificados_Indentificacion_Terceros");

                entity.Property(e => e.SidTercero)
                    .HasColumnName("sidTercero")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<LksRaeesProblemaEtiquetas>(entity =>
            {
                entity.HasKey(e => e.OldRaee);

                entity.ToTable("LKS_RAEEs_PROBLEMA_ETIQUETAS");

                entity.HasIndex(e => new { e.OldRaee, e.NewRaee })
                    .HasName("IX_INDICE")
                    .IsUnique();

                entity.Property(e => e.OldRaee)
                    .HasColumnName("old_RAEE")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.NewRaee)
                    .IsRequired()
                    .HasColumnName("new_RAEE")
                    .HasMaxLength(50);

                entity.Property(e => e.Pass)
                    .HasColumnName("pass")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<LksTratarRaeesFormaManual>(entity =>
            {
                entity.HasKey(e => e.Raee);

                entity.ToTable("LKS_Tratar_RAEES_FormaManual");

                entity.Property(e => e.Raee)
                    .HasColumnName("RAEE")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<LogEventoPortal>(entity =>
            {
                entity.HasKey(e => e.PidLogEventoPortal);

                entity.HasIndex(e => e.EntidadAfectada)
                    .HasName("IX_ENTIDADAFECTADA");

                entity.HasIndex(e => e.Fecha)
                    .HasName("IX_FECHA");

                entity.Property(e => e.PidLogEventoPortal).HasColumnName("pidLogEventoPortal");

                entity.Property(e => e.Detalles).HasColumnName("detalles");

                entity.Property(e => e.EntidadAfectada)
                    .HasColumnName("entidadAfectada")
                    .HasMaxLength(50);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.Proceso)
                    .IsRequired()
                    .HasColumnName("proceso")
                    .HasMaxLength(50);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnName("usuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogRepartoPesadas>(entity =>
            {
                entity.HasKey(e => e.PidLogRepartoPesadas);

                entity.Property(e => e.PidLogRepartoPesadas).HasColumnName("pidLogRepartoPesadas");

                entity.Property(e => e.Evento)
                    .IsRequired()
                    .HasColumnName("evento");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.Proceso)
                    .IsRequired()
                    .HasColumnName("proceso")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Marcas>(entity =>
            {
                entity.HasKey(e => e.PidMarca);

                entity.HasIndex(e => e.Activa)
                    .HasName("Estado_Marcas");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_2059154381")
                    .IsUnique();

                entity.Property(e => e.PidMarca)
                    .HasColumnName("pidMarca")
                    .ValueGeneratedNever();

                entity.Property(e => e.Activa).HasColumnName("activa");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<Municipios>(entity =>
            {
                entity.HasKey(e => e.PidMunicipio);

                entity.HasIndex(e => e.Estado)
                    .HasName("Estado_Municipios");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_995793834")
                    .IsUnique();

                entity.Property(e => e.PidMunicipio)
                    .HasColumnName("pidMunicipio")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodGtr).HasColumnName("codGTR");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidProvincia).HasColumnName("sidProvincia");

                entity.HasOne(d => d.SidProvinciaNavigation)
                    .WithMany(p => p.Municipios)
                    .HasForeignKey(d => d.SidProvincia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Municipios_Provincias");
            });

            modelBuilder.Entity<ObservacionesIncidencia>(entity =>
            {
                entity.HasKey(e => e.PidObservacionIncidencia);

                entity.Property(e => e.PidObservacionIncidencia).HasColumnName("pidObservacionIncidencia");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.SidIncidencia)
                    .IsRequired()
                    .HasColumnName("sidIncidencia")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.SidUsuario).HasColumnName("sidUsuario");

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasColumnName("texto")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ObservacionesRaee>(entity =>
            {
                entity.HasKey(e => e.PidObservacionRaee);

                entity.ToTable("ObservacionesRAEE");

                entity.Property(e => e.PidObservacionRaee).HasColumnName("pidObservacionRAEE");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.SidRaee)
                    .IsRequired()
                    .HasColumnName("sidRAEE")
                    .HasMaxLength(50);

                entity.Property(e => e.SidUsuario).HasColumnName("sidUsuario");

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasColumnName("texto")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Paises>(entity =>
            {
                entity.HasKey(e => e.PidPais);

                entity.HasIndex(e => e.Estado)
                    .HasName("Estado_Paises");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_1731796456")
                    .IsUnique();

                entity.Property(e => e.PidPais).HasColumnName("pidPais");

                entity.Property(e => e.CodGtr).HasColumnName("codGTR");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("codigo")
                    .HasMaxLength(3);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<PaisesCodigoRaee>(entity =>
            {
                entity.HasKey(e => e.PidPaisCodigoRaee);

                entity.ToTable("PaisesCodigoRAEE");

                entity.Property(e => e.PidPaisCodigoRaee)
                    .HasColumnName("pidPaisCodigoRAEE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ParametrosGlobales>(entity =>
            {
                entity.HasKey(e => e.PidParametroGlobal);

                entity.HasIndex(e => e.Estado)
                    .HasName("Estado_ParametrosGlobales");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_945438442")
                    .IsUnique();

                entity.Property(e => e.PidParametroGlobal).HasColumnName("pidParametroGlobal");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("codigo")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasColumnName("valor")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Permisos>(entity =>
            {
                entity.HasKey(e => e.PidPermiso);

                entity.Property(e => e.PidPermiso).HasColumnName("pidPermiso");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("codigo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pesadas>(entity =>
            {
                entity.HasKey(e => e.PidPesada);

                entity.Property(e => e.PidPesada).HasColumnName("pidPesada");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.Peso).HasColumnName("peso");

                entity.Property(e => e.SidCertificado)
                    .IsRequired()
                    .HasColumnName("sidCertificado")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SidCertificadoSubordinado)
                    .HasColumnName("sidCertificadoSubordinado")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SidDireccion).HasColumnName("sidDireccion");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.HasOne(d => d.SidCertificadoNavigation)
                    .WithMany(p => p.Pesadas)
                    .HasForeignKey(d => d.SidCertificado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pesadas_Certificados");

                entity.HasOne(d => d.SidDireccionNavigation)
                    .WithMany(p => p.Pesadas)
                    .HasForeignKey(d => d.SidDireccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pesadas_DireccionesTercero");

                entity.HasOne(d => d.SidFraccionNavigation)
                    .WithMany(p => p.Pesadas)
                    .HasForeignKey(d => d.SidFraccion)
                    .HasConstraintName("FK_Pesadas_Fracciones");

                entity.HasOne(d => d.SidTerceroNavigation)
                    .WithMany(p => p.Pesadas)
                    .HasForeignKey(d => d.SidTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pesadas_Terceros");
            });

            modelBuilder.Entity<PesosEnviados>(entity =>
            {
                entity.HasKey(e => e.PidCertificado);

                entity.Property(e => e.PidCertificado)
                    .HasColumnName("pidCertificado")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Provincias>(entity =>
            {
                entity.HasKey(e => e.PidProvincia);

                entity.HasIndex(e => e.Estado)
                    .HasName("Estado_Provincias");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_1875796969")
                    .IsUnique();

                entity.Property(e => e.PidProvincia)
                    .HasColumnName("pidProvincia")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodGtr).HasColumnName("codGTR");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidPais).HasColumnName("sidPais");

                entity.HasOne(d => d.SidPaisNavigation)
                    .WithMany(p => p.Provincias)
                    .HasForeignKey(d => d.SidPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Provincias_Paises");
            });

            modelBuilder.Entity<Raees>(entity =>
            {
                entity.HasKey(e => e.PidRaee);

                entity.ToTable("RAEEs");

                entity.HasIndex(e => e.Estado)
                    .HasName("IX_ANULADO");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_790553079")
                    .IsUnique();

                entity.HasIndex(e => e.SidCertificadoTratamiento)
                    .HasName("IX_CERT_TRATA");

                entity.HasIndex(e => e.SidEstadoRaee)
                    .HasName("IX_ESTADO");

                entity.HasIndex(e => e.SidFraccion)
                    .HasName("IX_FRACC");

                entity.HasIndex(e => e.SidResiduo)
                    .HasName("IX_RES");

                entity.HasIndex(e => e.SidResiduoEspecifico)
                    .HasName("IX_RES_ESP");

                entity.HasIndex(e => new { e.PidRaee, e.SidCertificadoTratamiento })
                    .HasName("IX_RAEE_TRAT");

                entity.HasIndex(e => new { e.SidEstadoRaee, e.Estado })
                    .HasName("Estado_RAEEs");

                entity.HasIndex(e => new { e.SidEstadoRaee, e.SidCertificadoTratamiento })
                    .HasName("IX_ESTADO_TRATA");

                entity.HasIndex(e => new { e.PidRaee, e.SidEstadoRaee, e.SidCertificadoTratamiento })
                    .HasName("IX_TRATAMIENTO")
                    .IsUnique();

                entity.HasIndex(e => new { e.SidResiduoEspecifico, e.SidTipoContenedor, e.SidEstadoRaee, e.SidCertificadoTratamiento, e.SidFraccion })
                    .HasName("IX_GENERAL");

                entity.Property(e => e.PidRaee)
                    .HasColumnName("pidRAEE")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Canibalizado).HasColumnName("canibalizado");

                entity.Property(e => e.CodigoRefTercero)
                    .HasColumnName("codigoRefTercero")
                    .HasMaxLength(15);

                entity.Property(e => e.Destino)
                    .HasColumnName("destino")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PesoEstimado).HasColumnName("pesoEstimado");

                entity.Property(e => e.PesoReal).HasColumnName("pesoReal");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Serie)
                    .HasColumnName("serie")
                    .HasMaxLength(50);

                entity.Property(e => e.SidCertificadoTratamiento).HasColumnName("sidCertificadoTratamiento");

                entity.Property(e => e.SidEstadoRaee).HasColumnName("sidEstadoRAEE");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidMarca).HasColumnName("sidMarca");

                entity.Property(e => e.SidPaisCodigoRaee).HasColumnName("sidPaisCodigoRAEE");

                entity.Property(e => e.SidResiduo).HasColumnName("sidResiduo");

                entity.Property(e => e.SidResiduoEspecifico).HasColumnName("sidResiduoEspecifico");

                entity.Property(e => e.SidSig).HasColumnName("sidSIG");

                entity.Property(e => e.SidTipoContenedor).HasColumnName("sidTipoContenedor");

                entity.Property(e => e.SidTipoEtiqueta).HasColumnName("sidTipoEtiqueta");

                entity.HasOne(d => d.DestinoNavigation)
                    .WithMany(p => p.Raees)
                    .HasForeignKey(d => d.Destino)
                    .HasConstraintName("FK_RAEEs_TiposDestino");

                entity.HasOne(d => d.SidCertificadoTratamientoNavigation)
                    .WithMany(p => p.Raees)
                    .HasForeignKey(d => d.SidCertificadoTratamiento)
                    .HasConstraintName("FK_RAEEs_CertificadosTratamiento");

                entity.HasOne(d => d.SidEstadoRaeeNavigation)
                    .WithMany(p => p.Raees)
                    .HasForeignKey(d => d.SidEstadoRaee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RAEEs_EstadosRAEE");

                entity.HasOne(d => d.SidFraccionNavigation)
                    .WithMany(p => p.Raees)
                    .HasForeignKey(d => d.SidFraccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RAEEs_Fracciones");

                entity.HasOne(d => d.SidResiduoNavigation)
                    .WithMany(p => p.Raees)
                    .HasForeignKey(d => d.SidResiduo)
                    .HasConstraintName("FK_RAEEs_Residuos");

                entity.HasOne(d => d.SidResiduoEspecificoNavigation)
                    .WithMany(p => p.Raees)
                    .HasForeignKey(d => d.SidResiduoEspecifico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RAEEs_ResiduosEspecificos1");

                entity.HasOne(d => d.SidTipoContenedorNavigation)
                    .WithMany(p => p.Raees)
                    .HasForeignKey(d => d.SidTipoContenedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RAEEs_TiposContenedor");
            });

            modelBuilder.Entity<RaeesAlbaranesEcotrazo>(entity =>
            {
                entity.HasKey(e => e.PidRaeesAlbaranesEcotrazo);

                entity.HasIndex(e => e.AlbaranEcotrazo)
                    .HasName("IX_ECO");

                entity.HasIndex(e => new { e.SidRaee, e.SidCertificado })
                    .HasName("IX_RAEE_CERT");

                entity.Property(e => e.PidRaeesAlbaranesEcotrazo).HasColumnName("pidRaeesAlbaranesEcotrazo");

                entity.Property(e => e.AlbaranEcotrazo)
                    .IsRequired()
                    .HasColumnName("albaranEcotrazo")
                    .HasMaxLength(256);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.SidCertificado)
                    .IsRequired()
                    .HasColumnName("sidCertificado")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SidRaee)
                    .IsRequired()
                    .HasColumnName("sidRaee")
                    .HasMaxLength(50);

                entity.HasOne(d => d.SidCertificadoNavigation)
                    .WithMany(p => p.RaeesAlbaranesEcotrazo)
                    .HasForeignKey(d => d.SidCertificado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RaeesAlbaranesEcotrazo_Certificados");

                entity.HasOne(d => d.SidRaeeNavigation)
                    .WithMany(p => p.RaeesAlbaranesEcotrazo)
                    .HasForeignKey(d => d.SidRaee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RaeesAlbaranesEcotrazo_RAEEs");
            });

            modelBuilder.Entity<RaeesAReutilizar>(entity =>
            {
                entity.HasKey(e => e.Raee);

                entity.ToTable("RAEEs_aReutilizar");

                entity.Property(e => e.Raee)
                    .HasColumnName("RAEE")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.FechaReutilizacion)
                    .HasColumnName("fechaReutilizacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<RaeesCertificados>(entity =>
            {
                entity.HasKey(e => e.PidRaeecertificado);

                entity.ToTable("RAEEsCertificados");

                entity.HasIndex(e => e.SidCertificado)
                    .HasName("IX_CERT");

                entity.HasIndex(e => e.SidRaee)
                    .HasName("IX_RAEE");

                entity.HasIndex(e => new { e.SidCertificado, e.SidRaee })
                    .HasName("IX_GENERAL");

                entity.Property(e => e.PidRaeecertificado)
                    .HasColumnName("pidRAEECertificado")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.GpsX).HasColumnName("gpsX");

                entity.Property(e => e.GpsY).HasColumnName("gpsY");

                entity.Property(e => e.GpsZ).HasColumnName("gpsZ");

                entity.Property(e => e.Peso).HasColumnName("peso");

                entity.Property(e => e.SidCertificado)
                    .IsRequired()
                    .HasColumnName("sidCertificado")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SidRaee)
                    .IsRequired()
                    .HasColumnName("sidRAEE")
                    .HasMaxLength(50);

                entity.Property(e => e.SidTipoDeLectora).HasColumnName("sidTipoDeLectora");

                entity.HasOne(d => d.SidCertificadoNavigation)
                    .WithMany(p => p.RaeesCertificados)
                    .HasForeignKey(d => d.SidCertificado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RAEEsCertificados_Certificados");

                entity.HasOne(d => d.SidRaeeNavigation)
                    .WithMany(p => p.RaeesCertificados)
                    .HasForeignKey(d => d.SidRaee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RAEEsCertificados_RAEEs");
            });

            modelBuilder.Entity<RaeesPrimerCertificado>(entity =>
            {
                entity.HasKey(e => e.SidRaee);

                entity.ToTable("RAEEsPrimerCertificado");

                entity.Property(e => e.SidRaee)
                    .HasColumnName("sidRAEE")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.FechaCertificado).HasColumnType("datetime");

                entity.Property(e => e.SidCertificado)
                    .IsRequired()
                    .HasColumnName("sidCertificado")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RaeesPruebas>(entity =>
            {
                entity.HasKey(e => e.PidRaee);

                entity.ToTable("RAEEsPruebas");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_1034446384")
                    .IsUnique();

                entity.Property(e => e.PidRaee)
                    .HasColumnName("pidRAEE")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Canibalizado).HasColumnName("canibalizado");

                entity.Property(e => e.CodigoRefTercero)
                    .HasColumnName("codigoRefTercero")
                    .HasMaxLength(15);

                entity.Property(e => e.Destino)
                    .HasColumnName("destino")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PesoEstimado).HasColumnName("pesoEstimado");

                entity.Property(e => e.PesoReal).HasColumnName("pesoReal");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Serie)
                    .HasColumnName("serie")
                    .HasMaxLength(50);

                entity.Property(e => e.SidCertificadoTratamiento).HasColumnName("sidCertificadoTratamiento");

                entity.Property(e => e.SidEstadoRaee).HasColumnName("sidEstadoRAEE");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidMarca).HasColumnName("sidMarca");

                entity.Property(e => e.SidPaisCodigoRaee).HasColumnName("sidPaisCodigoRAEE");

                entity.Property(e => e.SidResiduo).HasColumnName("sidResiduo");

                entity.Property(e => e.SidResiduoEspecifico).HasColumnName("sidResiduoEspecifico");

                entity.Property(e => e.SidSig).HasColumnName("sidSIG");

                entity.Property(e => e.SidTipoContenedor).HasColumnName("sidTipoContenedor");

                entity.Property(e => e.SidTipoEtiqueta).HasColumnName("sidTipoEtiqueta");

                entity.HasOne(d => d.DestinoNavigation)
                    .WithMany(p => p.RaeesPruebas)
                    .HasForeignKey(d => d.Destino)
                    .HasConstraintName("FK_RAEEsPruebas_TiposDestino");

                entity.HasOne(d => d.SidCertificadoTratamientoNavigation)
                    .WithMany(p => p.RaeesPruebas)
                    .HasForeignKey(d => d.SidCertificadoTratamiento)
                    .HasConstraintName("FK_RAEEsPruebas_CertificadosTratamiento");

                entity.HasOne(d => d.SidEstadoRaeeNavigation)
                    .WithMany(p => p.RaeesPruebas)
                    .HasForeignKey(d => d.SidEstadoRaee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RAEEsPruebas_EstadosRAEE");

                entity.HasOne(d => d.SidFraccionNavigation)
                    .WithMany(p => p.RaeesPruebas)
                    .HasForeignKey(d => d.SidFraccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RAEEsPruebas_Fracciones");

                entity.HasOne(d => d.SidResiduoNavigation)
                    .WithMany(p => p.RaeesPruebas)
                    .HasForeignKey(d => d.SidResiduo)
                    .HasConstraintName("FK_RAEEsPruebas_Residuos");

                entity.HasOne(d => d.SidResiduoEspecificoNavigation)
                    .WithMany(p => p.RaeesPruebas)
                    .HasForeignKey(d => d.SidResiduoEspecifico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RAEEsPruebas_ResiduosEspecificos1");

                entity.HasOne(d => d.SidTipoContenedorNavigation)
                    .WithMany(p => p.RaeesPruebas)
                    .HasForeignKey(d => d.SidTipoContenedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RAEEsPruebas_TiposContenedor");
            });

            modelBuilder.Entity<RaeesUltimaUbicacion>(entity =>
            {
                entity.HasKey(e => e.Raee);

                entity.ToTable("RAEEs_UltimaUbicacion");

                entity.HasIndex(e => e.Certificado)
                    .HasName("IX_CERTIFICADO");

                entity.HasIndex(e => e.SidDireccionTercero)
                    .HasName("IX_DIRECCION");

                entity.HasIndex(e => e.SidTercero)
                    .HasName("IX_TERCERO");

                entity.HasIndex(e => e.Video)
                    .HasName("IX_VIDEO");

                entity.HasIndex(e => new { e.SidTercero, e.SidDireccionTercero })
                    .HasName("IX_TERCERO_DIRECCION");

                entity.Property(e => e.Raee)
                    .HasColumnName("RAEE")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Certificado)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.Video)
                    .HasColumnName("video")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Remesas>(entity =>
            {
                entity.HasKey(e => e.PidRemesa);

                entity.Property(e => e.PidRemesa).HasColumnName("pidRemesa");

                entity.Property(e => e.CodigoFinRango)
                    .IsRequired()
                    .HasColumnName("codigoFinRango")
                    .HasMaxLength(50);

                entity.Property(e => e.CodigoFinTratado)
                    .IsRequired()
                    .HasColumnName("codigoFinTratado")
                    .HasMaxLength(50);

                entity.Property(e => e.CodigoInicioRango)
                    .IsRequired()
                    .HasColumnName("codigoInicioRango")
                    .HasMaxLength(50);

                entity.Property(e => e.CodigoInicioTratado)
                    .IsRequired()
                    .HasColumnName("codigoInicioTratado")
                    .HasMaxLength(50);

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("fechaEntrega")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReferenciaProducto)
                    .HasColumnName("referenciaProducto")
                    .HasMaxLength(50);

                entity.Property(e => e.ReferenciaRemesa)
                    .HasColumnName("referenciaRemesa")
                    .HasMaxLength(50);

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidEstadoRemesa).HasColumnName("sidEstadoRemesa");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.HasOne(d => d.SidDireccionTerceroNavigation)
                    .WithMany(p => p.Remesas)
                    .HasForeignKey(d => d.SidDireccionTercero)
                    .HasConstraintName("FK_Remesas_DireccionesTercero");

                entity.HasOne(d => d.SidEstadoRemesaNavigation)
                    .WithMany(p => p.Remesas)
                    .HasForeignKey(d => d.SidEstadoRemesa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Remesas_EstadosRemesa");

                entity.HasOne(d => d.SidTerceroNavigation)
                    .WithMany(p => p.Remesas)
                    .HasForeignKey(d => d.SidTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Remesas_Terceros");
            });

            modelBuilder.Entity<Residuos>(entity =>
            {
                entity.HasKey(e => e.PidResiduo);

                entity.HasIndex(e => e.Estado)
                    .HasName("Estado_Residuos");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_1171794461")
                    .IsUnique();

                entity.Property(e => e.PidResiduo)
                    .HasColumnName("pidResiduo")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodGtr).HasColumnName("codGTR");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.HasOne(d => d.SidFraccionNavigation)
                    .WithMany(p => p.Residuos)
                    .HasForeignKey(d => d.SidFraccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Residuos_Fracciones");
            });

            modelBuilder.Entity<ResiduosEspecificos>(entity =>
            {
                entity.HasKey(e => e.PidResiduoEspecifico);

                entity.HasIndex(e => e.Estado)
                    .HasName("Estado_ResiduosEspecificos");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_915793549")
                    .IsUnique();

                entity.Property(e => e.PidResiduoEspecifico)
                    .HasColumnName("pidResiduoEspecifico")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodGtr).HasColumnName("codGTR");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(255);

                entity.Property(e => e.PesoEstimado).HasColumnName("pesoEstimado");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidResiduo).HasColumnName("sidResiduo");

                entity.HasOne(d => d.SidFraccionNavigation)
                    .WithMany(p => p.ResiduosEspecificos)
                    .HasForeignKey(d => d.SidFraccion)
                    .HasConstraintName("FK_ResiduosEspecificos_Fracciones");

                entity.HasOne(d => d.SidResiduoNavigation)
                    .WithMany(p => p.ResiduosEspecificos)
                    .HasForeignKey(d => d.SidResiduo)
                    .HasConstraintName("FK_ResiduosEspecificos_Residuos");
            });

            modelBuilder.Entity<ResponsabilidadesRecogidaEntrega>(entity =>
            {
                entity.HasIndex(e => e.Estado)
                    .HasName("Estado_ResponsabilidadesRecogidaEntrega");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_383651689")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PidResponsabilidadRecogidaEntrega).HasColumnName("pidResponsabilidadRecogidaEntrega");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SidTipoContenedor).HasColumnName("sidTipoContenedor");

                entity.Property(e => e.TipoOperacion)
                    .IsRequired()
                    .HasColumnName("tipoOperacion")
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<ResponsabilidadesTratamiento>(entity =>
            {
                entity.HasIndex(e => e.Estado)
                    .HasName("Estado_ResponsabilidadesTratamiento");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_479652031")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PidResponsabilidadTratamiento).HasColumnName("pidResponsabilidadTratamiento");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidResiduo).HasColumnName("sidResiduo");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SidTipoContenedor).HasColumnName("sidTipoContenedor");

                entity.Property(e => e.TipoOperacion)
                    .IsRequired()
                    .HasColumnName("tipoOperacion")
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.PidRol);

                entity.Property(e => e.PidRol).HasColumnName("pidRol");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RolesPermisos>(entity =>
            {
                entity.HasKey(e => new { e.SidPermiso, e.SidRol })
                    /*.ForSqlServerIsClustered(false)*/;

                entity.HasIndex(e => e.SidRol)
                    .HasName("IX_FK_RolesPermisos_Role");

                entity.HasOne(d => d.SidPermisoNavigation)
                    .WithMany(p => p.RolesPermisos)
                    .HasForeignKey(d => d.SidPermiso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RolesPermisos_Permiso");

                entity.HasOne(d => d.SidRolNavigation)
                    .WithMany(p => p.RolesPermisos)
                    .HasForeignKey(d => d.SidRol)
                    .HasConstraintName("FK_RolesPermisos_Role");
            });

            modelBuilder.Entity<Sigs>(entity =>
            {
                entity.HasKey(e => e.PidSig);

                entity.ToTable("SIGs");

                entity.Property(e => e.PidSig)
                    .HasColumnName("pidSIG")
                    .ValueGeneratedNever();

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Solicitudes>(entity =>
            {
                entity.HasKey(e => e.PidSolicitud);

                entity.HasIndex(e => e.Estado)
                    .HasName("Estado_Solicitudes");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_1075794119")
                    .IsUnique();

                entity.HasIndex(e => e.SidTerceroDestino)
                    .HasName("IX_FK_TercerosSolicitud1");

                entity.HasIndex(e => e.SidTerceroOrigen)
                    .HasName("IX_FK_TercerosSolicitud");

                entity.Property(e => e.PidSolicitud)
                    .HasColumnName("pidSolicitud")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accion)
                    .HasColumnName("accion")
                    .HasMaxLength(255);

                entity.Property(e => e.AlbaranOrigen)
                    .HasColumnName("albaranOrigen")
                    .HasMaxLength(256);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaAnulacion)
                    .HasColumnName("fechaAnulacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.Observaciones).HasMaxLength(255);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidDireccionTerceroDestino).HasColumnName("sidDireccionTerceroDestino");

                entity.Property(e => e.SidDireccionTerceroOrigen).HasColumnName("sidDireccionTerceroOrigen");

                entity.Property(e => e.SidTerceroDestino).HasColumnName("sidTerceroDestino");

                entity.Property(e => e.SidTerceroOrigen).HasColumnName("sidTerceroOrigen");

                entity.HasOne(d => d.SidDireccionTerceroDestinoNavigation)
                    .WithMany(p => p.SolicitudesSidDireccionTerceroDestinoNavigation)
                    .HasForeignKey(d => d.SidDireccionTerceroDestino)
                    .HasConstraintName("DestinoDireccion");

                entity.HasOne(d => d.SidDireccionTerceroOrigenNavigation)
                    .WithMany(p => p.SolicitudesSidDireccionTerceroOrigenNavigation)
                    .HasForeignKey(d => d.SidDireccionTerceroOrigen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("OrigenDireccion");

                entity.HasOne(d => d.SidTerceroDestinoNavigation)
                    .WithMany(p => p.SolicitudesSidTerceroDestinoNavigation)
                    .HasForeignKey(d => d.SidTerceroDestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Destino");

                entity.HasOne(d => d.SidTerceroOrigenNavigation)
                    .WithMany(p => p.SolicitudesSidTerceroOrigenNavigation)
                    .HasForeignKey(d => d.SidTerceroOrigen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Origen");
            });

            modelBuilder.Entity<Terceros>(entity =>
            {
                entity.HasKey(e => e.PidTercero);

                entity.HasIndex(e => e.Estado)
                    .HasName("Estado_Terceros");

                entity.HasIndex(e => e.PidTercero)
                    .HasName("IX_TipoTercero")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_307791383")
                    .IsUnique();

                entity.HasIndex(e => new { e.CodGtr, e.PidTercero })
                    .HasName("IX_GTR_PID")
                    .IsUnique();

                entity.HasIndex(e => new { e.Nombre, e.PidTercero })
                    .HasName("IX_TERCERO")
                    .IsUnique();

                entity.Property(e => e.PidTercero)
                    .HasColumnName("pidTercero")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodGtr).HasColumnName("codGTR");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nif)
                    .IsRequired()
                    .HasColumnName("NIF");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.NombreComercial)
                    .HasColumnName("nombreComercial")
                    .HasMaxLength(255);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.PidTerceroNavigation)
                    .WithOne(p => p.InversePidTerceroNavigation)
                    .HasForeignKey<Terceros>(d => d.PidTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Terceros_Terceros");
            });

            modelBuilder.Entity<TercerosExcluidos>(entity =>
            {
                entity.HasKey(e => e.PidTerceroExcluido);

                entity.Property(e => e.PidTerceroExcluido).HasColumnName("pidTerceroExcluido");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.HasOne(d => d.SidTerceroNavigation)
                    .WithMany(p => p.TercerosExcluidos)
                    .HasForeignKey(d => d.SidTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TercerosExcluidos_TercerosExcluidos");
            });

            modelBuilder.Entity<TercerosReutilizacion2017>(entity =>
            {
                entity.HasKey(e => new { e.SidTercero, e.SidDireccionTercero });

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.FechaTratamientosReutilizar)
                    .HasColumnName("fechaTratamientosReutilizar")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.SidDireccionTerceroNavigation)
                    .WithMany(p => p.TercerosReutilizacion2017)
                    .HasForeignKey(d => d.SidDireccionTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TercerosReutilizacion2017_DireccionesTercero");

                entity.HasOne(d => d.SidTerceroNavigation)
                    .WithMany(p => p.TercerosReutilizacion2017)
                    .HasForeignKey(d => d.SidTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TercerosReutilizacion2017_Terceros");
            });

            modelBuilder.Entity<TercerosTiposTercero>(entity =>
            {
                entity.HasKey(e => e.PidTerceroTipoTercero);

                entity.HasIndex(e => e.Estado)
                    .HasName("Estado_TercerosTIposTercero");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_508840104")
                    .IsUnique();

                entity.Property(e => e.PidTerceroTipoTercero)
                    .HasColumnName("pidTerceroTipoTercero")
                    .ValueGeneratedNever();

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SidTipoTercero).HasColumnName("sidTipoTercero");

                entity.HasOne(d => d.SidTerceroNavigation)
                    .WithMany(p => p.TercerosTiposTercero)
                    .HasForeignKey(d => d.SidTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TercerosTiposTercero_Terceros");

                entity.HasOne(d => d.SidTipoTerceroNavigation)
                    .WithMany(p => p.TercerosTiposTercero)
                    .HasForeignKey(d => d.SidTipoTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TercerosTiposTercero_TiposTercero");
            });

            modelBuilder.Entity<Terminales>(entity =>
            {
                entity.HasKey(e => new { e.SidTercero, e.SidDireccion });

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SidDireccion).HasColumnName("sidDireccion");

                entity.Property(e => e.Terminal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SidDireccionNavigation)
                    .WithMany(p => p.Terminales)
                    .HasForeignKey(d => d.SidDireccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Terminales_DireccionesTercero");

                entity.HasOne(d => d.SidTerceroNavigation)
                    .WithMany(p => p.Terminales)
                    .HasForeignKey(d => d.SidTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Terminales_Terceros");
            });

            modelBuilder.Entity<TiposCertificado>(entity =>
            {
                entity.HasKey(e => e.PidTipoCertificado);

                entity.Property(e => e.PidTipoCertificado)
                    .HasColumnName("pidTipoCertificado")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50);

                entity.Property(e => e.Sigla)
                    .HasColumnName("sigla")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TiposContenedor>(entity =>
            {
                entity.HasKey(e => e.PidTipoContenedor);

                entity.HasIndex(e => e.Estado)
                    .HasName("Estado_TiposContenedor");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_963793720")
                    .IsUnique();

                entity.Property(e => e.PidTipoContenedor)
                    .HasColumnName("pidTipoContenedor")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodGtr).HasColumnName("codGTR");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(255);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Tara).HasColumnName("tara");
            });

            modelBuilder.Entity<TiposDestino>(entity =>
            {
                entity.HasKey(e => e.PidTipoDestino);

                entity.Property(e => e.PidTipoDestino)
                    .HasColumnName("pidTipoDestino")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TiposEtiqueta>(entity =>
            {
                entity.HasKey(e => e.PidTipoEtiqueta);

                entity.Property(e => e.PidTipoEtiqueta)
                    .HasColumnName("pidTipoEtiqueta")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TiposIncidencia>(entity =>
            {
                entity.HasKey(e => e.PidTipoIncidencia);

                entity.Property(e => e.PidTipoIncidencia)
                    .HasColumnName("pidTipoIncidencia")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposLectura>(entity =>
            {
                entity.HasKey(e => e.PidTipoLectura);

                entity.Property(e => e.PidTipoLectura)
                    .HasColumnName("pidTipoLectura")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TiposLecturaTratamiento>(entity =>
            {
                entity.HasKey(e => e.PidTipoLecturaTratamiento);

                entity.Property(e => e.PidTipoLecturaTratamiento)
                    .HasColumnName("pidTipoLecturaTratamiento")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TiposOperativa>(entity =>
            {
                entity.HasKey(e => e.PidTipoOperativa);

                entity.Property(e => e.PidTipoOperativa)
                    .HasColumnName("pidTipoOperativa")
                    .HasMaxLength(3)
                    .ValueGeneratedNever();

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50);

                entity.Property(e => e.NombreCodigo)
                    .IsRequired()
                    .HasColumnName("nombreCodigo")
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<TiposServicio>(entity =>
            {
                entity.HasKey(e => e.PidTipoServicio);

                entity.Property(e => e.PidTipoServicio)
                    .HasColumnName("pidTipoServicio")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50);

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposTercero>(entity =>
            {
                entity.HasKey(e => e.PidTipoTercero);

                entity.Property(e => e.PidTipoTercero)
                    .HasColumnName("pidTipoTercero")
                    .ValueGeneratedNever();

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tratamientos>(entity =>
            {
                entity.HasKey(e => e.PidTratamiento);

                entity.Property(e => e.PidTratamiento)
                    .HasColumnName("pidTratamiento")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Etiquetas).IsRequired();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.NroCertificado)
                    .HasColumnName("nroCertificado")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rfids)
                    .IsRequired()
                    .HasColumnName("RFIDs");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.PidUsuario);

                entity.HasIndex(e => e.SidRol)
                    .HasName("IX_FK_GVR_USUARIOS_GVR_ROLES");

                entity.Property(e => e.PidUsuario).HasColumnName("pidUsuario");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasColumnName("apellidos")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Caduca)
                    .HasColumnName("caduca")
                    .HasColumnType("datetime");

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasColumnName("contrasena")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Intento).HasColumnName("intento");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SidEstado).HasColumnName("sidEstado");

                entity.Property(e => e.SidRol).HasColumnName("sidRol");

                entity.HasOne(d => d.SidRolNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.SidRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GVR_USUARIOS_GVR_ROLES");
            });

            modelBuilder.Entity<V3v2CambiosDetallesTercerosFicticios>(entity =>
            {
                entity.HasKey(e => e.OldTerceroId);

                entity.ToTable("V3V2_CambiosDetalles_TercerosFicticios");

                entity.Property(e => e.OldTerceroId)
                    .HasColumnName("old_tercero_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.NewTerceroNombre)
                    .IsRequired()
                    .HasColumnName("new_tercero_Nombre");
            });

            modelBuilder.Entity<V3v2DireccionTercerosConversion>(entity =>
            {
                entity.HasKey(e => new { e.OldDireccionterceroId, e.NewDireccionterceroId });

                entity.ToTable("V3V2_DireccionTerceros_Conversion");

                entity.Property(e => e.OldDireccionterceroId).HasColumnName("old_direcciontercero_id");

                entity.Property(e => e.NewDireccionterceroId).HasColumnName("new_direcciontercero_id");
            });

            modelBuilder.Entity<V3v2ProcTablasBorrar>(entity =>
            {
                entity.ToTable("V3V2_Proc_TablasBorrar");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Tabla)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.TipoDatos)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<V3v2TercerosConversion>(entity =>
            {
                entity.HasKey(e => new { e.OldTerceroId, e.NewTerceroId });

                entity.ToTable("V3V2_Terceros_Conversion");

                entity.Property(e => e.OldTerceroId).HasColumnName("old_tercero_id");

                entity.Property(e => e.NewTerceroId).HasColumnName("new_tercero_id");
            });

            modelBuilder.Entity<V4v3Mapeos2016>(entity =>
            {
                entity.HasKey(e => new { e.Tipo, e.Old });

                entity.ToTable("V4V3_MAPEOS_2016");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Old).HasColumnName("OLD");

                entity.Property(e => e.New).HasColumnName("NEW");
            });

            modelBuilder.Entity<VersionesPda>(entity =>
            {
                entity.HasKey(e => new { e.NumPda, e.NombrePrograma });

                entity.ToTable("VersionesPDA");

                entity.Property(e => e.NumPda)
                    .HasColumnName("numPDA")
                    .HasMaxLength(3);

                entity.Property(e => e.NombrePrograma)
                    .HasColumnName("nombrePrograma")
                    .HasMaxLength(100);

                entity.Property(e => e.Bd)
                    .IsRequired()
                    .HasColumnName("BD")
                    .HasMaxLength(255);

                entity.Property(e => e.FechaBloqueo)
                    .HasColumnName("fechaBloqueo")
                    .HasColumnType("datetime");

                entity.Property(e => e.PublicacionInventario)
                    .IsRequired()
                    .HasColumnName("publicacionInventario")
                    .HasMaxLength(255);

                entity.Property(e => e.PublicacionMaestros)
                    .IsRequired()
                    .HasColumnName("publicacionMaestros")
                    .HasMaxLength(255);

                entity.Property(e => e.PublicacionRaees)
                    .IsRequired()
                    .HasColumnName("publicacionRaees")
                    .HasMaxLength(255);

                entity.Property(e => e.TextoBloqueo)
                    .HasColumnName("textoBloqueo")
                    .HasMaxLength(255);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnName("version")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VersionesPublicaciones>(entity =>
            {
                entity.HasKey(e => new { e.Version, e.NombrePrograma });

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasMaxLength(50);

                entity.Property(e => e.NombrePrograma)
                    .HasColumnName("nombrePrograma")
                    .HasMaxLength(100);

                entity.Property(e => e.Activa)
                    .IsRequired()
                    .HasColumnName("activa")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Bd)
                    .IsRequired()
                    .HasColumnName("BD")
                    .HasMaxLength(255);

                entity.Property(e => e.PublicacionInventario)
                    .IsRequired()
                    .HasColumnName("publicacionInventario")
                    .HasMaxLength(255);

                entity.Property(e => e.PublicacionMaestros)
                    .IsRequired()
                    .HasColumnName("publicacionMaestros")
                    .HasMaxLength(255);

                entity.Property(e => e.PublicacionRaees)
                    .IsRequired()
                    .HasColumnName("publicacionRaees")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<VideosRaeeConfigRutas>(entity =>
            {
                entity.HasKey(e => e.PidConfigVideos);

                entity.ToTable("VideosRAEE_ConfigRutas");

                entity.Property(e => e.PidConfigVideos).HasColumnName("pidConfigVideos");

                entity.Property(e => e.Ruta)
                    .IsRequired()
                    .HasColumnName("ruta")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WtkCambioEstado>(entity =>
            {
                entity.ToTable("WTK_CAMBIO_ESTADO");

                entity.Property(e => e.Albaran)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dni)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DNI");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.GpsX).HasColumnName("gpsX");

                entity.Property(e => e.GpsY).HasColumnName("gpsY");

                entity.Property(e => e.GpsZ).HasColumnName("gpsZ");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidEstado).HasColumnName("sidEstado");

                entity.Property(e => e.SidRaee)
                    .IsRequired()
                    .HasColumnName("sidRAEE")
                    .HasMaxLength(50);

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SidUsuario).HasColumnName("sidUsuario");

                entity.HasOne(d => d.SidDireccionTerceroNavigation)
                    .WithMany(p => p.WtkCambioEstado)
                    .HasForeignKey(d => d.SidDireccionTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WTK_CAMBIO_ESTADO_DireccionesTercero");

                entity.HasOne(d => d.SidEstadoNavigation)
                    .WithMany(p => p.WtkCambioEstado)
                    .HasForeignKey(d => d.SidEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WTK_CAMBIO_ESTADO_EstadosRAEE");

                entity.HasOne(d => d.SidRaeeNavigation)
                    .WithMany(p => p.WtkCambioEstado)
                    .HasForeignKey(d => d.SidRaee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WTK_CAMBIO_ESTADO_RAEEs");

                entity.HasOne(d => d.SidTerceroNavigation)
                    .WithMany(p => p.WtkCambioEstado)
                    .HasForeignKey(d => d.SidTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WTK_CAMBIO_ESTADO_Terceros");

                entity.HasOne(d => d.SidUsuarioNavigation)
                    .WithMany(p => p.WtkCambioEstado)
                    .HasForeignKey(d => d.SidUsuario)
                    .HasConstraintName("FK_WTK_CAMBIO_ESTADO_WTK_USUARIO");
            });

            modelBuilder.Entity<WtkCambioEstadoFirma>(entity =>
            {
                entity.ToTable("WTK_CAMBIO_ESTADO_FIRMA");

                entity.Property(e => e.Firma)
                    .IsRequired()
                    .HasColumnName("firma")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SidCambioEstado).HasColumnName("sidCambioEstado");

                entity.HasOne(d => d.SidCambioEstadoNavigation)
                    .WithMany(p => p.WtkCambioEstadoFirma)
                    .HasForeignKey(d => d.SidCambioEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WTK_CAMBIO_ESTADO_FIRMA_WTK_CAMBIO_ESTADO");
            });

            modelBuilder.Entity<WtkCambioEstadoFotografia>(entity =>
            {
                entity.ToTable("WTK_CAMBIO_ESTADO_FOTOGRAFIA");

                entity.Property(e => e.Fichero)
                    .HasColumnName("fichero")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SidCambioEstado).HasColumnName("sidCambioEstado");

                entity.HasOne(d => d.SidCambioEstadoNavigation)
                    .WithMany(p => p.WtkCambioEstadoFotografia)
                    .HasForeignKey(d => d.SidCambioEstado)
                    .HasConstraintName("FK_WTK_CAMBIO_ESTADO_FOTOGRAFIA_WTK_CAMBIO_ESTADO");
            });

            modelBuilder.Entity<WtkPerfil>(entity =>
            {
                entity.ToTable("WTK_PERFIL");

                entity.Property(e => e.Id)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WtkResiduoespecifico>(entity =>
            {
                entity.ToTable("WTK_RESIDUOESPECIFICO");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WtkTextoLopd>(entity =>
            {
                entity.ToTable("WTK_TEXTO_LOPD");

                entity.HasIndex(e => e.SidTercero)
                    .HasName("UQ__WTK_TEXT__4BDAAAEE7FF617D1")
                    .IsUnique();

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.Texto).IsUnicode(false);

                entity.HasOne(d => d.SidTerceroNavigation)
                    .WithOne(p => p.WtkTextoLopd)
                    .HasForeignKey<WtkTextoLopd>(d => d.SidTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WTK_TEXTO_LOPD_Terceros");
            });

            modelBuilder.Entity<WtkUsuario>(entity =>
            {
                entity.ToTable("WTK_USUARIO");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SidTipoTercero).HasColumnName("sidTipoTercero");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SidTerceroNavigation)
                    .WithMany(p => p.WtkUsuario)
                    .HasForeignKey(d => d.SidTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WTK_USUARIO_Terceros");

                entity.HasOne(d => d.SidTipoTerceroNavigation)
                    .WithMany(p => p.WtkUsuario)
                    .HasForeignKey(d => d.SidTipoTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WTK_USUARIO_TiposTercero");
            });

            modelBuilder.Entity<WtkUsuarioDirecciones>(entity =>
            {
                entity.HasKey(e => new { e.SidUsuario, e.SidDireccion });

                entity.ToTable("WTK_USUARIO_DIRECCIONES");

                entity.Property(e => e.SidUsuario).HasColumnName("sidUsuario");

                entity.Property(e => e.SidDireccion).HasColumnName("sidDireccion");

                entity.HasOne(d => d.SidDireccionNavigation)
                    .WithMany(p => p.WtkUsuarioDirecciones)
                    .HasForeignKey(d => d.SidDireccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WTK_USUARIO_DIRECCIONES_DireccionesTercero");

                entity.HasOne(d => d.SidUsuarioNavigation)
                    .WithMany(p => p.WtkUsuarioDirecciones)
                    .HasForeignKey(d => d.SidUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WTK_USUARIO_DIRECCIONES_WTK_USUARIO");
            });

            modelBuilder.Entity<WtkUsuarioPerfiles>(entity =>
            {
                entity.HasKey(e => new { e.SidUsuario, e.SidPerfil });

                entity.ToTable("WTK_USUARIO_PERFILES");

                entity.Property(e => e.SidUsuario).HasColumnName("sidUsuario");

                entity.Property(e => e.SidPerfil)
                    .HasColumnName("sidPerfil")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.SidPerfilNavigation)
                    .WithMany(p => p.WtkUsuarioPerfiles)
                    .HasForeignKey(d => d.SidPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WTK_USUARIO_PERFILES_WTK_PERFIL");

                entity.HasOne(d => d.SidUsuarioNavigation)
                    .WithMany(p => p.WtkUsuarioPerfiles)
                    .HasForeignKey(d => d.SidUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WTK_USUARIO_PERFILES_WTK_USUARIOS");
            });
        }
    }
}
