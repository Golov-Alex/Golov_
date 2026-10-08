using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Golov_.Model
{
    public partial class ModelEF : DbContext
    {
        public ModelEF()
            : base("name=ModelEF")
        {
        }

        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Copies> Copies { get; set; }
        public virtual DbSet<Fines> Fines { get; set; }
        public virtual DbSet<Issues> Issues { get; set; }
        public virtual DbSet<LibrarianLogs> LibrarianLogs { get; set; }
        public virtual DbSet<Reserves> Reserves { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.author)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.publisher)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.shelf_location)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.is_rare)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.Copies)
                .WithRequired(e => e.Book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Copies>()
                .Property(e => e.inventory_number)
                .IsUnicode(false);

            modelBuilder.Entity<Copies>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<Copies>()
                .HasMany(e => e.Issues)
                .WithRequired(e => e.Copies)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Fines>()
                .Property(e => e.amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Fines>()
                .Property(e => e.reason)
                .IsUnicode(false);

            modelBuilder.Entity<Issues>()
                .Property(e => e.fine_paid)
                .IsUnicode(false);

            modelBuilder.Entity<LibrarianLogs>()
                .Property(e => e.action)
                .IsUnicode(false);

            modelBuilder.Entity<Reserves>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.full_name)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.role)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Fines)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.reader_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Issues)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.reader_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.LibrarianLogs)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.librarian_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.LibrarianLogs1)
                .WithOptional(e => e.Users1)
                .HasForeignKey(e => e.reader_id);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Reserves)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.reader_id)
                .WillCascadeOnDelete(false);
        }
    }
}
