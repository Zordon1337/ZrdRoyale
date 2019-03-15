SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

CREATE TABLE IF NOT EXISTS `player` (
  `Id` bigint(20) NOT NULL,
  `Trophies` bigint(20) NOT NULL,
  `Language` text CHARACTER SET utf8mb4 NOT NULL,
  `FacebookId` text CHARACTER SET utf8mb4 NOT NULL,
  `Home` text CHARACTER SET utf8mb4 NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;