-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : lun. 11 mai 2026 à 10:18
-- Version du serveur : 8.4.7
-- Version de PHP : 8.3.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek86`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(2, '2025-05-06 15:43:34', '2026-01-02 07:46:21', 2),
(2, '2025-05-09 05:10:33', '2025-11-28 13:52:42', 3),
(9, '2025-07-30 05:57:20', '2025-12-14 07:28:21', 3),
(6, '2025-06-09 15:40:22', '2026-01-12 01:24:58', 4),
(6, '2025-07-27 06:52:38', '2026-04-06 12:52:48', 2),
(8, '2025-08-24 06:59:47', '2026-01-19 01:09:48', 2),
(5, '2025-06-12 05:05:30', '2026-02-24 21:09:16', 2),
(4, '2025-06-25 06:36:47', '2025-12-27 16:36:57', 1),
(4, '2025-07-06 07:02:16', '2025-12-23 19:39:50', 1),
(7, '2025-08-18 10:05:56', '2025-12-23 21:17:18', 1),
(6, '2025-07-22 04:22:21', '2026-03-23 02:06:03', 3),
(9, '2025-06-25 14:15:22', '2026-04-01 18:31:48', 2),
(9, '2025-08-17 05:44:58', '2026-02-05 04:35:01', 3),
(10, '2025-05-19 10:23:05', '2025-12-07 02:00:20', 2),
(8, '2025-07-23 06:44:07', '2026-02-10 20:47:52', 3),
(5, '2025-07-01 00:21:16', '2026-01-09 08:29:38', 4),
(8, '2025-07-14 12:30:44', '2026-01-13 15:38:19', 1),
(3, '2025-08-17 19:47:18', '2026-02-22 13:03:26', 2),
(5, '2025-08-10 23:51:34', '2026-03-16 23:24:47', 4),
(3, '2025-09-06 05:56:01', '2026-03-13 04:20:09', 2),
(6, '2025-07-06 06:32:26', '2025-11-15 18:31:34', 3),
(6, '2025-06-04 22:45:41', '2026-03-13 15:26:51', 3),
(8, '2025-05-29 23:21:32', '2025-11-24 20:46:22', 4),
(6, '2025-07-02 04:46:38', '2026-03-26 12:32:29', 2),
(9, '2025-05-14 01:49:46', '2026-01-27 04:03:34', 4),
(5, '2025-07-12 18:17:00', '2026-01-22 07:10:34', 2),
(2, '2025-07-14 07:39:01', '2026-03-05 19:09:29', 2),
(8, '2025-08-25 10:12:09', '2025-12-29 07:45:05', 3),
(6, '2025-06-18 16:51:36', '2026-01-23 15:43:58', 2),
(10, '2025-05-10 04:46:17', '2026-03-24 17:34:53', 1),
(6, '2025-05-29 12:38:08', '2026-01-06 16:28:24', 4),
(5, '2025-07-22 18:34:36', '2026-02-02 01:24:03', 2),
(4, '2025-06-07 12:53:49', '2025-11-17 13:04:47', 3),
(8, '2025-06-06 20:20:07', '2026-03-14 23:59:27', 1),
(5, '2025-08-03 05:28:01', '2026-01-24 14:29:26', 2),
(10, '2025-07-21 12:01:11', '2026-02-03 01:35:36', 3),
(2, '2025-09-05 16:21:44', '2025-12-26 20:23:05', 3),
(3, '2025-06-19 16:01:02', '2025-12-08 03:36:08', 1),
(7, '2025-08-11 01:06:08', '2026-03-14 06:13:17', 3),
(8, '2025-07-30 15:20:39', '2026-02-17 09:18:25', 3),
(8, '2025-06-19 20:26:11', '2026-01-04 03:29:50', 2),
(1, '2025-06-29 23:52:42', '2026-01-27 11:15:42', 3),
(7, '2025-09-07 09:37:57', '2026-03-06 12:15:25', 3),
(11, '2026-05-07 16:26:19', '2026-05-10 16:26:19', 4),
(8, '2025-06-09 07:53:14', '2026-02-16 03:45:49', 4),
(2, '2025-06-28 09:35:47', '2026-02-26 18:14:11', 3),
(5, '2025-07-22 00:32:22', '2025-12-10 03:54:38', 1),
(7, '2025-06-06 09:10:11', '2026-02-28 21:31:40', 1),
(6, '2025-07-19 15:20:00', '2026-03-21 15:53:39', 3),
(6, '2025-07-24 10:55:45', '2025-12-24 03:24:52', 2);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `prenom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `tel` varchar(15) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `mail` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(1, 'Powers', 'Reese', '02 65 38 98 68', 'integer.tincidunt@icloud.com', 2),
(2, 'Contreras', 'Frances', '05 77 18 52 26', 'vitae.aliquam.eros@hotmail.com', 2),
(3, 'Soto', 'Sopoline', '08 64 76 76 47', 'semper@google.com', 3),
(4, 'Park', 'Dahlia', '08 67 53 16 56', 'ipsum@google.edu', 2),
(5, 'Ashley', 'Vaughan', '02 48 53 35 18', 'lorem.ut.aliquam@google.couk', 2),
(6, 'Branch', 'Germane', '03 26 10 34 77', 'consequat.nec.mollis@google.couk', 1),
(7, 'Castaneda', 'Kennedy', '06 50 38 85 79', 'in.mi@google.net', 2),
(8, 'Carey', 'Burke', '04 56 37 75 11', 'non.nisi.aenean@google.couk', 2),
(9, 'Branch', 'Elizabeth', '03 90 78 30 76', 'mattis.velit@google.couk', 2),
(10, 'Galloway', 'Timon', '03 18 55 39 78', 'nulla.interdum@aol.com', 1),
(11, 'Creed', 'Nathan', '06 00 00 00 00', 'dusfh@uijfsdhi.com', 3);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  `pwd` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('user', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
