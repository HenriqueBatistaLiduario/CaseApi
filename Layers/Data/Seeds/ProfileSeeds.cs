using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Seeds
{
    public class ProfileSeeds
    {
        public static void Profiles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProfileEntity>().HasData(
                new ProfileEntity()
                {
                    GUID = new Guid("0bd34160-38f5-4bac-9378-4adc936ce6eb"),
                    PFLALIAS = "ADM",
                    PFLTITLE = "Administrador do sistema",
                    PFLASSIGNMENTS = "RegisterCourse;ConsultCourseList;RegisterSubject;ManageCurriculum;ConsultCurriculumByCourse;RegisterStudent;ConsultListStudentsByCourse;PostNotes;ConsultBulletin",
                    CREATEDON = DateTime.UtcNow
                },
                new ProfileEntity()
                {
                    GUID = new Guid("d159d7e8-69cb-48b4-9f00-43d3aa290717"),
                    PFLALIAS = "SAA",
                    PFLTITLE = "Secretaria Acadêmica",
                    PFLASSIGNMENTS = "RegisterCourse;ConsultCourseList;RegisterSubject;ManageCurriculum;ConsultCurriculumByCourse;RegisterStudent;ConsultListStudentsByCourse;",
                    CREATEDON = DateTime.UtcNow
                },
                new ProfileEntity()
                {
                    GUID = new Guid("8bde56dc-1f68-4b88-9a74-39551ed13bf3"),
                    PFLALIAS = "TUT",
                    PFLTITLE = "Tutor",
                    PFLASSIGNMENTS = "ConsultCourseList;ConsultCurriculumByCourse;ConsultListStudentsByCourse;PostNotes;",
                    CREATEDON = DateTime.UtcNow
                },
                new ProfileEntity()
                {
                    GUID = new Guid("4f974a4c-6a91-44f5-ad56-9ab3b2f18903"),
                    PFLALIAS = "STD",
                    PFLTITLE = "Estudante/Aluno",
                    PFLASSIGNMENTS = "ConsultCourseList;ConsultCurriculumByCourse;RegisterStudent;ConsultBulletin;",
                    CREATEDON = DateTime.UtcNow
                }

            );
        }
    }
}
