CREATE DATABASE  IF NOT EXISTS `dbapi` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `dbapi`;
-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: localhost    Database: dbapi
-- ------------------------------------------------------
-- Server version	5.7.39-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `bulletins`
--

DROP TABLE IF EXISTS `bulletins`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bulletins` (
  `GUID` char(36) NOT NULL,
  `STDGUID` longtext NOT NULL,
  `STDREGISTRATION` longtext NOT NULL,
  `STDFULLNAME` longtext NOT NULL,
  `CURGUID` longtext NOT NULL,
  `CURNAME` longtext NOT NULL,
  `SBJGUID` longtext NOT NULL,
  `SBJNAME` longtext NOT NULL,
  `BLTPERIOD` longtext NOT NULL,
  `BLTTYPE` int(11) NOT NULL,
  `BLTEVALACTIVITY1` float NOT NULL DEFAULT '0',
  `BLTEVALACTIVITY2` float NOT NULL DEFAULT '0',
  `BLTEVALACTIVITY3` float NOT NULL DEFAULT '0',
  `BLTEVALACTIVITYEND` float NOT NULL DEFAULT '0',
  `BLTSTATUS` int(11) NOT NULL DEFAULT '0',
  `BLTDELIVERYDATE` datetime(6) NOT NULL,
  `CourseGUID` char(36) NOT NULL,
  `SubjectGUID` char(36) NOT NULL,
  `StudentGUID` char(36) NOT NULL,
  `CREATEDON` datetime(6) DEFAULT NULL,
  `UPDATEDON` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`GUID`),
  KEY `IX_bulletins_CourseGUID` (`CourseGUID`),
  KEY `IX_bulletins_StudentGUID` (`StudentGUID`),
  KEY `IX_bulletins_SubjectGUID` (`SubjectGUID`),
  CONSTRAINT `FK_bulletins_courses_CourseGUID` FOREIGN KEY (`CourseGUID`) REFERENCES `courses` (`GUID`) ON DELETE CASCADE,
  CONSTRAINT `FK_bulletins_students_StudentGUID` FOREIGN KEY (`StudentGUID`) REFERENCES `students` (`GUID`) ON DELETE CASCADE,
  CONSTRAINT `FK_bulletins_subjects_SubjectGUID` FOREIGN KEY (`SubjectGUID`) REFERENCES `subjects` (`GUID`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bulletins`
--

