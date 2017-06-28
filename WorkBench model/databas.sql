-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`ShipperDetails`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`ShipperDetails` (
  `ShipperID` INT NOT NULL,
  `FName` VARCHAR(45) NULL,
  `LName` VARCHAR(45) NULL,
  `Address` VARCHAR(45) NULL,
  `City` VARCHAR(45) NULL,
  `Country` VARCHAR(45) NULL,
  PRIMARY KEY (`ShipperID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`ConsigneeDetails`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`ConsigneeDetails` (
  `ConsigneeID` INT NOT NULL,
  `FName` VARCHAR(45) NULL,
  `LName` VARCHAR(45) NULL,
  `Address` VARCHAR(45) NULL,
  `City` VARCHAR(45) NULL,
  `Country` VARCHAR(45) NULL,
  PRIMARY KEY (`ConsigneeID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`CustomDetails`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`CustomDetails` (
  `JobID` VARCHAR(45) NOT NULL,
  `CusdecNo` VARCHAR(45) NULL,
  PRIMARY KEY (`JobID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`TransportationDetails`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`TransportationDetails` (
  `TransportID` INT NOT NULL,
  `EstimatedCost` DOUBLE NULL,
  `RealCost` DOUBLE NULL,
  PRIMARY KEY (`TransportID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Overseas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Overseas` (
  `JobID` VARCHAR(45) NOT NULL,
  `EstimatedCost` DOUBLE NULL,
  `RealCost` DOUBLE NULL,
  PRIMARY KEY (`JobID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`WarehouseDetails`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`WarehouseDetails` (
  `WarehouseID` INT NOT NULL,
  PRIMARY KEY (`WarehouseID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`JobWarehouseDetails`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`JobWarehouseDetails` (
  `JobID` VARCHAR(45) NOT NULL,
  `EstimatedCost` DOUBLE NULL,
  `RealCost` DOUBLE NULL,
  `WarehouseDetails_WarehouseID` INT NOT NULL,
  PRIMARY KEY (`JobID`),
  INDEX `fk_JobWarehouseDetails_WarehouseDetails1_idx` (`WarehouseDetails_WarehouseID` ASC),
  CONSTRAINT `fk_JobWarehouseDetails_WarehouseDetails1`
    FOREIGN KEY (`WarehouseDetails_WarehouseID`)
    REFERENCES `mydb`.`WarehouseDetails` (`WarehouseID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`JobInfo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`JobInfo` (
  `JobID` VARCHAR(45) NOT NULL,
  `Import_Export` VARCHAR(45) NULL,
  `FCL_LCL_Air` VARCHAR(45) NULL,
  `Type` VARCHAR(45) NULL,
  `OpenDate` DATE NULL,
  `CompletedDate` DATE NULL,
  `Weight` DOUBLE NULL,
  `ShipperID` VARCHAR(45) NULL,
  `ShipperDetails_ShipperID` INT NULL,
  `ConsigneeID` INT NULL,
  `ConsigneeDetails_ConsigneeID` INT NULL,
  `Vessel` VARCHAR(45) NULL,
  `ContainerNo` VARCHAR(45) NULL,
  `CustomDetails_JobID` VARCHAR(45) NULL,
  `TransportationDetails_TransportID` INT NULL,
  `Overseas_JobID` VARCHAR(45) NULL,
  `JobWarehouseDetails_JobID` VARCHAR(45) NULL,
  PRIMARY KEY (`JobID`),
  INDEX `fk_JobInfo_ShipperDetails_idx` (`ShipperDetails_ShipperID` ASC),
  INDEX `fk_JobInfo_ConsigneeDetails1_idx` (`ConsigneeDetails_ConsigneeID` ASC),
  INDEX `fk_JobInfo_CustomDetails1_idx` (`CustomDetails_JobID` ASC),
  INDEX `fk_JobInfo_TransportationDetails1_idx` (`TransportationDetails_TransportID` ASC),
  INDEX `fk_JobInfo_Overseas1_idx` (`Overseas_JobID` ASC),
  INDEX `fk_JobInfo_JobWarehouseDetails1_idx` (`JobWarehouseDetails_JobID` ASC),
  CONSTRAINT `fk_JobInfo_ShipperDetails`
    FOREIGN KEY (`ShipperDetails_ShipperID`)
    REFERENCES `mydb`.`ShipperDetails` (`ShipperID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_JobInfo_ConsigneeDetails1`
    FOREIGN KEY (`ConsigneeDetails_ConsigneeID`)
    REFERENCES `mydb`.`ConsigneeDetails` (`ConsigneeID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_JobInfo_CustomDetails1`
    FOREIGN KEY (`CustomDetails_JobID`)
    REFERENCES `mydb`.`CustomDetails` (`JobID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_JobInfo_TransportationDetails1`
    FOREIGN KEY (`TransportationDetails_TransportID`)
    REFERENCES `mydb`.`TransportationDetails` (`TransportID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_JobInfo_Overseas1`
    FOREIGN KEY (`Overseas_JobID`)
    REFERENCES `mydb`.`Overseas` (`JobID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_JobInfo_JobWarehouseDetails1`
    FOREIGN KEY (`JobWarehouseDetails_JobID`)
    REFERENCES `mydb`.`JobWarehouseDetails` (`JobID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
