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
-- Table structure for table `subjects`
--

DROP TABLE IF EXISTS `subjects`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `subjects` (
  `GUID` char(36) NOT NULL,
  `SBJNAME` varchar(255) NOT NULL,
  `SBJTYPE` longtext NOT NULL,
  `SBJSUBTYPE` longtext,
  `SBJMODALITY` longtext NOT NULL,
  `SBJWORKLOAD` longtext NOT NULL,
  `SBJOFFERABLE` longtext NOT NULL,
  `SBJOFFERABLESYNCE` datetime(6) NOT NULL,
  `CourseEntityGUID` char(36) DEFAULT NULL,
  `CREATEDON` datetime(6) DEFAULT NULL,
  `UPDATEDON` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`GUID`),
  KEY `IX_subjects_CourseEntityGUID` (`CourseEntityGUID`),
  CONSTRAINT `FK_subjects_courses_CourseEntityGUID` FOREIGN KEY (`CourseEntityGUID`) REFERENCES `courses` (`GUID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subjects`
--

LOCK TABLES `subjects` WRITE;
/*!40000 ALTER TABLE `subjects` DISABLE KEYS */;
INSERT INTO `subjects` VALUES ('032cb7e4-6e27-44e6-bbbb-f0f5acf1c2cf','Gestão Estratégica de Recursos Humanos','2',NULL,'1','40','1','2022-09-27 22:06:06.000000',NULL,'2022-09-27 22:06:06.000000',NULL),('3d53c09f-19b4-43f9-bc45-395fe4dba21b','A Defesa Cibernética no Contexto Atual','2',NULL,'1','40','1','2022-09-27 22:06:06.000000',NULL,'2022-09-27 22:06:06.000000',NULL),('3f89bc51-b8b8-461a-92b5-a8c88091cb3f','Gestão e Segurança de Redes','2',NULL,'1','40','1','2022-09-27 22:06:06.000000',NULL,'2022-09-27 22:06:06.000000',NULL),('3fa85f64-5717-4562-b3fc-2c963f66afa6','string','string','string','string','string','string','2022-09-28 05:58:22.106000','3fa85f64-5717-4562-b3fc-2c963f66afa6','2022-09-28 05:58:22.106000','2022-09-28 05:58:22.106000'),('45453c17-c205-4e6a-9276-e175acf3eebd','Disciplina Teste pela API','1','2','1','480','1','2022-09-28 06:00:55.608000',NULL,'2022-09-28 06:02:23.251758','2022-09-28 06:00:55.608000'),('7cade2e8-2d16-49ea-bc71-dc0c26190ce7','Políticas, Gestão de Segurança da Informação e da Continuidade de Negócios','2',NULL,'1','40','1','2022-09-27 22:06:06.000000',NULL,'2022-09-27 22:06:06.000000',NULL),('82854048-ebe6-4b08-a1ee-bfa30b9224f8','Auditoria em Ambientes Cibernéticos','2',NULL,'1','40','1','2022-09-27 22:06:06.000000',NULL,'2022-09-27 22:06:06.000000',NULL),('b038e059-455d-46fd-969e-62f27cb94e39','Desenvolvimento Profissional','2',NULL,'1','40','1','2022-09-27 22:06:06.000000',NULL,'2022-09-27 22:06:06.000000',NULL),('d876ca15-31df-4397-9ba3-d5205c694939','Criminalística e Legislação Cibernética','2',NULL,'1','40','1','2022-09-27 22:06:06.000000',NULL,'2022-09-27 22:06:06.000000',NULL),('d9d1c020-a4fd-4f76-8351-cb605391dbe7','Sistemas Criptográficos, Biométricos, Direito Digital e Responsabilidade Civil na Questão da Monitoração Eletrônica','2',NULL,'1','40','1','2022-09-27 22:06:06.000000',NULL,'2022-09-27 22:06:06.000000',NULL),('f318cd36-134e-4ff7-8991-83666d57e1d6','Governança e Gestão de Riscos','2',NULL,'1','40','1','2022-09-27 22:06:06.000000',NULL,'2022-09-27 22:06:06.000000',NULL),('fba2d88d-578a-44a8-863c-e34e0f05e6ec','Direção e Planejamento Estratégico','2',NULL,'1','40','1','2022-09-27 22:06:06.000000',NULL,'2022-09-27 22:06:06.000000',NULL);
/*!40000 ALTER TABLE `subjects` ENABLE KEYS */;
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
