using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class b2b_testContext:DbContext
    {
        public virtual DbSet<BillSettingsInfo> BillSettingsInfo { get; set; }
        public virtual DbSet<BillOptionsInfo> BillSettingsOptionsInfo { get; set; }
        public virtual DbSet<ClientConnectionInfo> ClientConnectionInfo { get; set; }
        public virtual DbSet<ContactEmailInfo> ContactEmailInfo { get; set; }
        public virtual DbSet<ContactPhoneInfo> ContactPhonelInfo { get; set; }
        public virtual DbSet<DebtCalcMethodInfo> DebtCalcMethodInfo { get; set; }
        public virtual DbSet<DebtCalcMethodType> DebtCalcMethodType { get; set; }
        public virtual DbSet<DebtControlInfo> DebtControlInfo { get; set; }
        public virtual DbSet<DocumentTemplate> DocumentTemplate { get; set; }
        public virtual DbSet<DocumentTemplateCategory> DocumentTemplateCategory { get; set; }
        public virtual DbSet<FranchisingInfo> FranchisingInfo { get; set; }
        public virtual DbSet<FranchisingType> FranchisingType { get; set; }
        public virtual DbSet<PrintJobInfo> PrintJobInfo { get; set; }
        public virtual DbSet<ServicePlaceholderType> ServicePlaceholderType { get; set; }
        public virtual DbSet<ProductClient> ProductClients { get; set; }
        public virtual DbSet<GroupClient> GroupClients { get; set; }
        public virtual DbSet<PointChildren> PointChildren { get; set; }

        protected void InitializeEntitiesExtention(ModelBuilder modelBuilder)
        {
            // Configure One-to-One Relations
            modelBuilder.Entity<BillSettingsInfo>()
                .HasOne(bi => bi.Point)
                .WithOne(p => p.BillSettingsInfo)
                .HasForeignKey<BillSettingsInfo>(p => p.PointNumber)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<BillSettingsInfo>()
                .HasOne(bs => bs.ServicePlaceholderType)
                .WithOne(s => s.BillSettingsInfo)
                .HasForeignKey<BillSettingsInfo>(bs => bs.ServicePlaceholderTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<BillSettingsInfo>()
                .HasOne(bs => bs.DocumentTemplate)
                .WithOne(s => s.BillSettingsInfo)
                .HasForeignKey<BillSettingsInfo>(bs => bs.DocumentTemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<BillOptionsInfo>()
                .HasOne(bo => bo.DocumentTemplate)
                .WithOne(d => d.BillOptionsInfo)
                .HasForeignKey<BillOptionsInfo>(bo => bo.DocumentTemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<PrintJobInfo>()
                .HasOne(pj => pj.DocumentTemplate)
                .WithOne(d => d.PrintJobInfo)
                .HasForeignKey<PrintJobInfo>(pj => pj.DocumentTemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<ClientConnectionInfo>()
                .HasOne(c => c.Point)
                .WithOne(p => p.ClientConnectionInfo)
                .HasForeignKey<ClientConnectionInfo>(p => p.PointNumber)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<DebtControlInfo>()
                .HasOne(d => d.Point)
                .WithOne(p => p.DebtControlInfo)
                .HasForeignKey<DebtControlInfo>(p => p.PointNumber)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<DebtCalcMethodInfo>()
                .HasOne(d => d.Point)
                .WithOne(p => p.DebtCalcMethodInfo)
                .HasForeignKey<DebtCalcMethodInfo>(d => d.PointNumber)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<FranchisingInfo>()
                .HasOne(f => f.Point)
                .WithOne(p => p.FranchisingInfo)
                .HasForeignKey<FranchisingInfo>(p => p.PointNumber)
                .OnDelete(DeleteBehavior.ClientSetNull);

            // Configure POINT One-to-Many Relations
            modelBuilder.Entity<BillOptionsInfo>()
                .HasOne(bo => bo.Point)
                .WithMany(p => p.BillOptionsInfo)
                .HasForeignKey(bo => bo.PointNumber)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<PrintJobInfo>()
                .HasOne(pj => pj.Point)
                .WithMany(p => p.PrintJobInfo)
                .HasForeignKey(pj => pj.PointNumber)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<ContactEmailInfo>()
                .HasOne(c => c.Point)
                .WithMany(p => p.ContactEmailInfo)
                .HasForeignKey(c => c.PointNumber)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<ContactPhoneInfo>()
                .HasOne(c => c.Point)
                .WithMany(p => p.ContactPhoneInfo)
                .HasForeignKey(c => c.PointNumber)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<DocumentTemplate>()
                .HasOne(d => d.DocumentTemplateCategory)
                .WithMany(dc => dc.DocumentTemplates)
                .HasForeignKey(d => d.DocumentTemplateCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<DebtCalcMethodInfo>()
                .HasOne(d => d.DebtCalcMethodTypes)
                .WithMany(dt => dt.DebtCalcMethodInfo)
                .HasForeignKey(d => d.DebtCalcMethodTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<FranchisingInfo>()
                .HasOne(f => f.FranchisingType)
                .WithMany(ft => ft.FranchisingInfo)
                .HasForeignKey(f => f.FranchisingTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Point)
                .WithMany(p => p.Tickets)
                .HasForeignKey(t => t.PointNumber)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.TicketSubject)
                .WithMany(subj => subj.Tickets)
                .HasForeignKey(t => t.TicketSubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.TicketStatus)
                .WithMany(status => status.Tickets)
                .HasForeignKey(t => t.TicketStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<PointChildren>()
                .HasOne(pc => pc.Point)
                .WithMany(p => p.PointChildren)
                .HasForeignKey(pc => pc.PointNumber)
                .OnDelete(DeleteBehavior.Cascade);
            //Add FK on Point Table
            //modelBuilder.Entity<Point>()
            //        .HasOne(p => p.CliGroup)
            //        .WithMany(g => g.Points)
            //        .HasForeignKey(p => p.CliGroupNumber)
            //        .OnDelete(DeleteBehavior.Restrict);

            // Configure Many-to-Many relations
            modelBuilder.Entity<ProductClient>()
                .HasKey(pc => new { pc.PointNumber, pc.TovarNumber });

            modelBuilder.Entity<ProductClient>()
                .HasOne<Point>(pc => pc.Point)
                .WithMany(p => p.ProductClients)
                .HasForeignKey(pc => pc.PointNumber);

            modelBuilder.Entity<ProductClient>()
                .HasOne<Tovar>(pc => pc.Tovar)
                .WithMany(p => p.ProductClients)
                .HasForeignKey(pc => pc.TovarNumber);

            modelBuilder.Entity<GroupClient>()
                .HasKey(gc => new { gc.PointNumber, gc.CliGroupNumber });

            modelBuilder.Entity<GroupClient>()
                .HasOne<Point>(gc => gc.Point)
                .WithMany(p => p.GroupClients)
                .HasForeignKey(gc => gc.PointNumber);

            modelBuilder.Entity<GroupClient>()
                .HasOne<CliGroup>(gc => gc.CliGroup)
                .WithMany(p => p.GroupClients)
                .HasForeignKey(gc => gc.CliGroupNumber);


            // Configure Indexes
            modelBuilder.Entity<DebtCalcMethodType>()
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
                .IsUnique(false);

            modelBuilder.Entity<ContactPhoneInfo>()
                .HasIndex(c => new { c.ContactFullName, c.PhoneNumber })
                .IsUnique(false);

            modelBuilder.Entity<FranchisingType>()
                .HasIndex(f => f.Name)
                .IsUnique();

            modelBuilder.Entity<ServicePlaceholderType>()
                .HasIndex(f => f.Name)
                .IsUnique();

            modelBuilder.Entity<TicketSubject>()
                .HasIndex(subj => subj.TicketSubjectName)
                .IsUnique();

            modelBuilder.Entity<TicketStatus>()
                .HasIndex(subj => subj.TicketStatusName)
                .IsUnique();

            modelBuilder.Entity<PointChildren>()
                .HasIndex(pc => new { pc.PointNumber, pc.PointChildrenId })
                .IsUnique(true);
        }
    }
}