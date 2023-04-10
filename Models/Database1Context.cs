using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Billing_App.Models;

public partial class Database1Context : DbContext
{
    public Database1Context()
    {
    }

    public Database1Context(DbContextOptions<Database1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Agent> Agents { get; set; }

    public virtual DbSet<CoffeeShopCust> CoffeeShopCusts { get; set; }

    public virtual DbSet<CoffeeShopOrder> CoffeeShopOrders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectModels;Database=Database1;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Agent>(entity =>
        {
            entity.HasKey(e => e.AgentCode).HasName("PK__Agents__843A8BBAD8280AF3");

            entity.Property(e => e.AgentCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AGENT_CODE");
            entity.Property(e => e.AgentName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("AGENT_NAME");
            entity.Property(e => e.Commission)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("COMMISSION");
            entity.Property(e => e.Country)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PHONE_NO");
            entity.Property(e => e.WorkingArea)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("WORKING_AREA");
        });

        modelBuilder.Entity<CoffeeShopCust>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("coffeeShop_Cust");

            entity.Property(e => e.CustMobile).HasColumnName("custMobile");
            entity.Property(e => e.CustName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("custName");
            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<CoffeeShopOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("coffeeShop_Order");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Item)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("item");
            entity.Property(e => e.Price)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("price");
            entity.Property(e => e.PurchaseDate)
                .HasColumnType("datetime")
                .HasColumnName("purchase_date");
            entity.Property(e => e.Qty).HasColumnName("qty");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
