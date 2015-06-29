-- -----------   ---------------------------------------------------------------
-- DESCRIPTION : erase PixLogicDB, recreate it, configure it and create tables
--      AUTHOR : by Arnaud Frechet, <frechet@intechinfo.fr> 
--   LAST EDIT : on 11 June, 2015
-- -----------   ---------------------------------------------------------------

DROP DATABASE IF EXISTS PixLogicDB;
CREATE DATABASE PixLogicDB;
ALTER DATABASE PixLogicDB CHARACTER SET utf8 COLLATE utf8_general_ci;
USE PixLogicDB;

CREATE TABLE AccountMainCategories (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Name			VARCHAR(255)								NOT NULL,
	Description		TINYTEXT					DEFAULT NULL,
	PRIMARY KEY (Id),
	UNIQUE (Name)
)ENGINE = InnoDB;
CREATE TABLE AccountSubCategories (
	Id				INT				UNSIGNED	AUTO_INCREMENT	NOT NULL,
	Name			VARCHAR(255)								NOT NULL,
	Description		TINYTEXT					DEFAULT NULL,
	MainCategory	INT				UNSIGNED					NOT NULL,
	PRIMARY KEY (Id),
	UNIQUE (Name),
	FOREIGN KEY (MainCategory) REFERENCES AccountMainCategories (Id)
)ENGINE = InnoDB;
CREATE TABLE Accounts (
	Id				INT				UNSIGNED	AUTO_INCREMENT	NOT NULL,
	FirstName		TINYTEXT									NOT NULL,
	LastName		TINYTEXT									NOT NULL,
	Email			VARCHAR(255)								NOT NULL,
	Phone			TINYTEXT					DEFAULT NULL,
	Adress			TINYTEXT					DEFAULT NULL,
	Historic		LONGTEXT					DEFAULT NULL,
	Wallet			INT							DEFAULT 0		NOT NULL,
	Active			BOOLEAN						DEFAULT FALSE	NOT NULL,
	Banned			BOOLEAN						DEFAULT FALSE	NOT NULL,
	PicturePath		TINYTEXT					DEFAULT NULL,
	SubCategory		INT				UNSIGNED					NOT NULL,
	PRIMARY KEY (Id),
	UNIQUE (Email),
	FOREIGN KEY (SubCategory) REFERENCES AccountSubCategories (Id)
)ENGINE = InnoDB;
-- ^ AccountsModel

CREATE TABLE Companies (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Name			VARCHAR(255)								NOT NULL,
	Phone			TINYTEXT					DEFAULT NULL,
	Email			TINYTEXT					DEFAULT NULL,
	Fax				TINYTEXT					DEFAULT NULL,
	Website			TINYTEXT					DEFAULT NULL,
	Adress			TINYTEXT					DEFAULT NULL,
	LogoPath		TINYTEXT					DEFAULT NULL,
	PRIMARY KEY (Id),
	UNIQUE (Name)
)ENGINE = InnoDB;
CREATE TABLE Contacts (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	FirstName		TINYTEXT									NOT NULL,
	LastName		TINYTEXT									NOT NULL,
	Phone			TINYTEXT					DEFAULT NULL,
	Email			TINYTEXT					DEFAULT NULL,
	Fax				TINYTEXT					DEFAULT NULL,
	PortraitPath	TINYTEXT					DEFAULT NULL,
	Employer		INT				UNSIGNED					NOT NULL,
	PRIMARY	KEY (Id),
	FOREIGN KEY (Employer) REFERENCES Companies (Id)
)ENGINE = InnoDB;
CREATE TABLE Invoices (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	PhaseNumber		INT(10)			UNSIGNED	ZEROFILL		NOT NULL,
	PurchaseDate	DATE										NOT NULL,
	PurchaseCost	DECIMAL(12, 2)								NOT NULL,
	Depreciation	INT											NOT NULL,
	ScanPath		TINYTEXT					DEFAULT NULL,
	Provider		INT 			UNSIGNED					NOT NULL,
	PRIMARY KEY (id),
	UNIQUE (PhaseNumber),
	FOREIGN KEY (Provider) REFERENCES Companies (Id)
)ENGINE = InnoDB;
-- ^ InvoicesModel

