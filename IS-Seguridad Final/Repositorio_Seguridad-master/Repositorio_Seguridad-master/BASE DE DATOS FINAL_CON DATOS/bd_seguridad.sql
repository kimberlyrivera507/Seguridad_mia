-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 23, 2018 at 05:03 AM
-- Server version: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bd_seguridad`
--

-- --------------------------------------------------------

--
-- Table structure for table `aplicacion`
--

CREATE TABLE `aplicacion` (
  `id_aplicacion` int(11) NOT NULL,
  `nombre_aplicacion` varchar(50) NOT NULL,
  `descripcion_aplicacion` varchar(80) NOT NULL,
  `habilitar_aplicacion` tinyint(1) NOT NULL,
  `id_reporte` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `aplicacion`
--

INSERT INTO `aplicacion` (`id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `habilitar_aplicacion`, `id_reporte`) VALUES
(1, 'Caja', 'caja', 0, '1'),
(3, 'Orden de compra', 'OC', 1, '2'),
(4, 'Proveedores', 'proveedor', 1, '3'),
(5, 'Ingreso', 'ingresar', 0, '4'),
(6, 'Movimientos_cliente', 'cliente', 1, '5'),
(7, 'Trans_proveedores', 'proveedores', 0, '6'),
(8, 'Movimientos_prove', 'proveedor', 1, '7'),
(9, 'Trans_cliente', 'cliente', 0, '8'),
(10, 'Reporte_cliente', 'cliente', 0, '9'),
(11, 'Reporte_proveedor', 'proveedor', 1, '10'),
(12, 'reporte_trans_cliente', 'reporte de trasaccion de clientes', 1, '11'),
(13, 'reporte_trans_prov', 'reporte de transaccion de provee', 0, '12'),
(14, 'habitaciones', 'habitacion', 1, '13'),
(15, 'Citas', 'citas', 0, '14'),
(16, 'Folio', 'folio', 0, '15'),
(17, 'Tipo_habitacion', 'tipo de habitacion', 0, '16'),
(18, 'Detalle_habitacion', 'detalle de la habitacion', 1, '18'),
(19, 'Control de demoras', 'control de demoras', 0, '19'),
(20, 'Devolucion', 'devolucion', 0, '20');

-- --------------------------------------------------------

--
-- Table structure for table `bitacora`
--

