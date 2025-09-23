using Cognify.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Cognify.Data
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Progress> Progress { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relação Um-para-Um: User <-> Student
            modelBuilder.Entity<Student>()
                .HasOne(s => s.User)
                .WithOne(u => u.Student)
                .HasForeignKey<Student>(s => s.UserId);

            // Relação Um-para-Um: User <-> Teacher
            modelBuilder.Entity<Teacher>()
                .HasOne(t => t.User)
                .WithOne(u => u.Teacher)
                .HasForeignKey<Teacher>(t => t.UserId);

            // Relação Um-para-Muitos: Course <-> Classes
            modelBuilder.Entity<Class>()
                .HasOne(c => c.Course)
                .WithMany(co => co.Classes)
                .HasForeignKey(c => c.CourseId)
                .OnDelete(DeleteBehavior.Cascade);

            // Relação Um-para-Muitos: Course <-> Enrollments
            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Course)
                .WithMany(co => co.Enrollments)
                .HasForeignKey(e => e.CourseId)
                .OnDelete(DeleteBehavior.Cascade);

            // Relação Um-para-Muitos: Progress <-> Classes
            modelBuilder.Entity<Progress>()
                .HasOne(p => p.Class)
                .WithMany(c => c.Progresses)
                .HasForeignKey(p => p.ClassId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relação Um-para-Muitos: Progress <-> Enrollments
            modelBuilder.Entity<Progress>()
                .HasOne(p => p.Enrollment)
                .WithMany(e => e.Progresses)
                .HasForeignKey(p => p.EnrollmentId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
