-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.4.14-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             11.0.0.5919
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for surveymaticdb
CREATE DATABASE IF NOT EXISTS `surveymaticdb` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `surveymaticdb`;

-- Dumping structure for table surveymaticdb.answer
CREATE TABLE IF NOT EXISTS `answer` (
  `AnswerID` int(11) NOT NULL AUTO_INCREMENT,
  `QuestionID` int(11) NOT NULL DEFAULT 0,
  `PersonID` int(11) NOT NULL DEFAULT 0,
  `AnswerINT` int(11) NOT NULL DEFAULT 0,
  `AnswerTXT` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`AnswerID`),
  KEY `FK_answer_question` (`QuestionID`),
  CONSTRAINT `FK_answer_question` FOREIGN KEY (`QuestionID`) REFERENCES `question` (`QuestionID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table surveymaticdb.answer: ~0 rows (approximately)
/*!40000 ALTER TABLE `answer` DISABLE KEYS */;
/*!40000 ALTER TABLE `answer` ENABLE KEYS */;

-- Dumping structure for table surveymaticdb.question
CREATE TABLE IF NOT EXISTS `question` (
  `QuestionID` int(11) NOT NULL AUTO_INCREMENT,
  `SurveyID` int(11) NOT NULL DEFAULT 0,
  `Order` int(11) NOT NULL DEFAULT 0,
  PRIMARY KEY (`QuestionID`),
  KEY `FK_question_survey` (`SurveyID`),
  CONSTRAINT `FK_question_survey` FOREIGN KEY (`SurveyID`) REFERENCES `survey` (`SurveyId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table surveymaticdb.question: ~0 rows (approximately)
/*!40000 ALTER TABLE `question` DISABLE KEYS */;
/*!40000 ALTER TABLE `question` ENABLE KEYS */;

-- Dumping structure for table surveymaticdb.questiontranslation
CREATE TABLE IF NOT EXISTS `questiontranslation` (
  `QuestionTranslatonID` int(11) NOT NULL,
  `QuestionID` int(11) NOT NULL,
  `Language` varchar(50) NOT NULL DEFAULT '',
  `Type` int(11) NOT NULL DEFAULT 0,
  `Text` varchar(50) NOT NULL DEFAULT '',
  PRIMARY KEY (`QuestionTranslatonID`),
  KEY `FK_questiontranslation_question` (`QuestionID`),
  CONSTRAINT `FK_questiontranslation_question` FOREIGN KEY (`QuestionID`) REFERENCES `question` (`QuestionID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table surveymaticdb.questiontranslation: ~0 rows (approximately)
/*!40000 ALTER TABLE `questiontranslation` DISABLE KEYS */;
/*!40000 ALTER TABLE `questiontranslation` ENABLE KEYS */;

-- Dumping structure for table surveymaticdb.survey
CREATE TABLE IF NOT EXISTS `survey` (
  `SurveyId` int(11) NOT NULL AUTO_INCREMENT,
  `UserID` int(11) NOT NULL DEFAULT 0,
  PRIMARY KEY (`SurveyId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table surveymaticdb.survey: ~0 rows (approximately)
/*!40000 ALTER TABLE `survey` DISABLE KEYS */;
/*!40000 ALTER TABLE `survey` ENABLE KEYS */;

-- Dumping structure for table surveymaticdb.surveytranslation
CREATE TABLE IF NOT EXISTS `surveytranslation` (
  `SurveyTranslationID` int(11) NOT NULL AUTO_INCREMENT,
  `SurveyID` int(11) NOT NULL DEFAULT 0,
  `Language` varchar(50) NOT NULL DEFAULT '0',
  `Title` varchar(50) NOT NULL DEFAULT '0',
  `Description` varchar(500) NOT NULL DEFAULT '0',
  `Instruction` varchar(500) NOT NULL DEFAULT '0',
  PRIMARY KEY (`SurveyTranslationID`),
  KEY `FK_surveytranslation_survey` (`SurveyID`),
  CONSTRAINT `FK_surveytranslation_survey` FOREIGN KEY (`SurveyID`) REFERENCES `survey` (`SurveyId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table surveymaticdb.surveytranslation: ~0 rows (approximately)
/*!40000 ALTER TABLE `surveytranslation` DISABLE KEYS */;
/*!40000 ALTER TABLE `surveytranslation` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
