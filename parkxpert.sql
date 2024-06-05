-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 05, 2024 at 05:57 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `parkxpert`
--

-- --------------------------------------------------------

--
-- Table structure for table `kendaraan`
--

CREATE TABLE `kendaraan` (
  `IDParkir` varchar(15) NOT NULL,
  `NoKendaraan` varchar(10) NOT NULL,
  `Jenis` varchar(15) NOT NULL,
  `Merk` varchar(20) NOT NULL,
  `WaktuMasuk` datetime NOT NULL,
  `IDPetugas` varchar(12) NOT NULL,
  `IDArea` varchar(4) NOT NULL,
  `TarifMember` int(100) NOT NULL,
  `TarifNonMember` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `kendaraan`
--

INSERT INTO `kendaraan` (`IDParkir`, `NoKendaraan`, `Jenis`, `Merk`, `WaktuMasuk`, `IDPetugas`, `IDArea`, `TarifMember`, `TarifNonMember`) VALUES
('2YI1904180002', 'B12345', 'Motor', 'Yamaha', '2018-04-19 08:48:35', 'admin', 'A1', 1500, 2500),
('4YM1904180001', 'B123HH', 'Mobil', 'Inova', '2018-04-19 08:14:57', 'admin', 'A1', 2500, 3500);

-- --------------------------------------------------------

--
-- Table structure for table `keuangan`
--

CREATE TABLE `keuangan` (
  `IDTransaksi` varchar(11) NOT NULL,
  `Tanggal` date NOT NULL,
  `Nominal` int(100) NOT NULL,
  `JenisTransaksi` varchar(20) NOT NULL,
  `IDPetugas` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- --------------------------------------------------------

--
-- Table structure for table `pegawai`
--

CREATE TABLE `pegawai` (
  `ID` varchar(12) NOT NULL,
  `Nama` text NOT NULL,
  `JenisKelamin` varchar(9) NOT NULL,
  `TanggalLahir` date NOT NULL,
  `Email` text NOT NULL,
  `Akses` varchar(8) NOT NULL,
  `Password` varchar(12) NOT NULL,
  `Status` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `pegawai`
--

INSERT INTO `pegawai` (`ID`, `Nama`, `JenisKelamin`, `TanggalLahir`, `Email`, `Akses`, `Password`, `Status`) VALUES
('anindita6', 'ANINDITA RAHMA', 'Perempuan', '2005-04-06', 'aninditarahma@gmail.com', 'Admin', 'admin123', 'Offline'),
('sahardian24', 'SAHARDIAN PUTRA', 'Laki-Laki', '2004-07-01', 'sahardianputra@Gmail.com', 'Petugas', 'ruckus', 'Offline');

-- --------------------------------------------------------

--
-- Table structure for table `riwayatkendaraan`
--

CREATE TABLE `riwayatkendaraan` (
  `IDParkir` varchar(15) NOT NULL,
  `NoKendaraan` varchar(10) NOT NULL,
  `Jenis` varchar(15) NOT NULL,
  `Merk` varchar(20) NOT NULL,
  `WaktuMasuk` datetime NOT NULL,
  `WaktuKeluar` datetime NOT NULL,
  `IDPetugas` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tarifarea`
--

CREATE TABLE `tarifarea` (
  `Jenis` varchar(15) NOT NULL,
  `Member` int(100) NOT NULL,
  `NonMember` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `tarifarea`
--

INSERT INTO `tarifarea` (`Jenis`, `Member`, `NonMember`) VALUES
('Biasa', 0, 0),
('VIP', 100, 100);

-- --------------------------------------------------------

--
-- Table structure for table `tarifkendaraan`
--

CREATE TABLE `tarifkendaraan` (
  `Jenis` varchar(15) NOT NULL,
  `Tarif` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `tarifkendaraan`
--

INSERT INTO `tarifkendaraan` (`Jenis`, `Tarif`) VALUES
('Mobil', 5000),
('Motor', 2000);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `kendaraan`
--
ALTER TABLE `kendaraan`
  ADD PRIMARY KEY (`IDParkir`);

--
-- Indexes for table `keuangan`
--
ALTER TABLE `keuangan`
  ADD PRIMARY KEY (`IDTransaksi`);

--
-- Indexes for table `pegawai`
--
ALTER TABLE `pegawai`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `riwayatkendaraan`
--
ALTER TABLE `riwayatkendaraan`
  ADD PRIMARY KEY (`IDParkir`);

--
-- Indexes for table `tarifarea`
--
ALTER TABLE `tarifarea`
  ADD PRIMARY KEY (`Jenis`);

--
-- Indexes for table `tarifkendaraan`
--
ALTER TABLE `tarifkendaraan`
  ADD PRIMARY KEY (`Jenis`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
