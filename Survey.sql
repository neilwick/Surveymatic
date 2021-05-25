-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.4.14-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             11.1.0.6116
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for survey
DROP DATABASE IF EXISTS `survey`;
CREATE DATABASE IF NOT EXISTS `survey` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `survey`;

-- Dumping structure for table survey.help
DROP TABLE IF EXISTS `help`;
CREATE TABLE IF NOT EXISTS `help` (
  `HelpId` int(11) NOT NULL AUTO_INCREMENT,
  `HelpTag` longtext DEFAULT NULL,
  PRIMARY KEY (`HelpId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table survey.help: ~3 rows (approximately)
/*!40000 ALTER TABLE `help` DISABLE KEYS */;
REPLACE INTO `help` (`HelpId`, `HelpTag`) VALUES
	(1, 'Login'),
	(2, 'Export Report'),
	(3, 'Create Account');
/*!40000 ALTER TABLE `help` ENABLE KEYS */;

-- Dumping structure for table survey.helpentry
DROP TABLE IF EXISTS `helpentry`;
CREATE TABLE IF NOT EXISTS `helpentry` (
  `HelpEntryId` int(11) NOT NULL AUTO_INCREMENT,
  `HelpId` int(11) DEFAULT NULL,
  `Language` longtext DEFAULT NULL,
  `Content` longtext DEFAULT NULL,
  `Title` longtext DEFAULT NULL,
  PRIMARY KEY (`HelpEntryId`),
  KEY `IX_HelpEntry_HelpId` (`HelpId`),
  CONSTRAINT `FK_HelpEntry_Help_HelpId` FOREIGN KEY (`HelpId`) REFERENCES `help` (`HelpId`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table survey.helpentry: ~4 rows (approximately)
/*!40000 ALTER TABLE `helpentry` DISABLE KEYS */;
REPLACE INTO `helpentry` (`HelpEntryId`, `HelpId`, `Language`, `Content`, `Title`) VALUES
	(1, 1, 'en', 'This is the help page', 'gf'),
	(2, 3, 'en', 'This is create account page', 'hfgh'),
	(3, 2, 'en', 'This is export report page', NULL),
	(4, 3, 'fr', 'Bonjour a la page d\'aide', 'cv bcvcvbcvb');
/*!40000 ALTER TABLE `helpentry` ENABLE KEYS */;

-- Dumping structure for table survey.__efmigrationshistory
DROP TABLE IF EXISTS `__efmigrationshistory`;
CREATE TABLE IF NOT EXISTS `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table survey.__efmigrationshistory: ~0 rows (approximately)
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
REPLACE INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
	('20210519162328_init', '5.0.6'),
	('20210521173435_titletohelp', '5.0.6');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
