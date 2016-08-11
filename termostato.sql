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


-- Volcando estructura para tabla termostato.log
CREATE TABLE IF NOT EXISTS `log` (
  `log` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `usuario` varchar(20) NOT NULL DEFAULT 'lol',
  `movimiento` varchar(20) NOT NULL DEFAULT 'lol',
  `fechaHora` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`log`),
  UNIQUE KEY `log` (`log`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla termostato.log: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `log` DISABLE KEYS */;
/*!40000 ALTER TABLE `log` ENABLE KEYS */;


-- Volcando estructura para tabla termostato.usuarios
CREATE TABLE IF NOT EXISTS `usuarios` (
  `usuario` varchar(20) NOT NULL DEFAULT 'lol',
  `password` varchar(20) NOT NULL DEFAULT 'lol',
  `admin` varchar(1) NOT NULL DEFAULT 'n',
  PRIMARY KEY (`usuario`),
  UNIQUE KEY `usuario` (`usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla termostato.usuarios: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
REPLACE INTO `usuarios` (`usuario`, `password`, `admin`) VALUES
	('cheno', '12345', 'n'),
	('tamez', '1234', 's'),
	('yugi', '1234', 'n');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