LOCK TABLES `bulletins` WRITE;
/*!40000 ALTER TABLE `bulletins` DISABLE KEYS */;
INSERT INTO `bulletins` VALUES ('05a3e3c6-0c6c-41b3-94fb-5962ebd5d159','724006ad-24f5-46fa-bd9c-fcb1d4f16cab','RA000001','Henrique Batista Liduario','f6ed78e4-e6bc-476b-bbf7-699cc0c86456','MBA Executivo em Segurança Cibernética','3f89bc51-b8b8-461a-92b5-a8c88091cb3f','Gestão e Segurança de Redes','03/10/21 até 08/11/21',1,15,10,10,40,2,'2022-02-28 22:06:10.000000','f6ed78e4-e6bc-476b-bbf7-699cc0c86456','3f89bc51-b8b8-461a-92b5-a8c88091cb3f','724006ad-24f5-46fa-bd9c-fcb1d4f16cab','2022-09-27 22:06:10.000000',NULL),('13070c5b-e818-4284-8a73-1de1515943b8','724006ad-24f5-46fa-bd9c-fcb1d4f16cab','RA000001','Henrique Batista Liduario','f6ed78e4-e6bc-476b-bbf7-699cc0c86456','MBA Executivo em Segurança Cibernética','fba2d88d-578a-44a8-863c-e34e0f05e6ec','Direção e Planejamento Estratégico','03/09/21 até 01/10/21',1,18,10,19,50,2,'2022-03-31 22:06:10.000000','f6ed78e4-e6bc-476b-bbf7-699cc0c86456','fba2d88d-578a-44a8-863c-e34e0f05e6ec','724006ad-24f5-46fa-bd9c-fcb1d4f16cab','2022-09-27 22:06:10.000000',NULL),('27d29286-4d75-43b8-a82b-975be634c597','724006ad-24f5-46fa-bd9c-fcb1d4f16cab','RA000001','Henrique Batista Liduario','f6ed78e4-e6bc-476b-bbf7-699cc0c86456','MBA Executivo em Segurança Cibernética','3d53c09f-19b4-43f9-bc45-395fe4dba21b','A Defesa Cibernética no Contexto Atual','03/01/22 até 01/02/22',1,20,10,20,45,2,'2022-07-29 22:06:10.000000','f6ed78e4-e6bc-476b-bbf7-699cc0c86456','3d53c09f-19b4-43f9-bc45-395fe4dba21b','724006ad-24f5-46fa-bd9c-fcb1d4f16cab','2022-09-27 22:06:10.000000',NULL),('3fa85f64-5717-4562-b3fc-2c963f66afa6','string','string','string','string','string','string','string','string',0,0,0,0,0,0,'2022-09-28 05:58:22.106000','3fa85f64-5717-4562-b3fc-2c963f66afa6','3fa85f64-5717-4562-b3fc-2c963f66afa6','3fa85f64-5717-4562-b3fc-2c963f66afa6','2022-09-28 05:58:22.106000','2022-09-28 05:58:22.106000'),('40f9d60a-f022-4fba-9a89-056d2137cc81','724006ad-24f5-46fa-bd9c-fcb1d4f16cab','RA000001','Henrique Batista Liduario','f6ed78e4-e6bc-476b-bbf7-699cc0c86456','MBA Executivo em Segurança Cibernética','b038e059-455d-46fd-969e-62f27cb94e39','Desenvolvimento Profissional','29/03/21 até 06/05/21',1,50,50,0,0,2,'2022-04-28 22:06:10.000000','f6ed78e4-e6bc-476b-bbf7-699cc0c86456','b038e059-455d-46fd-969e-62f27cb94e39','724006ad-24f5-46fa-bd9c-fcb1d4f16cab','2022-09-27 22:06:10.000000',NULL),('44003f87-72df-41c0-969e-567641485d93','724006ad-24f5-46fa-bd9c-fcb1d4f16cab','RA000001','Henrique Batista Liduario','f6ed78e4-e6bc-476b-bbf7-699cc0c86456','MBA Executivo em Segurança Cibernética','f318cd36-134e-4ff7-8991-83666d57e1d6','Governança e Gestão de Riscos','03/11/21 até 01/12/21',1,5,5,8,35,3,'2021-12-30 22:06:10.000000','f6ed78e4-e6bc-476b-bbf7-699cc0c86456','f318cd36-134e-4ff7-8991-83666d57e1d6','724006ad-24f5-46fa-bd9c-fcb1d4f16cab','2022-09-27 22:06:10.000000',NULL),('5b734a54-1d46-4fab-9c18-a0e1bcf1e095','724006ad-24f5-46fa-bd9c-fcb1d4f16cab','RA000001','Henrique Batista Liduario','f6ed78e4-e6bc-476b-bbf7-699cc0c86456','MBA Executivo em Segurança Cibernética','032cb7e4-6e27-44e6-bbbb-f0f5acf1c2cf','Gestão Estratégica de Recursos Humanos','03/11/21 até 01/12/21',1,20,10,20,35,2,'2022-01-28 22:06:10.000000','f6ed78e4-e6bc-476b-bbf7-699cc0c86456','032cb7e4-6e27-44e6-bbbb-f0f5acf1c2cf','724006ad-24f5-46fa-bd9c-fcb1d4f16cab','2022-09-27 22:06:10.000000',NULL),('614c9e42-0b9e-48f3-816d-8892e6012cc2','724006ad-24f5-46fa-bd9c-fcb1d4f16cab','RA000001','Henrique Batista Liduario','f6ed78e4-e6bc-476b-bbf7-699cc0c86456','MBA Executivo em Segurança Cibernética','d9d1c020-a4fd-4f76-8351-cb605391dbe7','Sistemas Criptográficos, Biométricos, Direito Digital e Responsabilidade Civil na Questão da Monitoração Eletrônica','01/06/22 até 01/07/22',3,40,50,0,0,2,'2022-07-19 22:06:10.000000','f6ed78e4-e6bc-476b-bbf7-699cc0c86456','d9d1c020-a4fd-4f76-8351-cb605391dbe7','724006ad-24f5-46fa-bd9c-fcb1d4f16cab','2022-09-27 22:06:10.000000',NULL),('908dd520-d5af-4786-8175-b870b7900cbb','724006ad-24f5-46fa-bd9c-fcb1d4f16cab','RA000001','Henrique Batista Liduario','f6ed78e4-e6bc-476b-bbf7-699cc0c86456','MBA Executivo em Segurança Cibernética','d876ca15-31df-4397-9ba3-d5205c694939','Criminalística e Legislação Cibernética','03/12/21 até 27/01/22',1,19,9,19,25,2,'2022-05-29 22:06:10.000000','f6ed78e4-e6bc-476b-bbf7-699cc0c86456','d876ca15-31df-4397-9ba3-d5205c694939','724006ad-24f5-46fa-bd9c-fcb1d4f16cab','2022-09-27 22:06:10.000000',NULL),('94b4bb5f-8432-4461-8666-33050263313a','724006ad-24f5-46fa-bd9c-fcb1d4f16cab','RA000001','Henrique Batista Liduario','f6ed78e4-e6bc-476b-bbf7-699cc0c86456','MBA Executivo em Segurança Cibernética','7cade2e8-2d16-49ea-bc71-dc0c26190ce7','Políticas, Gestão de Segurança da Informação e da Continuidade de Negócios','03/05/21 até 01/06/21',1,20,10,20,45,2,'2021-11-16 22:06:10.000000','f6ed78e4-e6bc-476b-bbf7-699cc0c86456','7cade2e8-2d16-49ea-bc71-dc0c26190ce7','724006ad-24f5-46fa-bd9c-fcb1d4f16cab','2022-09-27 22:06:10.000000',NULL),('a53285c5-2afc-41f4-a1ad-96e66badd1cf','724006ad-24f5-46fa-bd9c-fcb1d4f16cab','RA000001','Henrique Batista Liduario','f6ed78e4-e6bc-476b-bbf7-699cc0c86456','MBA Executivo em Segurança Cibernética','d9d1c020-a4fd-4f76-8351-cb605391dbe7','Sistemas Criptográficos, Biométricos, Direito Digital e Responsabilidade Civil na Questão da Monitoração Eletrônica','03/07/21 até 01/08/21',1,0,0,0,0,3,'2021-10-18 22:06:10.000000','f6ed78e4-e6bc-476b-bbf7-699cc0c86456','d9d1c020-a4fd-4f76-8351-cb605391dbe7','724006ad-24f5-46fa-bd9c-fcb1d4f16cab','2022-09-27 22:06:10.000000',NULL),('aee47182-7ddc-4337-9bb4-98a3b279b3a5','724006ad-24f5-46fa-bd9c-fcb1d4f16cab','RA000001','Henrique Batista Liduario','f6ed78e4-e6bc-476b-bbf7-699cc0c86456','MBA Executivo em Segurança Cibernética','82854048-ebe6-4b08-a1ee-bfa30b9224f8','Auditoria em Ambientes Cibernéticos','03/08/21 até 11/09/21',1,15,4,20,30,3,'2021-10-02 22:06:10.000000','f6ed78e4-e6bc-476b-bbf7-699cc0c86456','82854048-ebe6-4b08-a1ee-bfa30b9224f8','724006ad-24f5-46fa-bd9c-fcb1d4f16cab','2022-09-27 22:06:10.000000',NULL),('edf9b8e8-2a97-495e-b882-d288d0457f2b','724006ad-24f5-46fa-bd9c-fcb1d4f16cab','RA000001','Henrique Batista Liduario','f6ed78e4-e6bc-476b-bbf7-699cc0c86456','MBA Executivo em Segurança Cibernética','f318cd36-134e-4ff7-8991-83666d57e1d6','Governança e Gestão de Riscos','07/02/2022 até 09/03/2022',3,50,50,0,0,2,'2021-12-30 22:06:10.000000','f6ed78e4-e6bc-476b-bbf7-699cc0c86456','f318cd36-134e-4ff7-8991-83666d57e1d6','724006ad-24f5-46fa-bd9c-fcb1d4f16cab','2022-09-27 22:06:10.000000',NULL),('f4d7463d-173a-4931-a9ad-4d2a6f616c7e','724006ad-24f5-46fa-bd9c-fcb1d4f16cab','RA000001','Henrique Batista Liduario','f6ed78e4-e6bc-476b-bbf7-699cc0c86456','MBA Executivo em Segurança Cibernética','82854048-ebe6-4b08-a1ee-bfa30b9224f8','Auditoria em Ambientes Cibernéticos','07/08/22 até 06/09/22',3,50,50,0,0,2,'2022-08-27 22:06:10.000000','f6ed78e4-e6bc-476b-bbf7-699cc0c86456','82854048-ebe6-4b08-a1ee-bfa30b9224f8','724006ad-24f5-46fa-bd9c-fcb1d4f16cab','2022-09-27 22:06:10.000000',NULL);
/*!40000 ALTER TABLE `bulletins` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-09-28  6:32:04
