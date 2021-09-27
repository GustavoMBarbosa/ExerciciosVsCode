-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 27-Set-2021 às 23:23
-- Versão do servidor: 8.0.21
-- versão do PHP: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `cursos_bd`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbl_curso`
--

DROP TABLE IF EXISTS `tbl_curso`;
CREATE TABLE IF NOT EXISTS `tbl_curso` (
  `codigo` int NOT NULL AUTO_INCREMENT,
  `nomeCurso` varchar(40) NOT NULL,
  `conteudo` varchar(200) NOT NULL,
  `valorMensalidade` double NOT NULL,
  `cargaHoraria` int NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `tbl_curso`
--

INSERT INTO `tbl_curso` (`codigo`, `nomeCurso`, `conteudo`, `valorMensalidade`, `cargaHoraria`) VALUES
(2, 'a', 'b', 3, 2),
(3, 'a', 'a', 3, 4);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbl_professor`
--

DROP TABLE IF EXISTS `tbl_professor`;
CREATE TABLE IF NOT EXISTS `tbl_professor` (
  `codigo` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(40) NOT NULL,
  `valorHoraAula` double NOT NULL,
  `telefone` varchar(20) NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `tbl_professor`
--

INSERT INTO `tbl_professor` (`codigo`, `nome`, `valorHoraAula`, `telefone`) VALUES
(2, 'b', 2, '3');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbl_turma`
--

DROP TABLE IF EXISTS `tbl_turma`;
CREATE TABLE IF NOT EXISTS `tbl_turma` (
  `codigo` int NOT NULL AUTO_INCREMENT,
  `idCurso` int NOT NULL,
  `dataInicio` varchar(10) NOT NULL,
  `dataTermino` varchar(10) NOT NULL,
  `horaInicio` varchar(5) NOT NULL,
  `horaTermino` varchar(5) NOT NULL,
  `idProfessor` int NOT NULL,
  PRIMARY KEY (`codigo`),
  KEY `idCurso` (`idCurso`),
  KEY `idProfessor` (`idProfessor`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `tbl_turma`
--

INSERT INTO `tbl_turma` (`codigo`, `idCurso`, `dataInicio`, `dataTermino`, `horaInicio`, `horaTermino`, `idProfessor`) VALUES
(3, 1, '27/09/2021', '27/09/2021', '11:50', '11:55', 2);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
