using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ABM_CLIENTES.Models;

public partial class AbmclientesContext : DbContext
{
    public AbmclientesContext()
    {
    }

    public AbmclientesContext(DbContextOptions<AbmclientesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        //=> optionsBuilder.UseSqlServer("Server=(local); Initial Catalog= Abmclientes; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clientes__3214EC2721CB7D0E");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apellido).HasMaxLength(50);
            entity.Property(e => e.Ciudad).HasMaxLength(50);
            entity.Property(e => e.CodigoPostal).HasMaxLength(10);
            entity.Property(e => e.Direccion).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.Pais).HasMaxLength(50);
            entity.Property(e => e.Telefono).HasMaxLength(15);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
