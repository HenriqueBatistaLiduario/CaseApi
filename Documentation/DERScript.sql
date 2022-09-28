-- MySQL Script generated by MySQL Workbench
-- Tue Sep 27 21:27:34 2022
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema dbapi
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema dbapi
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `dbapi` DEFAULT CHARACTER SET latin1 ;
USE `dbapi` ;

-- -----------------------------------------------------
-- Table `dbapi`.`__efmigrationshistory`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbapi`.`__efmigrationshistory` (
  `MigrationId` VARCHAR(95) NOT NULL,
  `ProductVersion` VARCHAR(32) NOT NULL,
  PRIMARY KEY (`MigrationId`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbapi`.`courses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbapi`.`courses` (
  `GUID` CHAR(36) NOT NULL,
  `CURNAME` VARCHAR(255) NOT NULL,
  `CURTYPE` INT(11) NOT NULL,
  `CURSUBTYPE` INT(11) NOT NULL,
  `CURMODALITY` INT(11) NOT NULL,
  `CURWORKLOAD` INT(11) NOT NULL,
  `CUROFFERABLE` INT(11) NOT NULL,
  `CUROFFERABLESYNCE` DATETIME(6) NOT NULL,
  `CREATEDON` DATETIME(6) NULL DEFAULT NULL,
  `UPDATEDON` DATETIME(6) NULL DEFAULT NULL,
  PRIMARY KEY (`GUID`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbapi`.`students`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbapi`.`students` (
  `GUID` CHAR(36) NOT NULL,
  `STDFULLNAME` VARCHAR(255) NOT NULL,
  `STDSOCIALNAME` VARCHAR(255) NOT NULL,
  `STDREGISTRATION` VARCHAR(32) NOT NULL,
  `STDDOCTYPE` VARCHAR(32) NULL DEFAULT NULL,
  `STDDOCID` VARCHAR(32) NULL DEFAULT NULL,
  `STDEMAIL` VARCHAR(100) NOT NULL,
  `STDPHONE` VARCHAR(32) NULL DEFAULT NULL,
  `STDBIRTHDATE` DATETIME(6) NOT NULL,
  `CREATEDON` DATETIME(6) NULL DEFAULT NULL,
  `UPDATEDON` DATETIME(6) NULL DEFAULT NULL,
  PRIMARY KEY (`GUID`),
  UNIQUE INDEX `IX_students_STDEMAIL` (`STDEMAIL` ASC) VISIBLE,
  UNIQUE INDEX `IX_students_STDREGISTRATION` (`STDREGISTRATION` ASC) VISIBLE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbapi`.`subjects`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbapi`.`subjects` (
  `GUID` CHAR(36) NOT NULL,
  `SBJNAME` VARCHAR(255) NOT NULL,
  `SBJTYPE` LONGTEXT NOT NULL,
  `SBJSUBTYPE` LONGTEXT NULL DEFAULT NULL,
  `SBJMODALITY` LONGTEXT NOT NULL,
  `SBJWORKLOAD` LONGTEXT NOT NULL,
  `SBJOFFERABLE` LONGTEXT NOT NULL,
  `SBJOFFERABLESYNCE` DATETIME(6) NOT NULL,
  `CourseEntityGUID` CHAR(36) NULL DEFAULT NULL,
  `CREATEDON` DATETIME(6) NULL DEFAULT NULL,
  `UPDATEDON` DATETIME(6) NULL DEFAULT NULL,
  PRIMARY KEY (`GUID`),
  INDEX `IX_subjects_CourseEntityGUID` (`CourseEntityGUID` ASC) VISIBLE,
  CONSTRAINT `FK_subjects_courses_CourseEntityGUID`
    FOREIGN KEY (`CourseEntityGUID`)
    REFERENCES `dbapi`.`courses` (`GUID`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbapi`.`bulletins`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbapi`.`bulletins` (
  `GUID` CHAR(36) NOT NULL,
  `STDGUID` LONGTEXT NOT NULL,
  `STDREGISTRATION` LONGTEXT NOT NULL,
  `STDFULLNAME` LONGTEXT NOT NULL,
  `CURGUID` LONGTEXT NOT NULL,
  `CURNAME` LONGTEXT NOT NULL,
  `SBJGUID` LONGTEXT NOT NULL,
  `SBJNAME` LONGTEXT NOT NULL,
  `BLTPERIOD` LONGTEXT NOT NULL,
  `BLTTYPE` INT(11) NOT NULL,
  `BLTEVALACTIVITY1` FLOAT NOT NULL DEFAULT '0',
  `BLTEVALACTIVITY2` FLOAT NOT NULL DEFAULT '0',
  `BLTEVALACTIVITY3` FLOAT NOT NULL DEFAULT '0',
  `BLTEVALACTIVITYEND` FLOAT NOT NULL DEFAULT '0',
  `BLTSTATUS` INT(11) NOT NULL DEFAULT '0',
  `BLTDELIVERYDATE` DATETIME(6) NOT NULL,
  `CourseGUID` CHAR(36) NOT NULL,
  `SubjectGUID` CHAR(36) NOT NULL,
  `StudentGUID` CHAR(36) NOT NULL,
  `CREATEDON` DATETIME(6) NULL DEFAULT NULL,
  `UPDATEDON` DATETIME(6) NULL DEFAULT NULL,
  PRIMARY KEY (`GUID`),
  UNIQUE INDEX `IX_bulletins_StudentGUID` (`StudentGUID` ASC) VISIBLE,
  INDEX `IX_bulletins_CourseGUID` (`CourseGUID` ASC) VISIBLE,
  INDEX `IX_bulletins_SubjectGUID` (`SubjectGUID` ASC) VISIBLE,
  CONSTRAINT `FK_bulletins_courses_CourseGUID`
    FOREIGN KEY (`CourseGUID`)
    REFERENCES `dbapi`.`courses` (`GUID`)
    ON DELETE CASCADE,
  CONSTRAINT `FK_bulletins_students_StudentGUID`
    FOREIGN KEY (`StudentGUID`)
    REFERENCES `dbapi`.`students` (`GUID`)
    ON DELETE CASCADE,
  CONSTRAINT `FK_bulletins_subjects_SubjectGUID`
    FOREIGN KEY (`SubjectGUID`)
    REFERENCES `dbapi`.`subjects` (`GUID`)
    ON DELETE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbapi`.`profiles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbapi`.`profiles` (
  `GUID` CHAR(36) NOT NULL,
  `PFLALIAS` VARCHAR(10) NOT NULL,
  `PFLTITLE` VARCHAR(100) NOT NULL,
  `PFLASSIGNMENTS` VARCHAR(255) NOT NULL,
  `CREATEDON` DATETIME(6) NULL DEFAULT NULL,
  `UPDATEDON` DATETIME(6) NULL DEFAULT NULL,
  PRIMARY KEY (`GUID`),
  UNIQUE INDEX `IX_profiles_PFLALIAS` (`PFLALIAS` ASC) VISIBLE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbapi`.`user`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbapi`.`user` (
  `GUID` CHAR(36) NOT NULL,
  `USERNAME` VARCHAR(100) NOT NULL,
  `USEREMAIL` VARCHAR(100) NOT NULL,
  `ProfileGUID` CHAR(36) NOT NULL,
  `CREATEDON` DATETIME(6) NULL DEFAULT NULL,
  `UPDATEDON` DATETIME(6) NULL DEFAULT NULL,
  PRIMARY KEY (`GUID`),
  UNIQUE INDEX `IX_user_USEREMAIL` (`USEREMAIL` ASC) VISIBLE,
  INDEX `IX_user_ProfileGUID` (`ProfileGUID` ASC) VISIBLE,
  CONSTRAINT `FK_user_profiles_ProfileGUID`
    FOREIGN KEY (`ProfileGUID`)
    REFERENCES `dbapi`.`profiles` (`GUID`)
    ON DELETE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
