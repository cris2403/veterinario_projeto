-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 29-Jun-2023 às 21:22
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
-- Banco de dados: `projeto`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `atomedico`
--

CREATE TABLE `atomedico` (
  `Id` int(12) NOT NULL,
  `Ato` text NOT NULL,
  `Descricao` varchar(250) NOT NULL,
  `Custo` int(25) NOT NULL,
  `DataRegisto` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `atomedico`
--

INSERT INTO `atomedico` (`Id`, `Ato`, `Descricao`, `Custo`, `DataRegisto`) VALUES
(12654, 'cfdx', 'cd', 12, '2023-06-10'),
(13456, 'Consulta', 'hugtf', 12, '2023-06-29');

-- --------------------------------------------------------

--
-- Estrutura da tabela `consulta`
--

CREATE TABLE `consulta` (
  `Id` int(12) NOT NULL,
  `TipoConsulta` text NOT NULL,
  `Colaborador` text NOT NULL,
  `DataConsulta` date NOT NULL,
  `HoraConsulta` varchar(100) NOT NULL,
  `IdRegisto` int(12) NOT NULL,
  `Dono` varchar(100) NOT NULL,
  `Animal` varchar(100) NOT NULL,
  `Contacto` int(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `consulta`
--

INSERT INTO `consulta` (`Id`, `TipoConsulta`, `Colaborador`, `DataConsulta`, `HoraConsulta`, `IdRegisto`, `Dono`, `Animal`, `Contacto`) VALUES
(57, 'Consulta', 'Médico Veterinário', '2023-06-27', '12', 7, 'ronaldo', 'messi', 987654321),
(58, 'Consulta', 'Médico Veterinário', '2023-06-27', '12', 7, 'ronaldo', 'messi', 987654321),
(59, 'Consulta', 'Médico Veterinário', '2023-06-27', '12', 7, 'ronaldo', 'messi', 987654321),
(60, 'Consulta', 'Médico Veterinário', '2023-06-27', '12', 7, 'ronaldo', 'messi', 987654321),
(61, 'Consulta', 'Médico Veterinário', '2023-06-27', '12', 7, 'ronaldo', 'messi', 987654321),
(62, 'Vacinação', 'Médico Veterinário', '2023-06-27', '11', 7, 'Ronaldo', 'messi', 987654321),
(63, 'Consulta', 'Médico Veterinário', '2023-06-27', '11', 7, 'Ronaldo', 'messi', 987654321);

-- --------------------------------------------------------

--
-- Estrutura da tabela `fichamedica`
--

CREATE TABLE `fichamedica` (
  `Id` int(12) NOT NULL,
  `NomeAnimal` varchar(100) NOT NULL,
  `DataAM` date NOT NULL,
  `TipoConsulta` text NOT NULL,
  `NomeColaborador` varchar(100) NOT NULL,
  `Diagnostico` varchar(250) NOT NULL,
  `Peso` decimal(12,0) NOT NULL,
  `Observacoes` varchar(250) NOT NULL,
  `PrescricaoMedica` varchar(100) NOT NULL,
  `DataPVisita` date NOT NULL,
  `Id_RDono` int(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `fichamedica`
--

INSERT INTO `fichamedica` (`Id`, `NomeAnimal`, `DataAM`, `TipoConsulta`, `NomeColaborador`, `Diagnostico`, `Peso`, `Observacoes`, `PrescricaoMedica`, `DataPVisita`, `Id_RDono`) VALUES
(2, 'messi', '2023-06-27', 'Consulta', 'Telmo', 'morreu :(', 45, 'nigga', 'neps', '2024-08-21', 7),
(3, 'messi', '2023-06-27', 'Consulta', 'Telmo', 'morreu :(', 45, 'nigga', 'neps', '2024-08-21', 7),
(4, 'messi', '2023-06-27', 'Consulta', 'ai', 'morreu :(', 45, 'nigga', 'neps', '2024-08-21', 7);

-- --------------------------------------------------------

--
-- Estrutura da tabela `produtos`
--

CREATE TABLE `produtos` (
  `Cod` int(25) NOT NULL,
  `Tipo` text NOT NULL,
  `Descricao` varchar(250) NOT NULL,
  `Quantidade` int(25) NOT NULL,
  `Preco` decimal(50,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `produtos`
--

INSERT INTO `produtos` (`Cod`, `Tipo`, `Descricao`, `Quantidade`, `Preco`) VALUES
(9876543, 'Fármacos	', 'skj', 8, 18);

-- --------------------------------------------------------

--
-- Estrutura da tabela `ranimal`
--

CREATE TABLE `ranimal` (
  `Id_RAnimal` int(12) NOT NULL,
  `Dono` varchar(200) NOT NULL,
  `Nome` varchar(200) NOT NULL,
  `Tipo` varchar(50) NOT NULL,
  `Raca` varchar(50) NOT NULL,
  `Idade` int(12) NOT NULL,
  `Peso` decimal(12,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `ranimal`
--

INSERT INTO `ranimal` (`Id_RAnimal`, `Dono`, `Nome`, `Tipo`, `Raca`, `Idade`, `Peso`) VALUES
(1, '', 'jgh', 'hugyf', 'hugy', 7, 7),
(2, '', 'ijnhb', 'ihu', 'ijhub', 8, 8),
(3, 'cris', 'okkg', 'jihy', 'jih', 8765, 765),
(4, 'giannis', 'ijnhbjgv', 'kbhjg', 'ijhb', 8, 76),
(5, 'ronaldo', 'messi', 'Cão', 'pequena', 1, 1),
(6, 'rui', 'tellmo', 'Hamster', 'india', 8, 100),
(7, 'rui', 'n', 'Gato', 'hy', 7, 7);

-- --------------------------------------------------------

--
-- Estrutura da tabela `registo`
--

CREATE TABLE `registo` (
  `Id_RDono` int(12) NOT NULL,
  `DNome` varchar(200) NOT NULL,
  `DataNascimento` date NOT NULL,
  `NIF` int(50) NOT NULL,
  `Contacto` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `registo`
--

INSERT INTO `registo` (`Id_RDono`, `DNome`, `DataNascimento`, `NIF`, `Contacto`) VALUES
(12, 'vcfd', '2023-06-25', 8765, 7654),
(1, 'cris', '2023-06-25', 87654, 8765),
(77, 'cris', '2023-06-25', 78654, 87865),
(34, 'giannis', '2023-06-25', 765, 7564),
(7, 'ronaldo', '2023-06-25', 987654321, 987654321),
(69, 'rui', '2017-06-13', 987654321, 987654321),
(6, 'cris', '2023-06-26', 2147483647, 987654321),
(99, 'gh', '2023-06-08', 98765432, 33456789),
(69, 'ya', '2023-06-29', 123456789, 987654321);

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
  `Colaborador` text NOT NULL,
  `Contacto` int(9) NOT NULL,
  `DataInicio` date NOT NULL,
  `DataFim` date NOT NULL,
  `Disponibilidade` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `registocolab`
--

INSERT INTO `registocolab` (`Id`, `Nome`, `DataNascimento`, `NIF`, `Tipo`, `Colaborador`, `Contacto`, `DataInicio`, `DataFim`, `Disponibilidade`) VALUES
(9, 'mbape', '2023-06-25', 7272, 'Externo', 'Médico Veterinário', 987654321, '2023-06-25', '2023-06-25', '18h-22h');

-- --------------------------------------------------------

--
-- Estrutura da tabela `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `email` varchar(200) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `users`
--

INSERT INTO `users` (`user_id`, `username`, `email`, `password`) VALUES
(1, 'Admin1', 'admin@gmail.com', '123'),
(2, 'eu', 'eu@gmail.com', '1'),
(3, 'raul', 'reidosciganos@gmail.com', 'ciganadred'),
(4, 'ya', 'ya@ya.com', 'ya');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `consulta`
--
ALTER TABLE `consulta`
  ADD PRIMARY KEY (`Id`);

--
-- Índices para tabela `fichamedica`
--
ALTER TABLE `fichamedica`
  ADD PRIMARY KEY (`Id`);

--
-- Índices para tabela `ranimal`
--
ALTER TABLE `ranimal`
  ADD PRIMARY KEY (`Id_RAnimal`);

--
-- Índices para tabela `registocolab`
--
ALTER TABLE `registocolab`
  ADD PRIMARY KEY (`Id`);

--
-- Índices para tabela `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `consulta`
--
ALTER TABLE `consulta`
  MODIFY `Id` int(12) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=64;

--
-- AUTO_INCREMENT de tabela `fichamedica`
--
ALTER TABLE `fichamedica`
  MODIFY `Id` int(12) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `ranimal`
--
ALTER TABLE `ranimal`
  MODIFY `Id_RAnimal` int(12) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de tabela `registocolab`
--
ALTER TABLE `registocolab`
  MODIFY `Id` int(12) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de tabela `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
