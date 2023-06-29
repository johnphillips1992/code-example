using LexingtonPreschoolAcademy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LexingtonPreschoolAcademy.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentClass>()
                .HasKey(sc => new { sc.StudentId, sc.ClassId });
            modelBuilder.Entity<StudentClass>()
                .HasOne(s => s.Student)
                .WithMany(sc => sc.StudentClasses)
                .HasForeignKey(s => s.StudentId);
            modelBuilder.Entity<StudentClass>()
                .HasOne(c => c.Class)
                .WithMany(sc => sc.StudentClasses)
                .HasForeignKey(c => c.ClassId);
        }
    }
}
