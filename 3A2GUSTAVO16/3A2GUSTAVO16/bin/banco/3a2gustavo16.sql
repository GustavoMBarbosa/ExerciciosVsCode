-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 20-Ago-2021 às 20:12
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
-- Banco de dados: `3a2gustavo16`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `computador`
--

DROP TABLE IF EXISTS `computador`;
CREATE TABLE IF NOT EXISTS `computador` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `memoria` varchar(100) NOT NULL,
  `disco_rigido` varchar(100) NOT NULL,
  `processador` varchar(100) NOT NULL,
  `marca` varchar(100) NOT NULL,
  `placa_mae` varchar(100) NOT NULL,
  `ano` int NOT NULL,
  `status` varchar(100) NOT NULL,
  `tipo_defeito` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `computador`
--

INSERT INTO `computador` (`id`, `nome`, `memoria`, `disco_rigido`, `processador`, `marca`, `placa_mae`, `ano`, `status`, `tipo_defeito`) VALUES
(7, 'pcdaora', '8gb', '500gb', 'i7', 'rocket', 'asus', 4, 'Com defeito', 'não liga'),
(8, 'pclindo', '16', '1tb', 'i9', 'rockets', 'asus', 0, 'Funcionando', 'nenhum'),
(9, 'pcbonito', '4gb', '250gb', 'i3', 'lixo', 'am4', 5, 'Com defeito', 'pegando fogo');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
