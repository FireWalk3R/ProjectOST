-- phpMyAdmin SQL Dump
-- version 4.0.9
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Erstellungszeit: 31. Jan 2014 um 12:47
-- Server Version: 5.6.14
-- PHP-Version: 5.5.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Datenbank: `itverwaltung`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `betreffkategorie`
--

CREATE TABLE IF NOT EXISTS `betreffkategorie` (
  `BKATEGORIE` varchar(50) COLLATE latin1_german1_ci NOT NULL,
  PRIMARY KEY (`BKATEGORIE`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `firma`
--

CREATE TABLE IF NOT EXISTS `firma` (
  `FIRMAID` varchar(10) COLLATE latin1_german1_ci NOT NULL,
  `FIRMENNAME` varchar(50) COLLATE latin1_german1_ci DEFAULT NULL,
  `FSTRASSE` varchar(75) COLLATE latin1_german1_ci DEFAULT NULL,
  `FHAUSNUMMER` varchar(10) COLLATE latin1_german1_ci DEFAULT NULL,
  `FPLZ` varchar(10) COLLATE latin1_german1_ci DEFAULT NULL,
  `FTELNR` varchar(25) COLLATE latin1_german1_ci DEFAULT NULL,
  `FANSPRECHPARTNER` varchar(10) COLLATE latin1_german1_ci DEFAULT NULL,
  PRIMARY KEY (`FIRMAID`),
  KEY `FOPLZ` (`FPLZ`),
  KEY `FMMITARBEITERID` (`FANSPRECHPARTNER`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `geraetart`
--

CREATE TABLE IF NOT EXISTS `geraetart` (
  `GERAETEART` varchar(15) COLLATE latin1_german1_ci NOT NULL,
  PRIMARY KEY (`GERAETEART`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

--
-- Daten für Tabelle `geraetart`
--

INSERT INTO `geraetart` (`GERAETEART`) VALUES
('Desktop-PC'),
('Mobiltelefon'),
('Notebook'),
('Workstation');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `geraete`
--

CREATE TABLE IF NOT EXISTS `geraete` (
  `GERAETEID` varchar(10) COLLATE latin1_german1_ci NOT NULL,
  `SERIENNUMMER` varchar(30) COLLATE latin1_german1_ci DEFAULT NULL,
  `GERAETEART` varchar(15) COLLATE latin1_german1_ci DEFAULT NULL,
  `BEZEICHNUNG` varchar(50) COLLATE latin1_german1_ci DEFAULT NULL,
  `BETRIEBSSYSTEM` varchar(50) COLLATE latin1_german1_ci DEFAULT NULL,
  `PROZESSORID` varchar(10) COLLATE latin1_german1_ci DEFAULT NULL,
  `RAM` varchar(10) COLLATE latin1_german1_ci DEFAULT NULL,
  `GRAFIKID` varchar(10) COLLATE latin1_german1_ci DEFAULT NULL,
  `HDD` varchar(10) COLLATE latin1_german1_ci DEFAULT NULL,
  `HANDYNR` varchar(15) COLLATE latin1_german1_ci DEFAULT NULL,
  `SIMKARTENNR` varchar(25) COLLATE latin1_german1_ci DEFAULT NULL,
  PRIMARY KEY (`GERAETEID`),
  KEY `GAART` (`GERAETEART`),
  KEY `GPPROZESSOR` (`PROZESSORID`),
  KEY `GGGRAFIK` (`GRAFIKID`),
  KEY `GSRAM` (`RAM`),
  KEY `GSHDD` (`HDD`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `gespraech`
--

CREATE TABLE IF NOT EXISTS `gespraech` (
  `GESPRAECHSID` varchar(19) COLLATE latin1_german1_ci NOT NULL,
  `NACHRICHTDATUM` varchar(10) COLLATE latin1_german1_ci DEFAULT NULL,
  `NACHRICHTZEIT` varchar(8) COLLATE latin1_german1_ci DEFAULT NULL,
  `NACHRICHT` mediumtext COLLATE latin1_german1_ci,
  `MITARBEITERID` varchar(10) COLLATE latin1_german1_ci DEFAULT NULL,
  PRIMARY KEY (`GESPRAECHSID`),
  KEY `GMMITARBEITERID` (`MITARBEITERID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `grafik`
--

CREATE TABLE IF NOT EXISTS `grafik` (
  `GRAFIKID` varchar(10) COLLATE latin1_german1_ci NOT NULL,
  `GRAFIKHERSTELLER` varchar(25) COLLATE latin1_german1_ci DEFAULT NULL,
  `GRAFIKBEZEICHNUNG` varchar(20) COLLATE latin1_german1_ci DEFAULT NULL,
  `GRAFIKRAM` varchar(10) COLLATE latin1_german1_ci DEFAULT NULL,
  PRIMARY KEY (`GRAFIKID`),
  KEY `GRSRAM` (`GRAFIKRAM`),
  KEY `GRHHERSTELLER` (`GRAFIKHERSTELLER`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `grafikhersteller`
--

CREATE TABLE IF NOT EXISTS `grafikhersteller` (
  `HERSTELLER` varchar(25) COLLATE latin1_german1_ci NOT NULL,
  PRIMARY KEY (`HERSTELLER`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

--
-- Daten für Tabelle `grafikhersteller`
--

INSERT INTO `grafikhersteller` (`HERSTELLER`) VALUES
('AMD'),
('INTEL'),
('NVIDIA');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `mitarbeiter`
--

CREATE TABLE IF NOT EXISTS `mitarbeiter` (
  `MITARBEITERID` varchar(10) COLLATE latin1_german1_ci NOT NULL,
  `MVORNAME` varchar(50) COLLATE latin1_german1_ci DEFAULT NULL,
  `MNACHNAME` varchar(50) COLLATE latin1_german1_ci DEFAULT NULL,
  `MRAUMNR` varchar(6) COLLATE latin1_german1_ci DEFAULT NULL,
  `MTELNR` varchar(25) COLLATE latin1_german1_ci DEFAULT NULL,
  `MFIRMAID` varchar(10) COLLATE latin1_german1_ci DEFAULT NULL,
  `MKENNWORT` varchar(30) COLLATE latin1_german1_ci DEFAULT NULL,
  `MRANG` varchar(25) COLLATE latin1_german1_ci DEFAULT NULL,
  `MEMAIL` varchar(75) COLLATE latin1_german1_ci DEFAULT NULL,
  PRIMARY KEY (`MITARBEITERID`),
  KEY `MFID` (`MFIRMAID`),
  KEY `MRRANG` (`MRANG`),
  KEY `MRRAUM` (`MRAUMNR`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `mitarbeitergeraete`
--

CREATE TABLE IF NOT EXISTS `mitarbeitergeraete` (
  `MGMITARBEITERID` varchar(10) COLLATE latin1_german1_ci NOT NULL,
  `MGGERAETEID` varchar(10) COLLATE latin1_german1_ci NOT NULL,
  PRIMARY KEY (`MGMITARBEITERID`,`MGGERAETEID`),
  KEY `MGGERAET` (`MGGERAETEID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `orte`
--

CREATE TABLE IF NOT EXISTS `orte` (
  `PLZ` varchar(10) COLLATE latin1_german1_ci NOT NULL,
  `ORT` varchar(50) COLLATE latin1_german1_ci DEFAULT NULL,
  PRIMARY KEY (`PLZ`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

--
-- Daten für Tabelle `orte`
--

INSERT INTO `orte` (`PLZ`, `ORT`) VALUES
('D-59555', 'Lippstadt'),
('D-59557', 'Lippstadt');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `prioritaet`
--

CREATE TABLE IF NOT EXISTS `prioritaet` (
  `PRIORITAET` varchar(15) COLLATE latin1_german1_ci NOT NULL,
  PRIMARY KEY (`PRIORITAET`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

--
-- Daten für Tabelle `prioritaet`
--

INSERT INTO `prioritaet` (`PRIORITAET`) VALUES
('hoch'),
('niedrig'),
('normal'),
('sehr hoch'),
('sehr niedrig');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `prozessoren`
--

CREATE TABLE IF NOT EXISTS `prozessoren` (
  `PROZESSORID` varchar(10) COLLATE latin1_german1_ci NOT NULL,
  `PROZESSORHERSTELLER` varchar(25) COLLATE latin1_german1_ci DEFAULT NULL,
  `PROZESSORBEZEICHNUNG` varchar(20) COLLATE latin1_german1_ci DEFAULT NULL,
  `TAKTFREQUENZ` varchar(10) COLLATE latin1_german1_ci DEFAULT NULL,
  PRIMARY KEY (`PROZESSORID`),
  KEY `PHHERSTELLER` (`PROZESSORHERSTELLER`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `prozessorhersteller`
--

CREATE TABLE IF NOT EXISTS `prozessorhersteller` (
  `HERSTELLER` varchar(25) COLLATE latin1_german1_ci NOT NULL,
  PRIMARY KEY (`HERSTELLER`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

--
-- Daten für Tabelle `prozessorhersteller`
--

INSERT INTO `prozessorhersteller` (`HERSTELLER`) VALUES
('AMD'),
('INTEL');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `raenge`
--

CREATE TABLE IF NOT EXISTS `raenge` (
  `RANG` varchar(25) COLLATE latin1_german1_ci NOT NULL,
  PRIMARY KEY (`RANG`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

--
-- Daten für Tabelle `raenge`
--

INSERT INTO `raenge` (`RANG`) VALUES
('Administrator'),
('Verwalter');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `raeume`
--

CREATE TABLE IF NOT EXISTS `raeume` (
  `RAUM` varchar(6) COLLATE latin1_german1_ci NOT NULL,
  PRIMARY KEY (`RAUM`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

--
-- Daten für Tabelle `raeume`
--

INSERT INTO `raeume` (`RAUM`) VALUES
('R110'),
('R111'),
('R125');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `speicher`
--

CREATE TABLE IF NOT EXISTS `speicher` (
  `GROESSE` varchar(10) COLLATE latin1_german1_ci NOT NULL,
  PRIMARY KEY (`GROESSE`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci ROW_FORMAT=COMPACT;

--
-- Daten für Tabelle `speicher`
--

INSERT INTO `speicher` (`GROESSE`) VALUES
('1000 GB'),
('1024 MB'),
('160 GB'),
('2048 MB'),
('320 GB'),
('4096 MB'),
('500 GB'),
('512 MB');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `status`
--

CREATE TABLE IF NOT EXISTS `status` (
  `STATUS` varchar(15) COLLATE latin1_german1_ci NOT NULL,
  PRIMARY KEY (`STATUS`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

--
-- Daten für Tabelle `status`
--

INSERT INTO `status` (`STATUS`) VALUES
('Geschlossen'),
('In Bearbeitung'),
('Offen');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `ticket`
--

CREATE TABLE IF NOT EXISTS `ticket` (
  `TICKETID` varchar(10) COLLATE latin1_german1_ci NOT NULL,
  `BETREFFKATEGORIE` varchar(50) COLLATE latin1_german1_ci DEFAULT NULL,
  `BETREFFZEILE` varchar(255) COLLATE latin1_german1_ci DEFAULT NULL,
  `MITARBEITERID` varchar(10) COLLATE latin1_german1_ci DEFAULT NULL,
  `PRIORITAET` varchar(15) COLLATE latin1_german1_ci DEFAULT NULL,
  `ERSTELLDATUM` varchar(10) COLLATE latin1_german1_ci DEFAULT NULL,
  `ERSTELLZEIT` varchar(8) COLLATE latin1_german1_ci DEFAULT NULL,
  `TICKETSTATUS` varchar(15) COLLATE latin1_german1_ci DEFAULT NULL,
  `BEARBEITERID` varchar(10) COLLATE latin1_german1_ci DEFAULT NULL,
  `GESPRAECHSID` varchar(10) COLLATE latin1_german1_ci DEFAULT NULL,
  PRIMARY KEY (`TICKETID`),
  KEY `TBKKATEGORIE` (`BETREFFKATEGORIE`),
  KEY `TSSTATUS` (`TICKETSTATUS`),
  KEY `TPPRIORITAET` (`PRIORITAET`),
  KEY `TGGESPRAECH` (`GESPRAECHSID`),
  KEY `TMMITARBEITERID` (`MITARBEITERID`),
  KEY `TMBEARBEITERID` (`BEARBEITERID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `firma`
--
ALTER TABLE `firma`
  ADD CONSTRAINT `FMMITARBEITERID` FOREIGN KEY (`FANSPRECHPARTNER`) REFERENCES `mitarbeiter` (`MITARBEITERID`),
  ADD CONSTRAINT `FOPLZ` FOREIGN KEY (`FPLZ`) REFERENCES `orte` (`PLZ`);

--
-- Constraints der Tabelle `geraete`
--
ALTER TABLE `geraete`
  ADD CONSTRAINT `GAART` FOREIGN KEY (`GERAETEART`) REFERENCES `geraetart` (`GERAETEART`),
  ADD CONSTRAINT `GGGRAFIK` FOREIGN KEY (`GRAFIKID`) REFERENCES `grafik` (`GRAFIKID`),
  ADD CONSTRAINT `GPPROZESSOR` FOREIGN KEY (`PROZESSORID`) REFERENCES `prozessoren` (`PROZESSORID`),
  ADD CONSTRAINT `GSHDD` FOREIGN KEY (`HDD`) REFERENCES `speicher` (`GROESSE`),
  ADD CONSTRAINT `GSRAM` FOREIGN KEY (`RAM`) REFERENCES `speicher` (`GROESSE`);

--
-- Constraints der Tabelle `gespraech`
--
ALTER TABLE `gespraech`
  ADD CONSTRAINT `GMMITARBEITERID` FOREIGN KEY (`MITARBEITERID`) REFERENCES `mitarbeiter` (`MITARBEITERID`);

--
-- Constraints der Tabelle `grafik`
--
ALTER TABLE `grafik`
  ADD CONSTRAINT `GRHHERSTELLER` FOREIGN KEY (`GRAFIKHERSTELLER`) REFERENCES `grafikhersteller` (`HERSTELLER`),
  ADD CONSTRAINT `GRSRAM` FOREIGN KEY (`GRAFIKRAM`) REFERENCES `speicher` (`GROESSE`);

--
-- Constraints der Tabelle `mitarbeiter`
--
ALTER TABLE `mitarbeiter`
  ADD CONSTRAINT `MFID` FOREIGN KEY (`MFIRMAID`) REFERENCES `firma` (`FIRMAID`),
  ADD CONSTRAINT `MRRANG` FOREIGN KEY (`MRANG`) REFERENCES `raenge` (`RANG`),
  ADD CONSTRAINT `MRRAUM` FOREIGN KEY (`MRAUMNR`) REFERENCES `raeume` (`RAUM`);

--
-- Constraints der Tabelle `mitarbeitergeraete`
--
ALTER TABLE `mitarbeitergeraete`
  ADD CONSTRAINT `MGGERAET` FOREIGN KEY (`MGGERAETEID`) REFERENCES `geraete` (`GERAETEID`),
  ADD CONSTRAINT `MGMITARBEITER` FOREIGN KEY (`MGMITARBEITERID`) REFERENCES `mitarbeiter` (`MITARBEITERID`);

--
-- Constraints der Tabelle `prozessoren`
--
ALTER TABLE `prozessoren`
  ADD CONSTRAINT `PHHERSTELLER` FOREIGN KEY (`PROZESSORHERSTELLER`) REFERENCES `prozessorhersteller` (`HERSTELLER`);

--
-- Constraints der Tabelle `ticket`
--
ALTER TABLE `ticket`
  ADD CONSTRAINT `TBKKATEGORIE` FOREIGN KEY (`BETREFFKATEGORIE`) REFERENCES `betreffkategorie` (`BKATEGORIE`),
  ADD CONSTRAINT `TGGESPRAECH` FOREIGN KEY (`GESPRAECHSID`) REFERENCES `gespraech` (`GESPRAECHSID`),
  ADD CONSTRAINT `TMBEARBEITERID` FOREIGN KEY (`BEARBEITERID`) REFERENCES `mitarbeiter` (`MITARBEITERID`),
  ADD CONSTRAINT `TMMITARBEITERID` FOREIGN KEY (`MITARBEITERID`) REFERENCES `mitarbeiter` (`MITARBEITERID`),
  ADD CONSTRAINT `TPPRIORITAET` FOREIGN KEY (`PRIORITAET`) REFERENCES `prioritaet` (`PRIORITAET`),
  ADD CONSTRAINT `TSSTATUS` FOREIGN KEY (`TICKETSTATUS`) REFERENCES `status` (`STATUS`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
