-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 17, 2017 at 06:25 AM
-- Server version: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `nibm_ecs`
--

-- --------------------------------------------------------

--
-- Table structure for table `alevel_qulification_generalinfo`
--

CREATE TABLE `alevel_qulification_generalinfo` (
  `StuID` varchar(13) NOT NULL,
  `Stream` varchar(10) NOT NULL,
  `ZScore` decimal(5,4) NOT NULL,
  `D_Rank` int(5) NOT NULL,
  `I_Rank` int(6) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `alevel_qulification_grades`
--

CREATE TABLE `alevel_qulification_grades` (
  `StuID` varchar(13) NOT NULL,
  `Subject` varchar(20) NOT NULL,
  `Grade` varchar(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `basicsalary_info`
--

CREATE TABLE `basicsalary_info` (
  `Designation` varchar(8) NOT NULL,
  `BSal` decimal(8,2) NOT NULL,
  `OTRate` decimal(6,2) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `course`
--

CREATE TABLE `course` (
  `CID` varchar(5) NOT NULL,
  `CName` varchar(50) NOT NULL,
  `CFee` decimal(8,2) NOT NULL,
  `Duration` varchar(9) NOT NULL,
  `TotCredit` int(3) NOT NULL,
  `CDirector` varchar(12) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `course`
--

INSERT INTO `course` (`CID`, `CName`, `CFee`, `Duration`, `TotCredit`, `CDirector`) VALUES
('DCSDF', 'Diploma In Computer System Design', '200000.00', '1 year', 45, 'KUMISF002');

-- --------------------------------------------------------

--
-- Table structure for table `course_modules`
--

CREATE TABLE `course_modules` (
  `CID` varchar(5) NOT NULL,
  `MID` varchar(3) NOT NULL,
  `MName` varchar(20) NOT NULL,
  `MCredit` int(1) NOT NULL,
  `AssignLecturer` varchar(12) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `course_modules`
--

INSERT INTO `course_modules` (`CID`, `MID`, `MName`, `MCredit`, `AssignLecturer`) VALUES
('DCSDF', 'IT1', 'Introduction', 3, 'KUMISF002');

-- --------------------------------------------------------

--
-- Table structure for table `department`
--

CREATE TABLE `department` (
  `DeptID` varchar(4) NOT NULL,
  `DeptName` varchar(15) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `lecturer`
--

CREATE TABLE `lecturer` (
  `LID` varchar(12) NOT NULL,
  `LFName` varchar(10) NOT NULL,
  `LLName` varchar(20) DEFAULT NULL,
  `Gender` varchar(1) NOT NULL,
  `DOB` varchar(10) NOT NULL,
  `LAddress` varchar(50) NOT NULL,
  `LPhNo` int(10) NOT NULL,
  `LPicture` varchar(50) DEFAULT NULL,
  `LPassword` varchar(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `lecturer`
--

INSERT INTO `lecturer` (`LID`, `LFName`, `LLName`, `Gender`, `DOB`, `LAddress`, `LPhNo`, `LPicture`, `LPassword`) VALUES
('KUMISF001', 'Sathya', 'Wijewardana', 'F', '01/03/1988', 'No.22,Kandy Road', 711231231, NULL, 'sathya112233'),
('KUMISF002', 'Lakmini', 'Wanninayake', 'F', '02/04/1988', 'No.22,Kandy Road,Kurunegala', 711227435, NULL, 'lakmini112233');

-- --------------------------------------------------------

--
-- Table structure for table `lecturer_qulifications`
--

CREATE TABLE `lecturer_qulifications` (
  `LID` varchar(12) NOT NULL,
  `Qulification` varchar(30) NOT NULL,
  `ObtainYear` int(4) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `olevel_qulification`
--

CREATE TABLE `olevel_qulification` (
  `StuID` varchar(13) NOT NULL,
  `Subject` varchar(20) NOT NULL,
  `Grade` varchar(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `StaffID` varchar(12) NOT NULL,
  `StaffFName` varchar(10) NOT NULL,
  `StaffLName` varchar(20) DEFAULT NULL,
  `Gender` varchar(1) NOT NULL,
  `StaffAddress` varchar(50) NOT NULL,
  `StaffPhNo` int(10) NOT NULL,
  `DeptID` varchar(4) NOT NULL,
  `Designation` varchar(8) NOT NULL,
  `StaffPicture` varchar(50) DEFAULT NULL,
  `StaffPassword` varchar(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`StaffID`, `StaffFName`, `StaffLName`, `Gender`, `StaffAddress`, `StaffPhNo`, `DeptID`, `Designation`, `StaffPicture`, `StaffPassword`) VALUES
('KUSTMEM001', 'Darani', 'Wijethilake', 'F', 'No.1,Wahara Road,Kurunegala', 773344551, 'KUFO', 'Staff', NULL, 'darani112233'),
('KUSTMEM002', 'Kalpa', 'Manawadu', 'T', 'No.11,Colombo Road,Kurunegala', 713244351, 'KUFO', 'Manager', NULL, 'kalpa112233'),
('KUADMIN001', 'Ravi', 'Sarathchandra', 'T', 'No.08,Malkaduwawa,Kurunegala', 711211351, 'KUAD', 'Admin', NULL, 'ravi112233'),
('KUDEAN0001', 'Sural', 'Chakrawarthi', 'T', 'No.18,LakeSide,Kurunegala', 771718391, 'KUDE', 'Dean', NULL, 'sural112233'),
('KUSTMEM003', 'Kamani', 'Perera', 'F', 'Samagi Niwasa,Kudagalgamuwa,Kurunegala', 711718111, 'KUFO', 'Cashier', NULL, 'kamani112233');

-- --------------------------------------------------------

--
-- Table structure for table `staffsalary`
--

CREATE TABLE `staffsalary` (
  `StaffID` varchar(12) NOT NULL,
  `BSal` decimal(8,2) NOT NULL,
  `OTHours` int(2) DEFAULT NULL,
  `OTAmount` decimal(7,2) DEFAULT NULL,
  `Allowance` decimal(7,2) DEFAULT NULL,
  `TotSal` decimal(8,2) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `StuID` varchar(13) NOT NULL,
  `StuFName` varchar(10) NOT NULL,
  `StuLName` varchar(20) DEFAULT NULL,
  `CID` varchar(5) NOT NULL,
  `Gender` varchar(1) NOT NULL,
  `DOB` varchar(10) NOT NULL,
  `StuAddress` varchar(50) NOT NULL,
  `StuMobNo` int(10) DEFAULT NULL,
  `StuLandNo` int(10) DEFAULT NULL,
  `OLevelY` varchar(4) NOT NULL,
  `StuPicture` varchar(50) DEFAULT NULL,
  `StuPassword` varchar(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`StuID`, `StuFName`, `StuLName`, `CID`, `Gender`, `DOB`, `StuAddress`, `StuMobNo`, `StuLandNo`, `OLevelY`, `StuPicture`, `StuPassword`) VALUES
('KUDCSD171F002', 'Devin', 'Herath', 'DCSDF', 'T', '12/07/1995', 'No.20/2,1st Lane,Lakeside,Kurunegala', 711697412, 372020809, '2011', NULL, 'deva112233');

-- --------------------------------------------------------

--
-- Table structure for table `student_payment`
--

CREATE TABLE `student_payment` (
  `StuID` varchar(13) NOT NULL,
  `PayID` varchar(10) DEFAULT NULL,
  `PayDate` varchar(10) NOT NULL,
  `PayAmount` decimal(8,2) NOT NULL,
  `Remaining` decimal(8,2) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `alevel_qulification_generalinfo`
--
ALTER TABLE `alevel_qulification_generalinfo`
  ADD PRIMARY KEY (`StuID`);

--
-- Indexes for table `alevel_qulification_grades`
--
ALTER TABLE `alevel_qulification_grades`
  ADD PRIMARY KEY (`StuID`,`Subject`);

--
-- Indexes for table `basicsalary_info`
--
ALTER TABLE `basicsalary_info`
  ADD PRIMARY KEY (`Designation`);

--
-- Indexes for table `course`
--
ALTER TABLE `course`
  ADD PRIMARY KEY (`CID`),
  ADD KEY `CDirector` (`CDirector`);

--
-- Indexes for table `course_modules`
--
ALTER TABLE `course_modules`
  ADD PRIMARY KEY (`CID`,`MID`),
  ADD KEY `AssignLecturer` (`AssignLecturer`);

--
-- Indexes for table `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`DeptID`);

--
-- Indexes for table `lecturer`
--
ALTER TABLE `lecturer`
  ADD PRIMARY KEY (`LID`);

--
-- Indexes for table `lecturer_qulifications`
--
ALTER TABLE `lecturer_qulifications`
  ADD PRIMARY KEY (`LID`,`Qulification`);

--
-- Indexes for table `olevel_qulification`
--
ALTER TABLE `olevel_qulification`
  ADD PRIMARY KEY (`StuID`,`Subject`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`StaffID`),
  ADD KEY `DeptID` (`DeptID`),
  ADD KEY `Designation` (`Designation`);

--
-- Indexes for table `staffsalary`
--
ALTER TABLE `staffsalary`
  ADD PRIMARY KEY (`StaffID`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`StuID`),
  ADD KEY `CID` (`CID`);

--
-- Indexes for table `student_payment`
--
ALTER TABLE `student_payment`
  ADD PRIMARY KEY (`StuID`,`PayAmount`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
