-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 04, 2024 at 05:54 AM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `excursion_car_rentaldb`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `id` int(11) NOT NULL,
  `name` varchar(20) NOT NULL,
  `password` varchar(255) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`id`, `name`, `password`, `created_at`) VALUES
(1, 'admin', 'admin123', '2024-08-20 18:52:00');

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `id` int(11) NOT NULL,
  `type` varchar(255) NOT NULL,
  `description` varchar(255) DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`id`, `type`, `description`, `created_at`) VALUES
(7, 'Small', '1-4', '2024-08-29 14:11:04'),
(8, 'Medium', '1-8', '2024-08-30 06:41:34'),
(9, 'Large', '1-14', '2024-08-30 06:41:42');

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `id` int(11) NOT NULL,
  `name` varchar(20) NOT NULL,
  `nrc` varchar(50) DEFAULT NULL,
  `ph_no` varchar(20) NOT NULL,
  `address` varchar(255) NOT NULL,
  `email` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`id`, `name`, `nrc`, `ph_no`, `address`, `email`, `password`, `created_at`) VALUES
(11, 'Maung Maung', NULL, '0965645656', 'yangon', 'maung@mail.com', NULL, '2024-08-29 14:48:40'),
(12, 'Zaw Zaw', NULL, '0988556423', 'Meiktila', 'zz@gmail.com', NULL, '2024-08-30 03:26:58'),
(13, 'Zaw', NULL, '036', 'hghg', 'gfgdfs', NULL, '2024-08-30 06:50:01');

-- --------------------------------------------------------

--
-- Table structure for table `gate`
--

CREATE TABLE `gate` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `location` varchar(255) NOT NULL,
  `ph_no` varchar(20) NOT NULL,
  `gmail` varchar(50) NOT NULL,
  `description` varchar(255) DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `gate`
--

INSERT INTO `gate` (`id`, `name`, `location`, `ph_no`, `gmail`, `description`, `created_at`) VALUES
(1, 'Meikhtila Head Office', 'Meikhtila', '09662397008', 'gate@mail.com', 'Our Gate is a nice , Hello I need you now!', '2024-08-29 02:45:30');

-- --------------------------------------------------------

--
-- Table structure for table `manage_cars`
--

CREATE TABLE `manage_cars` (
  `id` int(11) NOT NULL,
  `category_id` int(11) NOT NULL,
  `car_no` varchar(20) NOT NULL,
  `brand_name` varchar(255) NOT NULL,
  `no_of_seat` int(11) NOT NULL,
  `driver_name` varchar(50) NOT NULL,
  `driver_lincense` varchar(255) NOT NULL,
  `driver_ph_no` varchar(20) NOT NULL,
  `driver_address` varchar(255) NOT NULL,
  `status` int(11) NOT NULL DEFAULT 2 COMMENT '0=>unavailable,1=>pending,2=>available',
  `car_photo` varchar(255) NOT NULL,
  `rank` float NOT NULL,
  `description` varchar(255) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `manage_cars`
--

INSERT INTO `manage_cars` (`id`, `category_id`, `car_no`, `brand_name`, `no_of_seat`, `driver_name`, `driver_lincense`, `driver_ph_no`, `driver_address`, `status`, `car_photo`, `rank`, `description`, `created_at`) VALUES
(8, 7, '4M-2424', 'Honda Fit', 4, 'Mg Mg', '45454454', '096635652', 'Meikhtila', 2, '', 1.5, '', '2024-08-29 14:49:10'),
(9, 7, '4M-4545', 'Toyota Vitz', 4, 'Aung Aung', '4343545', '06564565', 'PyawBwe', 2, '', 1.5, '', '2024-08-29 14:18:53'),
(10, 8, '5S-5440', 'Suzuki Artika', 8, 'Ko Ko', '4343343', '0908977', 'Yangon', 1, '', 1, '', '2024-08-29 14:48:41'),
(11, 8, '9E-9613', 'Toyota Alphat', 8, 'Kyaw Kyaw', '123654', '09987654123', 'Mandalay', 1, '', 1.5, '', '2024-08-30 03:27:00'),
(12, 7, '5M-5667', 'BMW 330I', 4, 'mg mg', '67/6776', '65656', 'fggf', 1, '', 2, '', '2024-08-30 06:50:04');

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `id` int(11) NOT NULL,
  `car_id` int(11) NOT NULL,
  `cus_id` int(11) NOT NULL,
  `trip_id` int(11) NOT NULL,
  `start_date` date NOT NULL,
  `end_date` date NOT NULL,
  `total_day` int(11) NOT NULL,
  `status` int(11) NOT NULL COMMENT '0=>pending,1=>working,2=>completed,3=>canceled',
  `total_amount` double NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`id`, `car_id`, `cus_id`, `trip_id`, `start_date`, `end_date`, `total_day`, `status`, `total_amount`, `created_at`) VALUES
(9, 10, 11, 13, '2024-08-30', '2024-08-31', 1, 2, 150000, '2024-08-30 06:17:44'),
(10, 11, 12, 16, '2024-09-01', '2024-09-05', 4, 2, 720000, '2024-08-30 06:46:51'),
(11, 12, 13, 15, '2024-08-31', '2024-09-02', 3, 0, 420000, '2024-08-30 06:50:04');

-- --------------------------------------------------------

--
-- Table structure for table `trips`
--

CREATE TABLE `trips` (
  `id` int(11) NOT NULL,
  `source` varchar(255) NOT NULL,
  `destination` varchar(255) NOT NULL,
  `price` int(11) NOT NULL,
  `description` varchar(255) DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `trips`
--

INSERT INTO `trips` (`id`, `source`, `destination`, `price`, `description`, `created_at`) VALUES
(13, 'Meikhtila', 'Yangon', 150000, '', '2024-08-29 14:37:56'),
(14, 'Meikhtila', 'Bagan', 100000, '', '2024-08-29 14:39:24'),
(15, 'Meikhtila', 'Mandalay', 70000, '', '2024-08-30 03:20:04'),
(16, 'Meikhtila', 'Pyin Oo Lwin', 120000, '', '2024-08-30 03:20:40');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `gate`
--
ALTER TABLE `gate`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `manage_cars`
--
ALTER TABLE `manage_cars`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `car_no` (`car_no`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `trips`
--
ALTER TABLE `trips`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `gate`
--
ALTER TABLE `gate`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `manage_cars`
--
ALTER TABLE `manage_cars`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `trips`
--
ALTER TABLE `trips`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
