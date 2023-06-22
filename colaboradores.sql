-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 22-Jun-2023 às 22:31
-- Versão do servidor: 10.4.28-MariaDB
-- versão do PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `colaboradores`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `registocolab`
--

CREATE TABLE `registocolab` (
  `Id` int(12) NOT NULL,
  `Nome` varchar(200) NOT NULL,
  `DataNascimento` date NOT NULL,
  `NIF` int(50) NOT NULL,
  `Tipo` text NOT NULL,
  `Funcao` text NOT NULL,
  `Contacto` int(9) NOT NULL,
  `DataInicio` date NOT NULL,
  `DataFim` date NOT NULL,
  `Disponibilidade` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `registocolab`
--

INSERT INTO `registocolab` (`Id`, `Nome`, `DataNascimento`, `NIF`, `Tipo`, `Funcao`, `Contacto`, `DataInicio`, `DataFim`, `Disponibilidade`) VALUES
(1, 'admin', '2003-10-31', 123456789, 'Interno', 'Médico Veterinário', 987654321, '2009-06-22', '2023-06-22', 'Todos os dias das 9h00 até às 11h00');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `registocolab`
--
ALTER TABLE `registocolab`
  ADD PRIMARY KEY (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
