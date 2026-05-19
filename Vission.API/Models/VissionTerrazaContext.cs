using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Vission.API.Models;

public partial class VissionTerrazaContext : DbContext
{
    public VissionTerrazaContext()
    {
    }

    public VissionTerrazaContext(DbContextOptions<VissionTerrazaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Abono> Abonos { get; set; }

    public virtual DbSet<Acabado> Acabados { get; set; }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<DetallePedido> DetallePedidos { get; set; }

    public virtual DbSet<Diseño> Diseños { get; set; }

    public virtual DbSet<Especificacion> Especificacions { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<Iluminacion> Iluminacions { get; set; }

    public virtual DbSet<Instalacion> Instalacions { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<MetodoPago> MetodoPagos { get; set; }

    public virtual DbSet<Pago> Pagos { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<Soporte> Soportes { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=VissionTerraza;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Abono>(entity =>
        {
            entity.HasKey(e => e.AboId).HasName("PK__Abono__9AB1C39ED5AD670E");

            entity.ToTable("Abono");

            entity.Property(e => e.AboId).ValueGeneratedNever();
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Monto).HasColumnType("decimal(8, 2)");

            entity.HasOne(d => d.MetodoPadoNavigation).WithMany(p => p.Abonos)
                .HasForeignKey(d => d.MetodoPado)
                .HasConstraintName("FK__Abono__MetodoPad__06CD04F7");

            entity.HasOne(d => d.Pag).WithMany(p => p.Abonos)
                .HasForeignKey(d => d.PagId)
                .HasConstraintName("FK__Abono__PagId__05D8E0BE");
        });

        modelBuilder.Entity<Acabado>(entity =>
        {
            entity.HasKey(e => e.AcaId).HasName("PK__Acabado__995738EA8988A59D");

            entity.ToTable("Acabado");

            entity.Property(e => e.AcaId).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Categorium>(entity =>
        {
            entity.HasKey(e => e.CatId).HasName("PK__Categori__6A1C8AFAE510CD38");

            entity.Property(e => e.CatId).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DetallePedido>(entity =>
        {
            entity.HasKey(e => e.Dpid).HasName("PK__DetalleP__2332F795494DC061");

            entity.ToTable("DetallePedido");

            entity.Property(e => e.Dpid)
                .ValueGeneratedNever()
                .HasColumnName("DPId");
            entity.Property(e => e.Precio).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("subtotal");

            entity.HasOne(d => d.CategoriaNavigation).WithMany(p => p.DetallePedidos)
                .HasForeignKey(d => d.Categoria)
                .HasConstraintName("FK__DetallePe__Categ__7A672E12");

            entity.HasOne(d => d.DiseñoNavigation).WithMany(p => p.DetallePedidos)
                .HasForeignKey(d => d.Diseño)
                .HasConstraintName("FK__DetallePe__Diseñ__7D439ABD");

            entity.HasOne(d => d.EspecificacionesNavigation).WithMany(p => p.DetallePedidos)
                .HasForeignKey(d => d.Especificaciones)
                .HasConstraintName("FK__DetallePe__Espec__7C4F7684");

            entity.HasOne(d => d.IluminacionNavigation).WithMany(p => p.DetallePedidos)
                .HasForeignKey(d => d.Iluminacion)
                .HasConstraintName("FK__DetallePe__Ilumi__7F2BE32F");

            entity.HasOne(d => d.InstalacionNavigation).WithMany(p => p.DetallePedidos)
                .HasForeignKey(d => d.Instalacion)
                .HasConstraintName("FK__DetallePe__Insta__00200768");

            entity.HasOne(d => d.MaterialNavigation).WithMany(p => p.DetallePedidos)
                .HasForeignKey(d => d.Material)
                .HasConstraintName("FK__DetallePe__Mater__7B5B524B");

            entity.HasOne(d => d.Ped).WithMany(p => p.DetallePedidos)
                .HasForeignKey(d => d.PedId)
                .HasConstraintName("FK__DetallePe__PedId__797309D9");

            entity.HasOne(d => d.SoporteNavigation).WithMany(p => p.DetallePedidos)
                .HasForeignKey(d => d.Soporte)
                .HasConstraintName("FK__DetallePe__Sopor__7E37BEF6");
        });

        modelBuilder.Entity<Diseño>(entity =>
        {
            entity.HasKey(e => e.DisId).HasName("PK__Diseño__E2AA7E84B2512D90");

            entity.ToTable("Diseño");

            entity.Property(e => e.DisId).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Url)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<Especificacion>(entity =>
        {
            entity.HasKey(e => e.EspId).HasName("PK__Especifi__630359D50019531D");

            entity.ToTable("Especificacion");

            entity.Property(e => e.EspId).ValueGeneratedNever();
            entity.Property(e => e.EspAnc).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.EspArea)
                .HasComputedColumnSql("([EspAnc]*[EspLar])", false)
                .HasColumnType("decimal(21, 4)");
            entity.Property(e => e.EspLar).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Aca).WithMany(p => p.Especificacions)
                .HasForeignKey(d => d.AcaId)
                .HasConstraintName("FK__Especific__AcaId__72C60C4A");
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.EstId).HasName("PK__Estado__665CAD5E3692B70E");

            entity.ToTable("Estado");

            entity.Property(e => e.EstId).ValueGeneratedNever();
            entity.Property(e => e.EstPedido)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Iluminacion>(entity =>
        {
            entity.HasKey(e => e.IluId).HasName("PK__Iluminac__216FCB9D2E4AF09A");

            entity.ToTable("Iluminacion");

            entity.Property(e => e.IluId).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Instalacion>(entity =>
        {
            entity.HasKey(e => e.InsId).HasName("PK__Instalac__9D104DEFF99DC4DC");

            entity.ToTable("Instalacion");

            entity.Property(e => e.InsId).ValueGeneratedNever();
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasKey(e => e.MatId).HasName("PK__Material__294E795505461B04");

            entity.ToTable("Material");

            entity.Property(e => e.MatId).ValueGeneratedNever();
            entity.Property(e => e.MatNombre)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MetodoPago>(entity =>
        {
            entity.HasKey(e => e.MetId).HasName("PK__MetodoPa__CEF2BD4F0C45CD96");

            entity.ToTable("MetodoPago");

            entity.Property(e => e.MetId).ValueGeneratedNever();
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.HasKey(e => e.PagId).HasName("PK__Pago__ED68D0A7523CEE61");

            entity.ToTable("Pago");

            entity.Property(e => e.PagId).ValueGeneratedNever();
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("IVA");
            entity.Property(e => e.Pendiente).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Total).HasColumnType("decimal(8, 2)");

            entity.HasOne(d => d.Ped).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.PedId)
                .HasConstraintName("FK__Pago__PedId__02FC7413");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.PedId).HasName("PK__Pedido__50CF4A457DE37D78");

            entity.ToTable("Pedido");

            entity.Property(e => e.PedId).ValueGeneratedNever();
            entity.Property(e => e.Fecha).HasColumnType("datetime");

            entity.HasOne(d => d.EstadoNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.Estado)
                .HasConstraintName("FK__Pedido__Estado__76969D2E");

            entity.HasOne(d => d.Usu).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.UsuId)
                .HasConstraintName("FK__Pedido__UsuId__75A278F5");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.RolId).HasName("PK__Rol__F92302F1B83C0676");

            entity.ToTable("Rol");

            entity.Property(e => e.RolId).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Soporte>(entity =>
        {
            entity.HasKey(e => e.SopId).HasName("PK__Soporte__4EBD458D8A71B115");

            entity.ToTable("Soporte");

            entity.Property(e => e.SopId).ValueGeneratedNever();
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsuId).HasName("PK__Usuario__685263833F7826AD");

            entity.ToTable("Usuario");

            entity.Property(e => e.UsuId).ValueGeneratedNever();
            entity.Property(e => e.UsuContraseña)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsuCorreo)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.UsuDireccion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UsuNombre)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.UsuTelefono)
                .HasMaxLength(13)
                .IsUnicode(false);

            entity.HasOne(d => d.UsuRolNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.UsuRol)
                .HasConstraintName("FK__Usuario__UsuRol__6FE99F9F");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
