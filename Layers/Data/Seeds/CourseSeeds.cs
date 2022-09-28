using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Seeds
{
    public class CourseSeeds
    {
        public static void Courses(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseEntity>().HasData(
                new CourseEntity()
                {
                    GUID = new Guid("f6ed78e4-e6bc-476b-bbf7-699cc0c86456"),
                    CURNAME = "MBA Executivo em Segurança Cibernética",
                    CURTYPE = 2,
                    CURMODALITY = 1,
                    CURWORKLOAD = 400,
                    CREATEDON = DateTime.UtcNow
                },
                new CourseEntity()
                {
                    GUID = new Guid("994f7446-4541-4ba0-8021-1a6d369c611d"),
                    CURNAME = "Analista de Comportamento e de Carreiras",
                    CURTYPE = 3,
                    CURMODALITY = 1,
                    CURWORKLOAD = 60,
                    CREATEDON = DateTime.UtcNow
                },
                new CourseEntity()
                {
                    GUID = new Guid("0780ac95-4bf4-4d35-b4f3-0152b0d7d32a"),
                    CURNAME = "Analista em Inteligência Emocional",
                    CURTYPE = 3,
                    CURMODALITY = 1,
                    CURWORKLOAD = 60,
                    CREATEDON = DateTime.UtcNow
                },
                new CourseEntity()
                {
                    GUID = new Guid("32b573d5-ce0b-48ae-bc2b-8fff78743a62"),
                    CURNAME = "Auditoria Pública",
                    CURTYPE = 3,
                    CURMODALITY = 1,
                    CURWORKLOAD = 20,
                    CREATEDON = DateTime.UtcNow
                },
                new CourseEntity()
                {
                    GUID = new Guid("ef069aa1-0ce9-4041-8c9a-3e866ed78f51"),
                    CURNAME = "Educação Bilíngue",
                    CURTYPE = 3,
                    CURMODALITY = 1,
                    CURWORKLOAD = 120,
                    CREATEDON = DateTime.UtcNow
                }
            );
        }
    }
}
