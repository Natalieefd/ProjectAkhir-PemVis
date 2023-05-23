-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 23 Bulan Mei 2023 pada 22.01
-- Versi server: 10.4.25-MariaDB
-- Versi PHP: 8.1.10

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
-- Struktur dari tabel `tbadmin`
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
-- Dumping data untuk tabel `tbadmin`
--

INSERT INTO `tbadmin` (`username`, `password`, `nama_toko`, `no_telp`, `email`, `alamat`) VALUES
('Sharkbite', '123', 'Toko Suka Maju', '081244613442', 'hadiepratamatulili@gmail.com', 'Jalan Dimana Saja');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbcustomer`
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
-- Dumping data untuk tabel `tbcustomer`
--

INSERT INTO `tbcustomer` (`id_cust`, `nama`, `username`, `password`, `no_telp`, `alamat`) VALUES
(1, 'Yafi', 'Viabel', '123', '081234567890', 'Jalan Kah Kita'),
(2, 'Wonwoo', 'Won17', '123', '081254546734', 'Jl Sakura'),
(3, 'Kayla', 'Kayla', '123', '085645345666', 'Jl Aksarana'),
(4, 'Zaydan', 'Zaydan', '123', '087645443987', 'Jl Bantaraya'),
(5, 'Iqbaal', 'Iqbal', '123', '085652990243', 'Jl Nusantara'),
(6, 'Hasan', 'Hasan', '123', '084354447890', 'Jl Bintaro'),
(7, 'Farhan', 'Farhan', '123', '087621224683', 'Jl Bolasan'),
(8, 'Miskha', 'Miskha', '123', '087645676543', 'Jl Cimara'),
(9, 'Gege', 'Gege', '123', '085709876589', 'Jl Cemara'),
(10, 'Megumi', 'Megumi', '123', '089734336786', 'Jl Cendana');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbpesanan`
--

CREATE TABLE `tbpesanan` (
  `id_pesanan` int(10) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `tanggal_pesanan` datetime NOT NULL,
  `id_customer` int(10) NOT NULL,
  `id_produk` int(10) NOT NULL,
  `stok` int(4) NOT NULL,
  `status` varchar(20) NOT NULL,
  `harga_total` int(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbpesanan`
--

INSERT INTO `tbpesanan` (`id_pesanan`, `nama`, `alamat`, `tanggal_pesanan`, `id_customer`, `id_produk`, `stok`, `status`, `harga_total`) VALUES
(1, 'Wonwoo', 'Jl. Sakur', '2023-05-19 18:04:06', 2, 1, 2, 'Belum Dikirim', 900000),
(2, 'Wonwoo', 'Jl Sakura', '2023-05-23 05:22:32', 2, 4, 1, 'Sudah Dikirim', 227000),
(3, 'Ksyla', 'Jl Aksarana', '2023-05-23 05:27:21', 3, 5, 1, 'Belum Dibayar', 315000),
(4, 'Gege', 'Jl Cemara', '2023-05-23 05:28:30', 9, 3, 2, 'Sudah Dikirim', 700000),
(5, 'Gege', 'Jl Cemara', '2023-05-23 05:29:51', 9, 6, 1, 'Sudah Dikirim', 152000),
(6, 'Wonwoo', 'Jl Sakura', '2023-05-23 05:30:54', 2, 3, 1, 'Sudah Dikirim', 350000),
(7, 'Megumi', 'Jl Cendana', '2023-05-23 05:31:49', 10, 16, 1, 'Sudah Dikirim', 300000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbproduk`
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
-- Dumping data untuk tabel `tbproduk`
--

INSERT INTO `tbproduk` (`id_produk`, `nama_produk`, `kategori`, `deskripsi_produk`, `stok`, `harga`) VALUES
(1, 'FML', 'Album', '10th Mini Album of Seventeen', 1, 900000),
(2, 'Face The Sun', 'Album', '4th Full Album of Seventeen', 80, 990000),
(3, 'Hello', 'Album', 'Special Album of Joy Red Velvet', 17, 350000),
(4, 'MY WORLD', 'Poster', '3rd Mini Album of Aespa (Ningning ver)', 27, 227000),
(5, 'FOREVER 1', 'Poster', 'GIRLS\' GENERATION 7th Album ', 34, 315000),
(6, 'Attacca (Wonwoo Ver)', 'Photocard', 'Seventeen Attacca 9th Mini Album ', 11, 152000),
(7, 'Attacca (Mingyu Ver)', 'Photocard', 'Seventeen Attacca 9th Mini Album ', 24, 130000),
(8, 'Attacca (Scoups Ver)', 'Photocard', 'Seventeen Attacca 9th Mini Album ', 23, 120000),
(9, 'Attacca (Vernon Ver)', 'Photocard', 'Seventeen Attacca 9th Mini Album ', 17, 1350000),
(10, 'FML (Jeonghan Ver)', 'Photocard', '10th Mini Album of Seventeen', 12, 145000),
(11, 'FML (Seungkwan Ver)', 'Photocard', '10th Mini Album of Seventeen', 34, 130000),
(12, 'FML (Joshua Ver)', 'Poster', '10th Mini Album of Seventeen', 20, 150000),
(13, 'FML (DK Ver)', 'Poster', '10th Mini Album of Seventeen', 12, 140000),
(14, 'FML (Woozi Ver)', 'Poster', '10th Mini Album of Seventeen', 22, 140000),
(15, 'SHALALA ', 'Album', 'The 1st mini Album of Taeyong', 17, 235000),
(16, 'Bambi', 'Album', 'The 3rd Mini Album of Baekhyun', 12, 300000),
(17, 'Rover', 'Album', 'The 3rd mini Album of Kai', 17, 300000),
(18, 'Bambi', 'Postcard', 'POSTCARD BOOK - Baekhyun', 12, 320000),
(19, 'Hello', 'Photocard', 'POSTCARD BOOK - Joy Red Velvet', 12, 333000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbstaff`
--

CREATE TABLE `tbstaff` (
  `id_staff` int(10) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbstaff`
--

INSERT INTO `tbstaff` (`id_staff`, `nama`, `username`, `password`) VALUES
(1, 'Natalie', 'NTLee', '123'),
(2, 'Agustina', 'Sun1004', '123');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbadmin`
--
ALTER TABLE `tbadmin`
  ADD PRIMARY KEY (`username`);

--
-- Indeks untuk tabel `tbcustomer`
--
ALTER TABLE `tbcustomer`
  ADD PRIMARY KEY (`id_cust`);

--
-- Indeks untuk tabel `tbpesanan`
--
ALTER TABLE `tbpesanan`
  ADD PRIMARY KEY (`id_pesanan`);

--
-- Indeks untuk tabel `tbproduk`
--
ALTER TABLE `tbproduk`
  ADD PRIMARY KEY (`id_produk`);

--
-- Indeks untuk tabel `tbstaff`
--
ALTER TABLE `tbstaff`
  ADD PRIMARY KEY (`id_staff`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `tbcustomer`
--
ALTER TABLE `tbcustomer`
  MODIFY `id_cust` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT untuk tabel `tbpesanan`
--
ALTER TABLE `tbpesanan`
  MODIFY `id_pesanan` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT untuk tabel `tbproduk`
--
ALTER TABLE `tbproduk`
  MODIFY `id_produk` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT untuk tabel `tbstaff`
--
ALTER TABLE `tbstaff`
  MODIFY `id_staff` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
