-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         5.6.23 - MySQL Community Server (GPL)
-- SO del servidor:              Win64
-- HeidiSQL Versión:             9.3.0.4984
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Volcando estructura de base de datos para termostato
CREATE DATABASE IF NOT EXISTS `termostato` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `termostato`;


-- Volcando estructura para tabla termostato.logs
CREATE TABLE IF NOT EXISTS `logs` (
  `log` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `usuario` varchar(20) NOT NULL DEFAULT 'lol',
  `grados` int(11) NOT NULL DEFAULT '0',
  `fechaHora` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`log`),
  UNIQUE KEY `log` (`log`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla termostato.logs: ~4 rows (aproximadamente)
/*!40000 ALTER TABLE `logs` DISABLE KEYS */;
REPLACE INTO `logs` (`log`, `usuario`, `grados`, `fechaHora`) VALUES
	(1, 'yugi', 14, '2016-08-12 03:05:29'),
	(2, 'tamez', 7, '2016-08-12 03:05:57'),
	(3, 'cheno', 16, '2016-08-12 03:06:15'),
	(4, 'tamez', 99, '2016-08-12 03:07:46');
/*!40000 ALTER TABLE `logs` ENABLE KEYS */;


-- Volcando estructura para tabla termostato.usuarios
CREATE TABLE IF NOT EXISTS `usuarios` (
  `usuario` varchar(20) NOT NULL DEFAULT 'lol',
  `password` varchar(20) NOT NULL DEFAULT 'lol',
  `admin` varchar(1) NOT NULL DEFAULT 'n',
  PRIMARY KEY (`usuario`),
  UNIQUE KEY `usuario` (`usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla termostato.usuarios: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
REPLACE INTO `usuarios` (`usuario`, `password`, `admin`) VALUES
	('cheno', '12345', 'n'),
	('tamez', '1234', 's'),
	('yugi', '1234', 'n');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
