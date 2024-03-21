-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 15, 2023 at 08:10 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hrsdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `guest`
--

CREATE TABLE `guest` (
  `guest_id` int(11) NOT NULL,
  `guest_name` varchar(50) NOT NULL,
  `guest_NIC` varchar(50) NOT NULL,
  `guest_email` varchar(100) NOT NULL,
  `guest_phone` varchar(20) DEFAULT NULL,
  `guest_address` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `guest`
--

INSERT INTO `guest` (`guest_id`, `guest_name`, `guest_NIC`, `guest_email`, `guest_phone`, `guest_address`) VALUES
(5, 'kithara', '200258100428', 'kitharanadali123@gmail.com', '0719150624', 'Ganangamuwa,Nakkawatta'),
(7, 'Pasidu', '2002147865', 'sadun@gmail.com', '0724578936', 'Mawanella,Kegalle'),
(8, 'Damayanthi', '197554823', 'damayanthi@gmail.com', '0714527896', 'Kegalle');

-- --------------------------------------------------------

--
-- Table structure for table `reservation`
--

CREATE TABLE `reservation` (
  `guest_NIC` varchar(20) NOT NULL,
  `room_Number` varchar(20) NOT NULL,
  `check_in` date DEFAULT NULL,
  `check_out` date DEFAULT NULL,
  `room_type` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `reservation`
--

INSERT INTO `reservation` (`guest_NIC`, `room_Number`, `check_in`, `check_out`, `room_type`) VALUES
('200258100428', '002', '2023-10-17', '2023-10-20', 'Twin'),
('200418003555', '14', '2023-10-17', '2023-10-20', 'Double');

-- --------------------------------------------------------

--
-- Table structure for table `room`
--

CREATE TABLE `room` (
  `room_id` int(11) NOT NULL,
  `room_number` varchar(10) NOT NULL,
  `room_type` varchar(50) NOT NULL,
  `capacity` varchar(12) NOT NULL,
  `room_description` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `room`
--

INSERT INTO `room` (`room_id`, `room_number`, `room_type`, `capacity`, `room_description`) VALUES
(2, '12', 'Single', '6', 'two beds'),
(5, '14', 'Single', '12', '14'),
(6, '007', 'Single', '35', 'Bond,James Bond!'),
(8, '002', 'Twin', '3', '2 tables\r\n2 beds\r\n1 bathroom\r\n5000/='),
(9, '10', 'Double', '4', '2 beds\r\n3chairs\r\n1 stool');

-- --------------------------------------------------------

--
-- Table structure for table `userdetails`
--

CREATE TABLE `userdetails` (
  `Username` varchar(10) NOT NULL,
  `PhoneNumber` varchar(50) DEFAULT NULL,
  `Password` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `userdetails`
--

INSERT INTO `userdetails` (`Username`, `PhoneNumber`, `Password`) VALUES
('Damayanthi', '0718074568', 'Mal12345'),
('Dumidu', '0745238936', '123'),
('gdgdggggg', '0775536038', 'jdhdA1gggggg'),
('kithara', '0719150624', 'Kithara124'),
('Manusha', '0785624132', '2002Manu'),
('Nethum', '0718075959', '2010Nethum'),
('Oshadha', '0712333017', 'Password123'),
('Pabasara', '0719071750', 'Dumindu123'),
('Ranaweera', '0772916584', 'Rana@1234'),
('Ravidu', '0714527896', 'Ravidu111'),
('Vihaga', '0745621485', '2002#Phj'),
('Vihanga', '0767777778', '1234abcdA');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `guest`
--
ALTER TABLE `guest`
  ADD PRIMARY KEY (`guest_id`);

--
-- Indexes for table `reservation`
--
ALTER TABLE `reservation`
  ADD PRIMARY KEY (`guest_NIC`,`room_Number`),
  ADD KEY `FK_RservationRoom` (`room_Number`);

--
-- Indexes for table `room`
--
ALTER TABLE `room`
  ADD PRIMARY KEY (`room_id`);

--
-- Indexes for table `userdetails`
--
ALTER TABLE `userdetails`
  ADD PRIMARY KEY (`Username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `guest`
--
ALTER TABLE `guest`
  MODIFY `guest_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `room`
--
ALTER TABLE `room`
  MODIFY `room_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `FK_ReservationGuest` FOREIGN KEY (`guest_NIC`) REFERENCES `guest` (`guest_NIC`),
  ADD CONSTRAINT `FK_RservationRoom` FOREIGN KEY (`room_Number`) REFERENCES `room` (`room_number`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