CREATE TABLE `bitacora` (
  `id_bitacora` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `fecha_bitacora` date NOT NULL,
  `hora_bitacora` time(6) NOT NULL,
  `accion_usuario` varchar(45) NOT NULL,
  `id_aplicacion` int(11) NOT NULL,
  `resultado_bitacora` varchar(45) NOT NULL,
  `error_bitacora` varchar(800) NOT NULL,
  `ip_pc` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `bitacora`
--

INSERT INTO `bitacora` (`id_bitacora`, `id_usuario`, `fecha_bitacora`, `hora_bitacora`, `accion_usuario`, `id_aplicacion`, `resultado_bitacora`, `error_bitacora`, `ip_pc`) VALUES
(5, 3, '2018-02-09', '22:25:41.000000', 'Guardar', 1, 'Exitoso', 'no', '192.168.1.4'),
(6, 3, '2018-02-09', '22:25:52.000000', 'Editar', 1, 'Exitoso', 'no', '192.168.1.4'),
(7, 3, '2018-02-09', '22:27:39.000000', 'Editar', 2, 'Exitoso', 'no', '192.168.1.4'),
(8, 3, '2018-02-09', '22:27:39.000000', 'Editar', 2, 'Exitoso', 'no', '192.168.1.4'),
(9, 3, '2018-02-10', '12:53:56.000000', 'Guardar', 2, 'Exitoso', 'no', '192.168.1.4'),
(10, 3, '2018-02-10', '12:54:48.000000', 'Guardar', 1, 'Exitoso', 'no', '192.168.1.4'),
(11, 3, '2018-02-10', '12:56:28.000000', 'Editar', 4, 'Exitoso', 'no', '192.168.1.4'),
(12, 3, '2018-02-10', '12:56:34.000000', 'Guardar', 4, 'Exitoso', 'no', '192.168.1.4'),
(13, 3, '2018-02-14', '10:57:50.000000', 'Editar', 4, 'Exitoso', 'no', '192.168.43.243'),
(14, 3, '2018-02-14', '10:57:56.000000', 'Guardar', 4, 'Exitoso', 'no', '192.168.43.243'),
(15, 3, '2018-02-14', '11:46:26.000000', 'Guardar', 2, 'Exitoso', 'no', '127.0.0.1'),
(16, 3, '2018-02-14', '11:46:36.000000', 'Guardar', 2, 'Exitoso', 'no', '127.0.0.1'),
(17, 3, '2018-02-14', '11:46:43.000000', 'Guardar', 2, 'Exitoso', 'no', '127.0.0.1'),
(18, 3, '2018-02-14', '11:46:51.000000', 'Guardar', 2, 'Exitoso', 'no', '127.0.0.1'),
(19, 3, '2018-02-14', '11:46:57.000000', 'Guardar', 2, 'Exitoso', 'no', '127.0.0.1'),
(20, 3, '2018-02-14', '11:47:04.000000', 'Guardar', 2, 'Exitoso', 'no', '127.0.0.1'),
(21, 3, '2018-02-14', '11:49:05.000000', 'Guardar', 2, 'Exitoso', 'no', '127.0.0.1'),
(22, 3, '2018-02-14', '11:49:11.000000', 'Guardar', 2, 'Exitoso', 'no', '127.0.0.1'),
(23, 3, '2018-02-14', '11:49:52.000000', 'Guardar', 2, 'Exitoso', 'no', '127.0.0.1'),
(24, 3, '2018-02-14', '11:50:17.000000', 'Guardar', 2, 'Exitoso', 'no', '127.0.0.1'),
(25, 3, '2018-02-14', '11:50:26.000000', 'Guardar', 2, 'Exitoso', 'no', '127.0.0.1'),
(26, 3, '2018-02-14', '11:51:32.000000', 'Guardar', 2, 'Exitoso', 'no', '127.0.0.1'),
(27, 3, '2018-02-14', '11:51:48.000000', 'Guardar', 2, 'Exitoso', 'no', '127.0.0.1'),
(28, 3, '2018-02-14', '11:51:57.000000', 'Guardar', 2, 'Exitoso', 'no', '127.0.0.1'),
(29, 3, '2018-02-14', '11:52:13.000000', 'Guardar', 2, 'Exitoso', 'no', '127.0.0.1'),
(30, 5, '2018-02-16', '20:57:13.000000', 'Guardar', 1, 'Exitoso', 'no', '192.168.1.4'),
(31, 5, '2018-02-16', '20:57:41.000000', 'Guardar', 1, 'Exitoso', 'no', '192.168.1.4'),
(32, 5, '2018-02-16', '20:58:03.000000', 'Eliminar', 1, 'Exitoso', 'no', '192.168.1.4'),
(33, 5, '2018-02-16', '20:58:20.000000', 'Editar', 1, 'Exitoso', 'no', '192.168.1.4'),
(34, 5, '2018-02-16', '21:17:36.000000', 'Guardar', 1, 'Exitoso', 'no', '192.168.1.4'),
(35, 5, '2018-02-16', '21:17:57.000000', 'Guardar', 1, 'Exitoso', 'no', '192.168.1.4'),
(36, 5, '2018-02-16', '21:18:13.000000', 'Guardar', 1, 'Exitoso', 'no', '192.168.1.4'),
(37, 5, '2018-02-16', '21:18:33.000000', 'Guardar', 1, 'Exitoso', 'no', '192.168.1.4'),
(38, 5, '2018-02-16', '21:19:03.000000', 'Guardar', 1, 'Exitoso', 'no', '192.168.1.4'),
(39, 5, '2018-02-16', '21:19:20.000000', 'Guardar', 1, 'Exitoso', 'no', '192.168.1.4'),
(40, 5, '2018-02-16', '21:19:44.000000', 'Guardar', 1, 'Exitoso', 'no', '192.168.1.4'),
(41, 5, '2018-02-16', '21:20:08.000000', 'Guardar', 1, 'Exitoso', 'no', '192.168.1.4'),
(42, 5, '2018-02-16', '21:20:34.000000', 'Guardar', 1, 'Exitoso', 'no', '192.168.1.4'),
(43, 5, '2018-02-16', '21:54:46.000000', 'Guardar', 1, 'Exitoso', 'no', '192.168.1.4'),
(44, 5, '2018-02-16', '21:55:08.000000', 'Guardar', 1, 'Exitoso', 'no', '192.168.1.4'),
(45, 5, '2018-02-16', '21:55:31.000000', 'Guardar', 1, 'Exitoso', 'no', '192.168.1.4'),
(46, 5, '2018-02-16', '21:55:44.000000', 'Guardar', 1, 'Exitoso', 'no', '192.168.1.4'),
(47, 5, '2018-02-16', '21:55:55.000000', 'Guardar', 1, 'Exitoso', 'no', '192.168.1.4'),
(48, 5, '2018-02-16', '21:56:27.000000', 'Guardar', 1, 'Exitoso', 'no', '192.168.1.4'),
(49, 5, '2018-02-16', '21:56:56.000000', 'Guardar', 1, 'Exitoso', 'no', '192.168.1.4'),
(50, 5, '2018-02-16', '21:57:22.000000', 'Guardar', 1, 'Exitoso', 'no', '192.168.1.4'),
(51, 5, '2018-02-16', '21:57:35.000000', 'Guardar', 1, 'Exitoso', 'no', '192.168.1.4'),
(52, 5, '2018-02-17', '23:23:19.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(53, 5, '2018-02-17', '23:23:20.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION)..ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(54, 3, '2018-02-17', '23:26:53.000000', 'Guardar', 4, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_usuario_perfil`, CONSTRAINT `FK_detalle_up_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(55, 5, '2018-02-17', '23:49:58.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(56, 5, '2018-02-17', '23:49:58.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION)..ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(57, 5, '2018-02-18', '00:06:28.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(58, 5, '2018-02-18', '00:06:28.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION)..ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(59, 8, '2018-02-18', '00:09:18.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(60, 8, '2018-02-18', '00:09:18.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION)..ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(61, 6, '2018-02-18', '00:11:20.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(62, 6, '2018-02-18', '00:11:21.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION)..ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(63, 3, '2018-02-18', '00:24:12.000000', 'Editar', 4, 'Exitoso', 'no', '192.168.1.4'),
(64, 3, '2018-02-18', '00:24:14.000000', 'Guardar', 4, 'Exitoso', 'no', '192.168.1.4'),
(65, 8, '2018-02-18', '00:31:35.000000', 'Editar', 4, 'Exitoso', 'no', '192.168.1.4'),
(66, 8, '2018-02-18', '00:31:38.000000', 'Guardar', 4, 'Exitoso', 'no', '192.168.1.4'),
(67, 3, '2018-02-18', '23:11:40.000000', 'Editar', 4, 'Exitoso', 'no', '192.168.1.4'),
(68, 3, '2018-02-18', '23:11:43.000000', 'Guardar', 4, 'Exitoso', 'no', '192.168.1.4'),
(69, 3, '2018-02-18', '23:12:13.000000', 'Editar', 4, 'Exitoso', 'no', '192.168.1.4'),
(70, 3, '2018-02-18', '23:12:19.000000', 'Guardar', 4, 'Exitoso', 'no', '192.168.1.4'),
(71, 3, '2018-02-18', '23:12:44.000000', 'Guardar', 4, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_usuario_perfil`, CONSTRAINT `FK_detalle_up_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(72, 3, '2018-02-18', '23:12:47.000000', 'Guardar', 4, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_usuario_perfil`, CONSTRAINT `FK_detalle_up_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION)..ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_usuario_perfil`, CONSTRAINT `FK_detalle_up_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(73, 5, '2018-02-20', '20:45:36.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(74, 5, '2018-02-20', '20:45:37.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION)..ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(75, 5, '2018-02-20', '20:45:43.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(76, 5, '2018-02-20', '20:45:46.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION)..ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(77, 5, '2018-02-20', '20:45:52.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(78, 5, '2018-02-20', '20:45:53.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION)..ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(79, 5, '2018-02-20', '20:46:26.000000', 'Guardar', 4, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_usuario_perfil`, CONSTRAINT `FK_detalle_up_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(80, 5, '2018-02-20', '20:46:26.000000', 'Guardar', 4, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_usuario_perfil`, CONSTRAINT `FK_detalle_up_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION)..ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_usuario_perfil`, CONSTRAINT `FK_detalle_up_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(81, 5, '2018-02-20', '20:46:29.000000', 'Guardar', 4, 'Exitoso', 'no', '192.168.1.4'),
(82, 5, '2018-02-20', '20:46:35.000000', 'Guardar', 4, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_usuario_perfil`, CONSTRAINT `FK_detalle_up_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(83, 5, '2018-02-20', '20:46:35.000000', 'Guardar', 4, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_usuario_perfil`, CONSTRAINT `FK_detalle_up_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION)..ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_usuario_perfil`, CONSTRAINT `FK_detalle_up_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(84, 5, '2018-02-20', '20:46:40.000000', 'Guardar', 4, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_usuario_perfil`, CONSTRAINT `FK_detalle_up_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION)..ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_usuario_perfil`, CONSTRAINT `FK_detalle_up_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION)..ERROR [23000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Duplicate entry 6-8 for key PRIMARY.', '192.168.1.4'),
(85, 5, '2018-02-21', '23:28:00.000000', 'Editar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Incorrect integer value: Limpieza for column id_perfil at row 1.', '192.168.1.4'),
(86, 5, '2018-02-21', '23:29:54.000000', 'Guardar', 5, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(87, 5, '2018-02-21', '23:29:55.000000', 'Guardar', 5, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION)..ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(88, 6, '2018-02-21', '23:34:07.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(89, 6, '2018-02-21', '23:34:10.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION)..ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(90, 5, '2018-02-22', '10:30:08.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '127.0.0.1'),
(91, 5, '2018-02-22', '10:34:37.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '127.0.0.1'),
(92, 3, '2018-02-22', '10:37:29.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Column id_perfil cannot be null.', '127.0.0.1'),
(93, 3, '2018-02-22', '10:40:20.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Column id_perfil cannot be null.', '127.0.0.1'),
(94, 5, '2018-02-22', '10:43:32.000000', 'Guardar', 5, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '127.0.0.1'),
(95, 5, '2018-02-22', '10:43:34.000000', 'Guardar', 5, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION)..ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '127.0.0.1'),
(96, 5, '2018-02-22', '15:27:23.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Column id_perfil cannot be null.', '192.168.55.240'),
(97, 5, '2018-02-22', '15:27:28.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Column id_perfil cannot be null..ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Column id_perfil cannot be null.', '192.168.55.240'),
(98, 5, '2018-02-22', '15:27:31.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Column id_perfil cannot be null..ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Column id_perfil cannot be null..ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Column id_perfil cannot be null.', '192.168.55.240'),
(99, 5, '2018-02-22', '15:28:16.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Column id_perfil cannot be null.', '192.168.55.240'),
(100, 5, '2018-02-22', '15:28:18.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Column id_perfil cannot be null..ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Column id_perfil cannot be null.', '192.168.55.240'),
(101, 5, '2018-02-22', '15:28:39.000000', 'Guardar', 4, 'No exitoso', '.Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_aplicacion_derecho`, CONSTRAINT `FK_detalle_usuario` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.55.240'),
(102, 5, '2018-02-22', '15:28:56.000000', 'Editar', 4, 'Exitoso', 'no', '192.168.55.240'),
(103, 5, '2018-02-22', '15:29:04.000000', 'Guardar', 4, 'Exitoso', 'no', '192.168.55.240'),
(104, 5, '2018-02-22', '15:36:34.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Column id_perfil cannot be null.', '192.168.55.240'),
(105, 5, '2018-02-22', '15:36:36.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Column id_perfil cannot be null..ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Column id_perfil cannot be null.', '192.168.55.240'),
(106, 5, '2018-02-22', '15:37:50.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Neurologo in where clause.', '192.168.55.240'),
(107, 5, '2018-02-22', '15:37:55.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Neurologo in where clause..ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Neurologo in where clause.', '192.168.55.240'),
(108, 5, '2018-02-22', '15:50:13.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Doctor in where clause.', '192.168.55.240'),
(109, 5, '2018-02-22', '15:50:23.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Doctor in where clause..ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Doctor in where clause.', '192.168.55.240'),
(110, 5, '2018-02-22', '18:57:11.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Maxilofacial in where clause.', '192.168.1.4'),
(111, 5, '2018-02-22', '18:57:15.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Maxilofacial in where clause..ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Maxilofacial in where clause.', '192.168.1.4'),
(112, 5, '2018-02-22', '18:57:17.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Maxilofacial in where clause..ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Maxilofacial in where clause..ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Maxilofacial in where clause.', '192.168.1.4'),
(113, 5, '2018-02-22', '18:58:52.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Doctor in where clause.', '192.168.1.4'),
(114, 5, '2018-02-22', '18:58:55.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Doctor in where clause..ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Doctor in where clause.', '192.168.1.4'),
(115, 5, '2018-02-22', '18:59:17.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Doctor in where clause.', '192.168.1.4'),
(116, 5, '2018-02-22', '18:59:19.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Doctor in where clause..ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Doctor in where clause.', '192.168.1.4'),
(117, 3, '2018-02-22', '19:00:08.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Doctor in where clause.', '192.168.1.4'),
(118, 8, '2018-02-22', '19:01:00.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Nutricionista in where clause.', '192.168.1.4'),
(119, 8, '2018-02-22', '19:01:03.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Nutricionista in where clause..ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Nutricionista in where clause.', '192.168.1.4'),
(120, 8, '2018-02-22', '19:01:13.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Nutricionista in where clause.', '192.168.1.4'),
(121, 8, '2018-02-22', '19:01:15.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Nutricionista in where clause..ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Nutricionista in where clause.', '192.168.1.4'),
(122, 8, '2018-02-22', '19:01:56.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Otorrino in where clause.', '192.168.1.4'),
(123, 8, '2018-02-22', '19:01:58.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Otorrino in where clause..ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Otorrino in where clause.', '192.168.1.4'),
(124, 8, '2018-02-22', '19:02:53.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Maxilofacial in where clause.', '192.168.1.4'),
(125, 8, '2018-02-22', '19:02:59.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Maxilofacial in where clause.', '192.168.1.4'),
(126, 8, '2018-02-22', '19:33:54.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Maxilofacial in where clause.', '192.168.1.4'),
(127, 5, '2018-02-22', '19:37:58.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Nutricionista in where clause.', '192.168.1.4'),
(128, 5, '2018-02-22', '19:38:27.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Nutricionista in where clause..ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Nutricionista in where clause.', '192.168.1.4'),
(129, 5, '2018-02-22', '19:38:32.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Nutricionista in where clause.', '192.168.1.4'),
(130, 5, '2018-02-22', '19:38:37.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Nutricionista in where clause..ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Nutricionista in where clause.', '192.168.1.4'),
(131, 5, '2018-02-22', '19:41:30.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Doctor in where clause.', '192.168.1.4'),
(132, 5, '2018-02-22', '19:41:40.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Doctor in where clause..ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Doctor in where clause.', '192.168.1.4'),
(133, 5, '2018-02-22', '19:42:52.000000', 'Guardar', 4, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_usuario_perfil`, CONSTRAINT `FK_detalle_up_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(134, 5, '2018-02-22', '19:49:31.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Enfermera in where clause.', '192.168.1.4'),
(135, 5, '2018-02-22', '19:50:11.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Enfermera in where clause..ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Enfermera in where clause.', '192.168.1.4'),
(136, 5, '2018-02-22', '19:58:43.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Dermatologo in where clause.', '192.168.1.4'),
(137, 5, '2018-02-22', '19:58:46.000000', 'Guardar', 3, 'No exitoso', '.ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Dermatologo in where clause..ERROR [42S22] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Unknown column Dermatologo in where clause.', '192.168.1.4'),
(138, 5, '2018-02-22', '20:05:40.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(139, 5, '2018-02-22', '20:05:43.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION)..ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_perfil_aplicacion`, CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(140, 5, '2018-02-22', '20:08:40.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Column id_perfil cannot be null.', '192.168.1.4'),
(141, 5, '2018-02-22', '20:08:43.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Column id_perfil cannot be null..ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Column id_perfil cannot be null.', '192.168.1.4'),
(142, 5, '2018-02-22', '20:09:41.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Column id_perfil cannot be null.', '192.168.1.4'),
(143, 5, '2018-02-22', '20:11:42.000000', 'Guardar', 3, 'Exitoso', 'no', '192.168.1.4'),
(144, 8, '2018-02-22', '20:16:16.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Column id_perfil cannot be null.', '192.168.1.4'),
(145, 8, '2018-02-22', '20:16:24.000000', 'Guardar', 3, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Column id_perfil cannot be null.', '192.168.1.4'),
(146, 5, '2018-02-22', '20:27:19.000000', 'Guardar', 3, 'Exitoso', 'no', '192.168.1.4'),
(147, 5, '2018-02-22', '20:27:42.000000', 'Guardar', 3, 'No exitoso', '.ERROR [23000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Duplicate entry 17-1 for key PRIMARY.', '192.168.1.4'),
(148, 5, '2018-02-22', '20:27:49.000000', 'Guardar', 3, 'Exitoso', 'no', '192.168.1.4'),
(149, 5, '2018-02-22', '20:27:55.000000', 'Guardar', 3, 'No exitoso', '.ERROR [23000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Duplicate entry 17-1 for key PRIMARY..ERROR [23000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Duplicate entry 17-20 for key PRIMARY.', '192.168.1.4'),
(150, 5, '2018-02-22', '20:29:22.000000', 'Guardar', 4, 'Exitoso', 'no', '192.168.1.4'),
(151, 5, '2018-02-22', '20:30:21.000000', 'Editar', 4, 'Exitoso', 'no', '192.168.1.4'),
(152, 5, '2018-02-22', '20:30:25.000000', 'Guardar', 4, 'Exitoso', 'no', '192.168.1.4'),
(153, 5, '2018-02-22', '20:51:13.000000', 'Guardar', 3, 'Exitoso', 'no', '192.168.1.4'),
(154, 5, '2018-02-22', '20:51:23.000000', 'Guardar', 3, 'No exitoso', '.ERROR [23000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Duplicate entry 8-1 for key PRIMARY.', '192.168.1.4'),
(155, 5, '2018-02-22', '20:52:14.000000', 'Editar', 4, 'Exitoso', 'no', '192.168.1.4'),
(156, 5, '2018-02-22', '20:52:17.000000', 'Guardar', 4, 'Exitoso', 'no', '192.168.1.4'),
(157, 6, '2018-02-22', '20:58:12.000000', 'Guardar', 4, 'No exitoso', '.ERROR [23000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Duplicate entry 6-8 for key PRIMARY.', '192.168.1.4'),
(158, 6, '2018-02-22', '20:58:17.000000', 'Guardar', 4, 'No exitoso', '.ERROR [23000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Duplicate entry 6-8 for key PRIMARY..ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_usuario_perfil`, CONSTRAINT `FK_detalle_up_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(159, 6, '2018-02-22', '20:58:23.000000', 'Guardar', 4, 'No exitoso', '.ERROR [23000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Duplicate entry 6-8 for key PRIMARY.', '192.168.1.4'),
(160, 6, '2018-02-22', '20:58:27.000000', 'Guardar', 4, 'No exitoso', '.ERROR [23000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Duplicate entry 6-8 for key PRIMARY..ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_usuario_perfil`, CONSTRAINT `FK_detalle_up_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(161, 5, '2018-02-22', '21:07:03.000000', 'Guardar', 3, 'Exitoso', 'no', '192.168.1.4'),
(162, 5, '2018-02-22', '21:07:11.000000', 'Guardar', 3, 'No exitoso', '.ERROR [23000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Duplicate entry 16-1 for key PRIMARY.', '192.168.1.4'),
(163, 5, '2018-02-22', '21:07:15.000000', 'Guardar', 3, 'Exitoso', 'no', '192.168.1.4'),
(164, 5, '2018-02-22', '21:07:20.000000', 'Guardar', 3, 'No exitoso', '.ERROR [23000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Duplicate entry 16-1 for key PRIMARY..ERROR [23000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Duplicate entry 16-20 for key PRIMARY.', '192.168.1.4'),
(165, 5, '2018-02-22', '21:07:35.000000', 'Guardar', 3, 'No exitoso', '.ERROR [23000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Duplicate entry 16-1 for key PRIMARY.', '192.168.1.4'),
(166, 5, '2018-02-22', '21:07:38.000000', 'Guardar', 3, 'No exitoso', '.ERROR [23000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Duplicate entry 16-1 for key PRIMARY..ERROR [23000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Duplicate entry 16-1 for key PRIMARY.', '192.168.1.4'),
(167, 5, '2018-02-22', '21:07:40.000000', 'Guardar', 3, 'No exitoso', '.ERROR [23000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Duplicate entry 16-1 for key PRIMARY..ERROR [23000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Duplicate entry 16-1 for key PRIMARY..ERROR [23000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Duplicate entry 16-20 for key PRIMARY.', '192.168.1.4'),
(168, 5, '2018-02-22', '21:07:43.000000', 'Guardar', 3, 'No exitoso', '.ERROR [23000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Duplicate entry 16-1 for key PRIMARY..ERROR [23000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Duplicate entry 16-1 for key PRIMARY..ERROR [23000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Duplicate entry 16-20 for key PRIMARY..ERROR [23000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Duplicate entry 16-20 for key PRIMARY.', '192.168.1.4'),
(169, 5, '2018-02-22', '21:07:53.000000', 'Guardar', 3, 'Exitoso', 'no', '192.168.1.4'),
(170, 5, '2018-02-22', '21:07:57.000000', 'Guardar', 3, 'No exitoso', '.ERROR [23000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Duplicate entry 10-1 for key PRIMARY.', '192.168.1.4'),
(171, 5, '2018-02-22', '21:08:01.000000', 'Guardar', 3, 'Exitoso', 'no', '192.168.1.4'),
(172, 5, '2018-02-22', '21:08:02.000000', 'Guardar', 3, 'No exitoso', '.ERROR [23000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Duplicate entry 10-1 for key PRIMARY..ERROR [23000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Duplicate entry 10-20 for key PRIMARY.', '192.168.1.4'),
(173, 7, '2018-02-22', '21:09:35.000000', 'Guardar', 3, 'Exitoso', 'no', '192.168.1.4'),
(174, 7, '2018-02-22', '21:09:37.000000', 'Guardar', 3, 'Exitoso', 'no', '192.168.1.4'),
(175, 7, '2018-02-22', '21:10:44.000000', 'Guardar', 4, 'Exitoso', 'no', '192.168.1.4'),
(176, 5, '2018-02-22', '21:49:15.000000', 'Guardar', 3, 'Exitoso', 'no', '192.168.1.4'),
(177, 5, '2018-02-22', '21:49:25.000000', 'Editar', 4, 'Exitoso', 'no', '192.168.1.4'),
(178, 5, '2018-02-22', '21:49:30.000000', 'Guardar', 4, 'Exitoso', 'no', '192.168.1.4'),
(179, 5, '2018-02-22', '21:50:02.000000', 'Guardar', 4, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_usuario_perfil`, CONSTRAINT `FK_detalle_up_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(180, 5, '2018-02-22', '21:50:21.000000', 'Guardar', 4, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_usuario_perfil`, CONSTRAINT `FK_detalle_up_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(181, 9, '2018-02-22', '22:04:01.000000', 'Guardar', 3, 'Exitoso', 'no', '192.168.1.4'),
(182, 9, '2018-02-22', '22:04:07.000000', 'Editar', 4, 'Exitoso', 'no', '192.168.1.4'),
(183, 9, '2018-02-22', '22:04:14.000000', 'Guardar', 4, 'Exitoso', 'no', '192.168.1.4'),
(184, 9, '2018-02-22', '22:05:37.000000', 'Guardar', 4, 'Exitoso', 'no', '192.168.1.4'),
(185, 9, '2018-02-22', '22:28:55.000000', 'Guardar', 4, 'No exitoso', '.ERROR [HY000] [MySQL][ODBC 3.51 Driver][mysqld-5.7.14]Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_usuario_perfil`, CONSTRAINT `FK_detalle_up_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(186, 6, '2018-02-22', '22:33:02.000000', 'Guardar', 3, 'Exitoso', 'no', '192.168.1.4'),
(187, 6, '2018-02-22', '22:33:15.000000', 'Editar', 4, 'Exitoso', 'no', '192.168.1.4'),
(188, 6, '2018-02-22', '22:33:19.000000', 'Guardar', 4, 'Exitoso', 'no', '192.168.1.4'),
(189, 6, '2018-02-22', '22:34:20.000000', 'Guardar', 4, 'Exitoso', 'no', '192.168.1.4'),
(190, 6, '2018-02-22', '22:34:39.000000', 'Editar', 4, 'Exitoso', 'no', '192.168.1.4'),
(191, 8, '2018-02-22', '22:41:39.000000', 'Guardar', 3, 'Exitoso', 'no', '192.168.1.4'),
(192, 8, '2018-02-22', '22:41:49.000000', 'Editar', 4, 'Exitoso', 'no', '192.168.1.4'),
(193, 8, '2018-02-22', '22:41:57.000000', 'Guardar', 5, 'No exitoso', '.Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_aplicacion_derecho`, CONSTRAINT `FK_detalle_usuario` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(194, 8, '2018-02-22', '22:42:05.000000', 'Guardar', 5, 'No exitoso', '.Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_aplicacion_derecho`, CONSTRAINT `FK_detalle_usuario` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION)..Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_aplicacion_derecho`, CONSTRAINT `FK_detalle_usuario` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(195, 8, '2018-02-22', '22:42:08.000000', 'Editar', 4, 'Exitoso', 'no', '192.168.1.4'),
(196, 8, '2018-02-22', '22:42:11.000000', 'Guardar', 4, 'Exitoso', 'no', '192.168.1.4'),
(197, 8, '2018-02-22', '22:42:13.000000', 'Editar', 4, 'Exitoso', 'no', '192.168.1.4'),
(198, 8, '2018-02-22', '22:42:16.000000', 'Guardar', 5, 'No exitoso', '.Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_aplicacion_derecho`, CONSTRAINT `FK_detalle_usuario` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION)..Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_aplicacion_derecho`, CONSTRAINT `FK_detalle_usuario` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION)..Cannot add or update a child row: a foreign key constraint fails (`bd_seguridad`.`detalle_aplicacion_derecho`, CONSTRAINT `FK_detalle_usuario` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION).', '192.168.1.4'),
(199, 8, '2018-02-22', '22:42:22.000000', 'Guardar', 4, 'Exitoso', 'no', '192.168.1.4'),
(200, 5, '2018-02-22', '22:44:35.000000', 'Guardar', 4, 'Exitoso', 'no', '192.168.1.4'),
(201, 5, '2018-02-22', '22:44:41.000000', 'Editar', 4, 'Exitoso', 'no', '192.168.1.4'),
(202, 5, '2018-02-22', '22:44:45.000000', 'Guardar', 5, 'Exitoso', 'no', '192.168.1.4'),
(203, 5, '2018-02-22', '22:45:15.000000', 'Guardar', 3, 'Exitoso', 'no', '192.168.1.4'),
(204, 5, '2018-02-22', '22:45:16.000000', 'Guardar', 3, 'Exitoso', 'no', '192.168.1.4');

-- --------------------------------------------------------

--
-- Table structure for table `bitacora_app`
--

CREATE TABLE `bitacora_app` (
  `id_aplicacion` int(11) NOT NULL,
  `desc_app` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `bitacora_app`
--

INSERT INTO `bitacora_app` (`id_aplicacion`, `desc_app`) VALUES
(1, 'Aplicaciones'),
(2, 'Perfiles'),
(3, 'Asignacion de App a Perfiles'),
(4, 'Asignacion de Perfil a Usuarios'),
(5, 'Asignacion Derechos');

-- --------------------------------------------------------

--
-- Table structure for table `detalle_aplicacion_derecho`
--

CREATE TABLE `detalle_aplicacion_derecho` (
  `id_usuario` int(11) NOT NULL,
  `id_aplicacion` int(11) NOT NULL,
  `ingresar` tinyint(1) NOT NULL,
  `modificar` tinyint(1) NOT NULL,
  `eliminar` tinyint(1) NOT NULL,
  `imprimir` tinyint(1) NOT NULL,
  `consultar` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `detalle_aplicacion_derecho`
--

INSERT INTO `detalle_aplicacion_derecho` (`id_usuario`, `id_aplicacion`, `ingresar`, `modificar`, `eliminar`, `imprimir`, `consultar`) VALUES
(9, 20, 1, 1, 0, 0, 0),
(5, 9, 1, 1, 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `detalle_perfil_aplicacion`
--

CREATE TABLE `detalle_perfil_aplicacion` (
  `id_perfil` int(11) NOT NULL,
  `id_aplicacion` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `detalle_perfil_aplicacion`
--

INSERT INTO `detalle_perfil_aplicacion` (`id_perfil`, `id_aplicacion`) VALUES
(7, 1),
(8, 1),
(10, 1),
(15, 1),
(16, 1),
(17, 1),
(5, 3),
(5, 6),
(13, 9),
(13, 10),
(5, 15),
(13, 16),
(10, 20),
(15, 20),
(16, 20),
(17, 20);

-- --------------------------------------------------------

--
-- Table structure for table `detalle_usuario_perfil`
--

CREATE TABLE `detalle_usuario_perfil` (
  `id_usuario` int(11) NOT NULL,
  `id_perfil` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `detalle_usuario_perfil`
--

INSERT INTO `detalle_usuario_perfil` (`id_usuario`, `id_perfil`) VALUES
(6, 6),
(6, 9),
(7, 15),
(9, 16);

-- --------------------------------------------------------

--
-- Table structure for table `perfil`
--

CREATE TABLE `perfil` (
  `id_perfil` int(11) NOT NULL,
  `nombre_perfil` varchar(50) NOT NULL,
  `descripcion_perfil` varchar(80) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `perfil`
--

INSERT INTO `perfil` (`id_perfil`, `nombre_perfil`, `descripcion_perfil`) VALUES
(5, 'Doctor', ''),
(6, 'Nutricionista', ''),
(7, 'Enfermera', ''),
(8, 'Cirujano', ''),
(9, 'Dentista', ''),
(10, 'Secretaria', ''),
(11, 'Oncologia', ''),
(12, 'Ginecologo', ''),
(13, 'Limpieza', ''),
(14, 'Maxilofacial', ''),
(15, 'Neurologo', ''),
(16, 'Auxiliares', ''),
(17, 'Pediatra', ''),
(18, 'Otorrino', ''),
(19, 'Dermatologo', '');

-- --------------------------------------------------------

--
-- Table structure for table `usuario`
--

CREATE TABLE `usuario` (
  `id_usuario` int(11) NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `nombre_usuario` varchar(50) NOT NULL,
  `apellido_usuario` varchar(50) NOT NULL,
  `correo_usuario` varchar(45) DEFAULT NULL,
  `telefono_usuario` int(8) DEFAULT NULL,
  `contrasena` blob
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `usuario`
--

INSERT INTO `usuario` (`id_usuario`, `usuario`, `nombre_usuario`, `apellido_usuario`, `correo_usuario`, `telefono_usuario`, `contrasena`) VALUES
(3, 'ale', 'kimberly', 'gonzalez', 'jujfjh', 2343243, 0xbe5c2c48ca3b30f56105ffbcc25ec217),
(5, 'kim', 'Kimberly', 'Rivera', 'kim@gmail.com', 12345678, 0x450c9153ccce2564be9670f409b4ced6),
(6, 'adriana', 'Adriana', 'Ruiz', 'adriana@gmail.com', 12345678, 0xb09085d175fd9a8fcacf7c4704bab697),
(7, 'werner', 'Werner', 'Ovalle', 'werner@gmail.com', 12345678, 0x67b768abd9221254402935595bf8edf7),
(8, 'raul', 'Raul', 'Portillo', 'raul@gmail.com', 12345678, 0x093a0e51d9b736cea3348a99609ca9e3),
(9, 'carlos', 'Carlos', 'Reyes', 'carlos@gmail.com', 12345678, 0x04171ecbd69c4a9b7cfd48b3327d4c87),
(10, 'tefy', 'tefy', 'ruiz', 'tefyta', 123213, 0x4b57d0ba2590fc3712d42c4c8ef36dab);

-- --------------------------------------------------------

--
-- Stand-in structure for view `vista_bitacora`
-- (See below for the actual view)
--
CREATE TABLE `vista_bitacora` (
`usuario` varchar(50)
,`fecha_bitacora` date
,`hora_bitacora` time(6)
,`accion_usuario` varchar(45)
,`desc_app` varchar(45)
,`resultado_bitacora` varchar(45)
,`error_bitacora` varchar(800)
,`ip_pc` varchar(45)
);

-- --------------------------------------------------------

--
-- Structure for view `vista_bitacora`
--
DROP TABLE IF EXISTS `vista_bitacora`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vista_bitacora`  AS  select `u`.`usuario` AS `usuario`,`b`.`fecha_bitacora` AS `fecha_bitacora`,`b`.`hora_bitacora` AS `hora_bitacora`,`b`.`accion_usuario` AS `accion_usuario`,`ap`.`desc_app` AS `desc_app`,`b`.`resultado_bitacora` AS `resultado_bitacora`,`b`.`error_bitacora` AS `error_bitacora`,`b`.`ip_pc` AS `ip_pc` from ((`usuario` `u` join `bitacora` `b` on((`b`.`id_usuario` = `u`.`id_usuario`))) join `bitacora_app` `ap` on((`b`.`id_aplicacion` = `ap`.`id_aplicacion`))) ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `aplicacion`
--
ALTER TABLE `aplicacion`
  ADD PRIMARY KEY (`id_aplicacion`);

--
-- Indexes for table `bitacora`
--
ALTER TABLE `bitacora`
  ADD PRIMARY KEY (`id_bitacora`),
  ADD KEY `FK_bitacora_usuario_idx` (`id_usuario`),
  ADD KEY `Fk_app_idx` (`id_aplicacion`);

--
-- Indexes for table `bitacora_app`
--
ALTER TABLE `bitacora_app`
  ADD PRIMARY KEY (`id_aplicacion`);

--
-- Indexes for table `detalle_aplicacion_derecho`
--
ALTER TABLE `detalle_aplicacion_derecho`
  ADD KEY `FK_detalle_usuario_idx` (`id_usuario`),
  ADD KEY `FK_detalle_aplicacion2` (`id_aplicacion`);

--
-- Indexes for table `detalle_perfil_aplicacion`
--
ALTER TABLE `detalle_perfil_aplicacion`
  ADD PRIMARY KEY (`id_perfil`,`id_aplicacion`),
  ADD KEY `FK_detalle_aplicacion_idx` (`id_aplicacion`);

--
-- Indexes for table `detalle_usuario_perfil`
--
ALTER TABLE `detalle_usuario_perfil`
  ADD PRIMARY KEY (`id_usuario`,`id_perfil`),
  ADD KEY `FK_detalle_up_perfil_idx` (`id_perfil`);

--
-- Indexes for table `perfil`
--
ALTER TABLE `perfil`
  ADD PRIMARY KEY (`id_perfil`),
  ADD UNIQUE KEY `nombre_perfil_UNIQUE` (`nombre_perfil`);

--
-- Indexes for table `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id_usuario`),
  ADD UNIQUE KEY `usuario_UNIQUE` (`usuario`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `aplicacion`
--
ALTER TABLE `aplicacion`
  MODIFY `id_aplicacion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
--
-- AUTO_INCREMENT for table `bitacora`
--
ALTER TABLE `bitacora`
  MODIFY `id_bitacora` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=205;
--
-- AUTO_INCREMENT for table `perfil`
--
ALTER TABLE `perfil`
  MODIFY `id_perfil` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
--
-- AUTO_INCREMENT for table `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `bitacora`
--
ALTER TABLE `bitacora`
  ADD CONSTRAINT `FK_bitacora_usuario` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `Fk_app` FOREIGN KEY (`id_aplicacion`) REFERENCES `bitacora_app` (`id_aplicacion`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `detalle_aplicacion_derecho`
--
ALTER TABLE `detalle_aplicacion_derecho`
  ADD CONSTRAINT `FK_detalle_aplicacion2` FOREIGN KEY (`id_aplicacion`) REFERENCES `aplicacion` (`id_aplicacion`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `FK_detalle_usuario` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `detalle_perfil_aplicacion`
--
ALTER TABLE `detalle_perfil_aplicacion`
  ADD CONSTRAINT `FK_detalle_aplicacion` FOREIGN KEY (`id_aplicacion`) REFERENCES `aplicacion` (`id_aplicacion`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `FK_detalle_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `detalle_usuario_perfil`
--
ALTER TABLE `detalle_usuario_perfil`
  ADD CONSTRAINT `FK_detalle_up_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `FK_detalle_up_usuario` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
