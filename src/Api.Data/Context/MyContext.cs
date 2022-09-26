using Api.Data.Mapping;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<UserEntity> users { get; set; }
        public DbSet<BillEntity> bulletins { get; set; }
        public DbSet<CourseEntity> courses { get; set; }
        public DbSet<SubjectEntity> subjects { get; set; }
        public DbSet<StudentEntity> students { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserEntity>(new UserMap().Configure);
            modelBuilder.Entity<BillEntity>(new BillMap().Configure);
            modelBuilder.Entity<CourseEntity>(new CourseMap().Configure);
            modelBuilder.Entity<SubjectEntity>(new SubjectMap().Configure);
            modelBuilder.Entity<StudentEntity>(new StudentMap().Configure);
        }

    }
}
