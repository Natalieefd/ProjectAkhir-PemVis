-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: May 16, 2023 at 05:01 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbkpopstore`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbadmin`
--

CREATE TABLE `tbadmin` (
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tbcustomer`
--

CREATE TABLE `tbcustomer` (
  `id_cust` int(10) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `no_telp` int(12) NOT NULL,
  `alamat` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tbpesanan`
--

CREATE TABLE `tbpesanan` (
  `id_pesanan` int(10) NOT NULL,
  `tanggal_pesanan` datetime NOT NULL,
  `id_customer` int(10) NOT NULL,
  `id_produk` int(10) NOT NULL,
  `harga_total` int(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tbproduk`
--

CREATE TABLE `tbproduk` (
  `id_produk` int(10) NOT NULL,
  `nama_produk` varchar(50) NOT NULL,
  `kategori` varchar(20) NOT NULL,
  `deskripsi_produk` varchar(200) DEFAULT NULL,
  `stok` int(4) NOT NULL,
  `harga` int(7) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tbstaff`
--

CREATE TABLE `tbstaff` (
  `id_staff` int(10) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tbtoko`
--

CREATE TABLE `tbtoko` (
  `nama` varchar(20) NOT NULL,
  `email` varchar(30) NOT NULL,
  `no_telp` int(12) NOT NULL,
  `alamat` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbadmin`
--
ALTER TABLE `tbadmin`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `tbcustomer`
--
ALTER TABLE `tbcustomer`
  ADD PRIMARY KEY (`id_cust`);

--
-- Indexes for table `tbpesanan`
--
ALTER TABLE `tbpesanan`
  ADD PRIMARY KEY (`id_pesanan`);

--
-- Indexes for table `tbproduk`
--
ALTER TABLE `tbproduk`
  ADD PRIMARY KEY (`id_produk`);

--
-- Indexes for table `tbstaff`
--
ALTER TABLE `tbstaff`
  ADD PRIMARY KEY (`id_staff`);

--
-- Indexes for table `tbtoko`
--
ALTER TABLE `tbtoko`
  ADD PRIMARY KEY (`nama`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbcustomer`
--
ALTER TABLE `tbcustomer`
  MODIFY `id_cust` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbproduk`
--
ALTER TABLE `tbproduk`
  MODIFY `id_produk` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbstaff`
--
ALTER TABLE `tbstaff`
  MODIFY `id_staff` int(10) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
