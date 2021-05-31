-- --------------------------------------------------------
-- Host:                         localhost
-- Versión del servidor:         8.0.24 - MySQL Community Server - GPL
-- SO del servidor:              Win64
-- HeidiSQL Versión:             11.1.0.6116
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para agencia_seguros
CREATE DATABASE IF NOT EXISTS `agencia_seguros` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_spanish_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `agencia_seguros`;

-- Volcando estructura para tabla agencia_seguros.cliente
CREATE TABLE IF NOT EXISTS `cliente` (
  `DNI` varchar(9) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `Nombre` varchar(50) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `Apellidos` varchar(100) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `Telefono` varchar(15) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `Localidad` varchar(255) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `CP` varchar(5) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `Provincia` varchar(50) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `Tipo_cliente` varchar(15) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `ID_Cliente` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`DNI`) USING BTREE,
  KEY `ID_Cliente` (`ID_Cliente`),
  CONSTRAINT `CHK_Tipo_Cli` CHECK (((`Tipo_cliente` = _utf8mb3'Empresa') or (`Tipo_cliente` = _utf8mb3'Particular')))
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb3 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla agencia_seguros.municipios
CREATE TABLE IF NOT EXISTS `municipios` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `provincia` int NOT NULL,
  `municipio` varchar(255) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_municipios_provincias` (`provincia`)
) ENGINE=InnoDB AUTO_INCREMENT=8123 DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla agencia_seguros.poliza
CREATE TABLE IF NOT EXISTS `poliza` (
  `numero` varchar(50) COLLATE utf8_spanish_ci NOT NULL DEFAULT '',
  `importe` int NOT NULL,
  `fecha` date NOT NULL,
  `estado` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `observaciones` varchar(255) COLLATE utf8_spanish_ci DEFAULT NULL,
  `ID_Cliente` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`numero`),
  KEY `ID_Cliente` (`ID_Cliente`),
  CONSTRAINT `FK_poliza_cliente` FOREIGN KEY (`ID_Cliente`) REFERENCES `cliente` (`ID_Cliente`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `chk_estado` CHECK (((`estado` = _utf8mb3'cobrada') or (`estado` = _utf8mb3'a cuenta') or (`estado` = _utf8mb3'liquidada') or (`estado` = _utf8mb3'preanulada') or (`estado` = _utf8mb3'anulada')))
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla agencia_seguros.provincias
CREATE TABLE IF NOT EXISTS `provincias` (
  `id` int NOT NULL AUTO_INCREMENT,
  `provincia` varchar(255) CHARACTER SET latin1 COLLATE latin1_spanish_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla agencia_seguros.usuario
CREATE TABLE IF NOT EXISTS `usuario` (
  `id_usuario` int NOT NULL AUTO_INCREMENT,
  `nombre_usuario` varchar(255) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `pass_usuario` varchar(255) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`id_usuario`),
  UNIQUE KEY `nombre_usuario` (`nombre_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