CREATE TABLE ItemMainCategories (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Name			VARCHAR(255)								NOT NULL,
	Description		TEXT						DEFAULT NULL,
	PRIMARY KEY (Id),
	UNIQUE (Name)
)ENGINE = InnoDB;
CREATE TABLE ItemSubCategories (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Name			VARCHAR(255)								NOT NULL,
	Description		TEXT						DEFAULT NULL,
	MainCategory	INT				UNSIGNED					NOT NULL,
	PRIMARY KEY (Id),
	UNIQUE (Name),
	FOREIGN KEY (MainCategory) REFERENCES ItemMainCategories (Id)
)ENGINE = InnoDB;
CREATE TABLE ItemBrands (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Name			VARCHAR(255)								NOT NULL,
	Description		TEXT						DEFAULT NULL,
	PRIMARY KEY (Id),
	UNIQUE (Name)
)ENGINE = InnoDB;
CREATE TABLE ItemStates (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Name			VARCHAR(255)								NOT NULL,
	Description		TEXT						DEFAULT NULL,
	Usable			BOOLEAN						DEFAULT TRUE	NOT NULL,
	PRIMARY KEY (Id),
	UNIQUE (Name)
)ENGINE = InnoDB;
CREATE TABLE Items (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	EAN13			INT(13)			UNSIGNED	DEFAULT NULL,
	Reference		TINYTEXT									NOT NULL,
	ReservationCost	INT				UNSIGNED	DEFAULT 1		NOT NULL,
	Consumable		BOOLEAN						DEFAULT FALSE	NOT NULL,
	Reservable		BOOLEAN						DEFAULT TRUE	NOT NULL,
	Description		TEXT						DEFAULT NULL,
	PicturePath		TINYTEXT					DEFAULT NULL,
	Brand			INT				UNSIGNED					NOT NULL,
	RelatedInvoice	INT				UNSIGNED					NOT NULL,
	SubCategory		INT				UNSIGNED					NOT NULL,
	CurrentState	INT				UNSIGNED					NOT NULL,
	PRIMARY KEY (Id),
	UNIQUE (EAN13),
	FOREIGN KEY (Brand) REFERENCES ItemBrands (Id),
	FOREIGN KEY (RelatedInvoice) REFERENCES Invoices (Id),
	FOREIGN KEY (SubCategory) REFERENCES ItemSubCategories (Id),
	FOREIGN KEY (CurrentState) REFERENCES ItemStates (id)
)ENGINE = InnoDB;
CREATE TABLE ItemRestorations (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	BeginningDate	DATE										NOT NULL,
	EndingDate		DATE						DEFAULT NULL,
	Repaired		INT				UNSIGNED					NOT NULL,
	Repairer		INT				UNSIGNED					NOT NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (Repaired) REFERENCES Items (Id),
	FOREIGN KEY (Repairer) REFERENCES Companies (Id)
)ENGINE = InnoDB;
-- ^ ItemsModel

CREATE TABLE Packs (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Name			VARCHAR(255)									NOT NULL,
	Description		TEXT			DEFAULT NULL,
	Reservable		BOOLEAN			DEFAULT TRUE				NOT NULL,
	PRIMARY KEY (Id),
	UNIQUE (Name)
)ENGINE = InnoDB;
CREATE TABLE PackagedItems (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	UsedItem		INT				UNSIGNED					NOT NULL,
	UsedPack		INT				UNSIGNED					NOT NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (UsedItem) REFERENCES Items (Id),
	FOREIGN KEY (UsedPack) REFERENCES Packs (Id)
)ENGINE = InnoDB;
CREATE TABLE PackagedItemCategories (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	UsedCategory	INT				UNSIGNED					NOT NULL,
	UsedPack		INT				UNSIGNED					NOT NULL,
	PRIMARY KEY (id),
	FOREIGN KEY (UsedCategory) REFERENCES ItemSubCategories (Id),
	FOREIGN KEY (UsedPack) REFERENCES Packs (Id)
)ENGINE = InnoDB;
-- ^ PacksModel

CREATE TABLE ReservationPlannings (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	BeginningDate	DATETIME									NOT NULL,
	EndingDate		DATETIME									DEFAULT NULL,
	PRIMARY KEY (id)
)ENGINE = InnoDB;
CREATE TABLE ReservationEvents (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Confirmed		BOOLEAN						DEFAULT FALSE	NOT NULL,
	InitialPlanning	INT				UNSIGNED					NOT NULL,
	Reserver		INT				UNSIGNED					NOT NULL,
	PRIMARY KEY (id),
	FOREIGN KEY (InitialPlanning) REFERENCES ReservationPlannings (Id),
	FOREIGN KEY (Reserver) REFERENCES Accounts (Id)
)ENGINE = InnoDB;
CREATE TABLE ReservationItems (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Reservation		INT				UNSIGNED					NOT NULL,
	RealPlanning	INT				UNSIGNED					NOT NULL,
	ReservedItem	INT				UNSIGNED					NOT NULL,
	ReservedPack	INT				UNSIGNED					DEFAULT NULL,
	InitialState	INT				UNSIGNED					NOT NULL,
	ReturnState		INT				UNSIGNED					DEFAULT NULL,
	PRIMARY KEY (id),
	FOREIGN KEY (Reservation) REFERENCES ReservationEvents (Id),
	FOREIGN KEY (RealPlanning) REFERENCES ReservationPlannings (Id),
	FOREIGN KEY (ReservedItem) REFERENCES Items (Id),
	FOREIGN KEY (ReservedPack) REFERENCES Packs (Id),
	FOREIGN KEY (InitialState) REFERENCES ItemStates (Id),
	FOREIGN KEY (ReturnState) REFERENCES ItemStates (Id)
)ENGINE = InnoDB;
-- ^ ReservationsModel

CREATE TABLE RecoveryEvents (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	RecoveringDate	DATETIME									NOT NULL,
	Recoverer		INT				UNSIGNED					NOT NULL,
	PRIMARY KEY (id),
	FOREIGN KEY (Recoverer) REFERENCES Accounts (Id)
)ENGINE = InnoDB;
CREATE TABLE RecoveryItems (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Recovery		INT				UNSIGNED					NOT NULL,
	RecoveredItem	INT				UNSIGNED					NOT NULL,
	RecoveredPack	INT				UNSIGNED	DEFAULT NULL,
	InitialState	INT				UNSIGNED					NOT NULL,
	ReturnState		INT				UNSIGNED					NOT NULL,
	PRIMARY KEY (id),
	FOREIGN KEY (Recovery) REFERENCES RecoveryEvents (Id),
	FOREIGN KEY (RecoveredItem) REFERENCES Items (Id),
	FOREIGN KEY (RecoveredPack) REFERENCES Packs (Id),
	FOREIGN KEY (InitialState) REFERENCES ItemStates (Id),
	FOREIGN KEY (ReturnState) REFERENCES ItemStates (Id)
);
-- ^ RecoveriesModel (optional)
