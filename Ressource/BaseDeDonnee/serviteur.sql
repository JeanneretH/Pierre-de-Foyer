-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Dim 24 Janvier 2016 à 18:06
-- Version du serveur :  10.1.9-MariaDB
-- Version de PHP :  5.6.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `pierredefoyer`
--

-- --------------------------------------------------------

--
-- Structure de la table `serviteur`
--

CREATE TABLE `serviteur` (
  `Id` int(11) NOT NULL,
  `Mana` int(255) NOT NULL,
  `Description` varchar(255) NOT NULL,
  `Heros` varchar(255) NOT NULL,
  `Nom` varchar(255) NOT NULL,
  `Attaque` int(255) NOT NULL,
  `PointDeVie` int(255) NOT NULL,
  `Provocation` varchar(255) NOT NULL,
  `Charge` varchar(255) NOT NULL,
  `Image` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `serviteur`
--

INSERT INTO `serviteur` (`Id`, `Mana`, `Description`, `Heros`, `Nom`, `Attaque`, `PointDeVie`, `Provocation`, `Charge`, `Image`) VALUES
(1, 2, 'Tous les sorts adverse coûte 0.', 'Test', 'Millouse', 4, 4, 'false', 'false', 'Millouse');

--
-- Index pour les tables exportées
--

--
-- Index pour la table `serviteur`
--
ALTER TABLE `serviteur`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `serviteur`
--
ALTER TABLE `serviteur`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
