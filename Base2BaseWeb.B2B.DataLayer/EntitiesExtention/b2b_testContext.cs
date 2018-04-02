using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class b2b_testContext:DbContext
    {
        public virtual DbSet<BillSettingsInfo> BillSettingsInfo { get; set; }
        public virtual DbSet<BillSettingsOptionsInfo> BillSettingsOptionsInfo { get; set; }
        public virtual DbSet<ClientConnectionInfo> ClientConnectionInfo { get; set; }
        public virtual DbSet<ContactEmailInfo> ContactEmailInfo { get; set; }
        public virtual DbSet<ContactPhoneInfo> ContactPhonelInfo { get; set; }
        public virtual DbSet<DebtCalcMethodInfo> DebtCalcMethodInfo { get; set; }
        public virtual DbSet<DebtControlInfo> DebtControlInfo { get; set; }
        public virtual DbSet<DocumentTemplate> DocumentTemplate { get; set; }
        public virtual DbSet<DocumentTemplateCategory> DocumentTemplateCategory { get; set; }
        public virtual DbSet<FranchisingInfo> FranchisingInfo { get; set; }
        public virtual DbSet<PrintJobInfo> PrintJobInfo { get; set; }

        protected void InitializeEntitiesExtention(ModelBuilder modelBuilder)
        {
            // Configure POINT One-to-One Relations
            modelBuilder.Entity<BillSettingsInfo>()
                .HasOne(bi => bi.Point)
                .WithOne(p => p.BillSettingsInfo)
                .HasForeignKey<BillSettingsInfo>(p => p.PointNumber)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ClientConnectionInfo>()
                .HasOne(c => c.Point)
                .WithOne(p => p.ClientConnectionInfo)
                .HasForeignKey<ClientConnectionInfo>(p => p.PointNumber)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DebtControlInfo>()
                .HasOne(d => d.Point)
                .WithOne(p => p.DebtControlInfo)
                .HasForeignKey<DebtControlInfo>(p => p.PointNumber)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DebtCalcMethodInfo>()
                .HasOne(d => d.Point)
                .WithOne(p => p.DebtCalcMethodInfo)
                .HasForeignKey<DebtCalcMethodInfo>(d => d.PointNumber)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FranchisingInfo>()
                .HasOne(f => f.Point)
                .WithOne(p => p.FranchisingInfo)
                .HasForeignKey<FranchisingInfo>(p => p.PointNumber)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure POINT One-to-Many Relations
            modelBuilder.Entity<ContactEmailInfo>()
                .HasOne(c => c.Point)
                .WithMany(p => p.ContactEmailInfo)
                .HasForeignKey(c => c.PointNumber)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ContactPhoneInfo>()
                .HasOne(c => c.Point)
                .WithMany(p => p.ContactPhoneInfo)
                .HasForeignKey(c => c.PointNumber)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DocumentTemplate>()
                .HasOne(d => d.DocumentTemplateCategory)
                .WithMany(dc => dc.DocumentTemplates)
                .HasForeignKey(d => d.DocumentTemplateCategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BillSettingsOptionsInfo>()
                .HasOne(bso => bso.BillSettingsInfo)
                .WithMany(bs => bs.BillSettingsOptionsInfo)
                .HasForeignKey(bso => bso.BillSettingsInfoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PrintJobInfo>()
                .HasOne(p => p.BillSettingsInfo)
                .WithMany(b => b.PrintJobInfo)
                .HasForeignKey(p => p.BillSettingsInfoId)
                .OnDelete(DeleteBehavior.Restrict);

            //Add FK on Point Table
            //modelBuilder.Entity<Point>()
            //        .HasOne(p => p.CliGroup)
            //        .WithMany(g => g.Points)
            //        .HasForeignKey(p => p.CliGroupNumber)
            //        .OnDelete(DeleteBehavior.Restrict);

            // Configure Indexes
            modelBuilder.Entity<DebtCalcMethodInfo>()
                .HasIndex(d => d.Name)
                .IsUnique();

            modelBuilder.Entity<DocumentTemplate>()
                .HasIndex(d => d.Name)
                .IsUnique();

            modelBuilder.Entity<DocumentTemplateCategory>()
                .HasIndex(d => d.Name)
                .IsUnique();

            modelBuilder.Entity<ClientConnectionInfo>()
                .HasIndex(c => new { c.ServerName, c.DatabaseName, c.Login, c.PasswordHash })
                .IsUnique();

            modelBuilder.Entity<ContactEmailInfo>()
                .HasIndex(c => c.Email)
                .IsUnique();

            modelBuilder.Entity<ContactPhoneInfo>()
                .HasIndex(c => new { c.ContactFullName, c.PhoneNumber })
                .IsUnique();
        }
    }
}
