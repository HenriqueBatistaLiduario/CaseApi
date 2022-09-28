using System;
using Data.Mapping;
using Data.Seeds;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<UserEntity> users { get; set; }
        public DbSet<BillEntity> bulletins { get; set; }
        public DbSet<CourseEntity> courses { get; set; }
        public DbSet<SubjectEntity> subjects { get; set; }
        public DbSet<StudentEntity> students { get; set; }
        public DbSet<StudentEntity> profiles { get; set; }

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
            modelBuilder.Entity<ProfileEntity>(new ProfileMap().Configure);

            //Chamada ao processamento dos seeds...
            CourseSeeds.Courses(modelBuilder);
            ProfileSeeds.Profiles(modelBuilder);

            modelBuilder.Entity<UserEntity>().HasData(
                new UserEntity
                {
                    GUID = Guid.NewGuid(),
                    USERNAME = "Administrador",
                    USEREMAIL = "ntt.hbatistl@gmail.com",
                    CREATEDON = DateTime.Now,
                    UPDATEDON = DateTime.Now,
                    ProfileGUID = new Guid("0bd34160-38f5-4bac-9378-4adc936ce6eb")
                }
            );
        }
    }
}
