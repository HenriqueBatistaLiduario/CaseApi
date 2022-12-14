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
-- Table structure for table `students`
--

DROP TABLE IF EXISTS `students`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `students` (
  `GUID` char(36) NOT NULL,
  `STDFULLNAME` varchar(255) NOT NULL,
  `STDSOCIALNAME` varchar(255) NOT NULL,
  `STDREGISTRATION` varchar(32) NOT NULL,
  `STDDOCTYPE` varchar(32) DEFAULT NULL,
  `STDDOCID` varchar(32) DEFAULT NULL,
  `STDEMAIL` varchar(100) NOT NULL,
  `STDPHONE` varchar(32) DEFAULT NULL,
  `STDBIRTHDATE` datetime(6) NOT NULL,
  `CREATEDON` datetime(6) DEFAULT NULL,
  `UPDATEDON` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`GUID`),
  UNIQUE KEY `IX_students_STDEMAIL` (`STDEMAIL`),
  UNIQUE KEY `IX_students_STDREGISTRATION` (`STDREGISTRATION`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students`
--

LOCK TABLES `students` WRITE;
/*!40000 ALTER TABLE `students` DISABLE KEYS */;
INSERT INTO `students` VALUES ('3fa85f64-5717-4562-b3fc-2c963f66afa6','Elaine Cristina de Oliveira','Elaine','RA000002','CPF','06048814607','elaine.liduario@gmail.com','31996522522','2022-09-28 05:58:22.106000','2022-09-28 06:00:34.219590','2022-09-28 05:58:22.106000'),('724006ad-24f5-46fa-bd9c-fcb1d4f16cab','Henrique Batista Liduario','Henrique','RA000001','CPF','01551696614','henrique.liduario@hotmail.com','31997507814','1986-09-07 00:00:00.000000','2022-09-27 22:04:37.000000',NULL);
/*!40000 ALTER TABLE `students` ENABLE KEYS */;
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
