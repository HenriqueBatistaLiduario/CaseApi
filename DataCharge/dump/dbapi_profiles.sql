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
-- Table structure for table `profiles`
--

DROP TABLE IF EXISTS `profiles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `profiles` (
  `GUID` char(36) NOT NULL,
  `PFLALIAS` varchar(10) NOT NULL,
  `PFLTITLE` varchar(100) NOT NULL,
  `PFLASSIGNMENTS` varchar(255) NOT NULL,
  `CREATEDON` datetime(6) DEFAULT NULL,
  `UPDATEDON` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`GUID`),
  UNIQUE KEY `IX_profiles_PFLALIAS` (`PFLALIAS`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `profiles`
--

LOCK TABLES `profiles` WRITE;
/*!40000 ALTER TABLE `profiles` DISABLE KEYS */;
INSERT INTO `profiles` VALUES ('0bd34160-38f5-4bac-9378-4adc936ce6eb','ADM','Administrador do sistema','RegisterCourse;ConsultCourseList;RegisterSubject;ManageCurriculum;ConsultCurriculumByCourse;RegisterStudent;ConsultListStudentsByCourse;PostNotes;ConsultBulletin','2022-09-28 05:02:57.000000',NULL),('4f974a4c-6a91-44f5-ad56-9ab3b2f18903','STD','Estudante/Aluno','ConsultCourseList;ConsultCurriculumByCourse;RegisterStudent;ConsultBulletin;','2022-09-28 05:02:57.000000',NULL),('8bde56dc-1f68-4b88-9a74-39551ed13bf3','TUT','Tutor','ConsultCourseList;ConsultCurriculumByCourse;ConsultListStudentsByCourse;PostNotes;','2022-09-28 05:02:57.000000',NULL),('d159d7e8-69cb-48b4-9f00-43d3aa290717','SAA','Secretaria Acadêmica','RegisterCourse;ConsultCourseList;RegisterSubject;ManageCurriculum;ConsultCurriculumByCourse;RegisterStudent;ConsultListStudentsByCourse;','2022-09-28 05:02:57.000000',NULL);
/*!40000 ALTER TABLE `profiles` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-09-28  6:32:03
