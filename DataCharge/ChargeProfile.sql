INSERT INTO dbapi.profiles(GUID,PFLALIAS,PFLTITLE,PFLASSIGNMENTS,CREATEDON) VALUES
('0bd34160-38f5-4bac-9378-4adc936ce6eb','ADM','Administrador do sistema',
    'RegisterCourse;ConsultCourseList;
    RegisterSubject;ManageCurriculum;ConsultCurriculumByCourse;
    RegisterStudent;ConsultListStudentsByCourse;
    PostNotes;ConsultBulletin',NOW()
),
('d159d7e8-69cb-48b4-9f00-43d3aa290717','SAA','Secretaria Acadêmica',
    'RegisterCourse;ConsultCourseList;
    RegisterSubject;ManageCurriculum;ConsultCurriculumByCourse;
    RegisterStudent;ConsultListStudentsByCourse;',NOW()
),
('8bde56dc-1f68-4b88-9a74-39551ed13bf3','TUT','Tutor',
    'ConsultCourseList;ConsultCurriculumByCourse;
    ConsultListStudentsByCourse;
    PostNotes;',NOW()
),
('4f974a4c-6a91-44f5-ad56-9ab3b2f18903','STD','Estudante/Aluno',
   'ConsultCourseList;ConsultCurriculumByCourse;
    RegisterStudent;
    ConsultBulletin',NOW()
);
