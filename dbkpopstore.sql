-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: May 18, 2023 at 09:20 AM
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
  `password` varchar(50) NOT NULL,
  `nama_toko` varchar(20) NOT NULL,
  `no_telp` varchar(15) NOT NULL,
  `email` varchar(50) NOT NULL,
  `alamat` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbadmin`
--

INSERT INTO `tbadmin` (`username`, `password`, `nama_toko`, `no_telp`, `email`, `alamat`) VALUES
('Sharkbite', '123', 'Toko Suka Maju', '081244613442', 'hadiepratamatulili@gmail.com', 'Jalan Dimana Saja');

-- --------------------------------------------------------

--
-- Table structure for table `tbcustomer`
--

CREATE TABLE `tbcustomer` (
  `id_cust` int(10) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `no_telp` varchar(15) NOT NULL,
  `alamat` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbcustomer`
--

INSERT INTO `tbcustomer` (`id_cust`, `nama`, `username`, `password`, `no_telp`, `alamat`) VALUES
(1, 'Yafi', 'Viabel', '123', '081234567890', 'Jalan Kah Kita');

-- --------------------------------------------------------

--
-- Table structure for table `tbkeranjang`
--

CREATE TABLE `tbkeranjang` (
  `id_keranjang` int(10) NOT NULL,
  `id_cust` int(10) NOT NULL,
  `id_produk` int(10) NOT NULL,
  `stok` int(4) NOT NULL,
  `status` varchar(20) NOT NULL,
  `harga_total` int(9) NOT NULL
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
  `stok` int(4) NOT NULL,
  `status` varchar(20) NOT NULL,
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

--
-- Dumping data for table `tbproduk`
--

INSERT INTO `tbproduk` (`id_produk`, `nama_produk`, `kategori`, `deskripsi_produk`, `stok`, `harga`) VALUES
(1, 'FML', 'Album', '10th Mini Album of Seventeen', 50, 900000),
(2, 'Face The Sun', 'Album', '4th Full Album of Seventeen', 82, 990000),
(3, 'Hello', 'Album', 'Special Album of Joy Red Velvet', 17, 350000),
(4, 'MY WORLD', 'Poster', '3rd Mini Album of Aespa (Ningning ver)', 28, 227000),
(5, 'FOREVER 1', 'Poster', 'GIRLS\' GENERATION 7th Album ', 34, 315000),
(6, 'Attacca', 'Photocard', 'Seventeen Attacca 9th Mini Album (Wonwoo Ver)', 11, 152000);

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

--
-- Dumping data for table `tbstaff`
--

INSERT INTO `tbstaff` (`id_staff`, `nama`, `username`, `password`) VALUES
(1, 'Natalie', 'NTLee', '123'),
(2, 'Agustina', 'Sun1004', '123');

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
-- Indexes for table `tbkeranjang`
--
ALTER TABLE `tbkeranjang`
  ADD PRIMARY KEY (`id_keranjang`);

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
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbcustomer`
--
ALTER TABLE `tbcustomer`
  MODIFY `id_cust` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tbkeranjang`
--
ALTER TABLE `tbkeranjang`
  MODIFY `id_keranjang` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbproduk`
--
ALTER TABLE `tbproduk`
  MODIFY `id_produk` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tbstaff`
--
ALTER TABLE `tbstaff`
  MODIFY `id_staff` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
