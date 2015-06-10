-- -----------   ---------------------------------------------------------------
-- DESCRIPTION : erase PixLogicDB, recreate it, configure it and add tables
--      AUTHOR : by Arnaud Frechet, <frechet@intechinfo.fr> 
--   LAST EDIT : on 09 June, 2015
-- -----------   ---------------------------------------------------------------

DROP DATABASE IF EXISTS PixLogicDB;
CREATE DATABASE PixLogicDB;
ALTER DATABASE PixLogicDB CHARACTER SET utf8 COLLATE utf8_general_ci;
USE PixLogicDB;

CREATE TABLE AccountMainCategory (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Name			VARCHAR(255)								NOT NULL,
	Description		TINYTEXT					DEFAULT NULL,
	PRIMARY KEY (Id),
	UNIQUE (Name)
)ENGINE = InnoDB;
CREATE TABLE AccountSubCategory (
	Id				INT				UNSIGNED	AUTO_INCREMENT	NOT NULL,
	Name			VARCHAR(255)									NOT NULL,
	Description		TINYTEXT					DEFAULT NULL,
	MainCategory	INT				UNSIGNED					NOT NULL,
	PRIMARY KEY (Id),
	UNIQUE (Name),
	FOREIGN KEY (MainCategory) REFERENCES AccountMainCategory (Id)
)ENGINE = InnoDB;
CREATE TABLE Account (
	Id				INT				UNSIGNED	AUTO_INCREMENT	NOT NULL,
	FirstName		TINYTEXT									NOT NULL,
	LastName		TINYTEXT									NOT NULL,
	Email			VARCHAR(255)								NOT NULL,
	Password		TINYTEXT									NOT NULL,
	Salt			TINYTEXT									NOT NULL,
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
	FOREIGN KEY (SubCategory) REFERENCES AccountSubCategory (Id)
)ENGINE = InnoDB;
-- ^ AccountsModel

CREATE TABLE Company (
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
CREATE TABLE Contact (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	FirstName		TINYTEXT									NOT NULL,
	LastName		TINYTEXT									NOT NULL,
	Phone			TINYTEXT					DEFAULT NULL,
	Email			TINYTEXT					DEFAULT NULL,
	Fax				TINYTEXT					DEFAULT NULL,
	PortraitPath	TINYTEXT					DEFAULT NULL,
	Employer		INT				UNSIGNED					NOT NULL,
	PRIMARY	KEY (Id),
	FOREIGN KEY (Employer) REFERENCES Company (Id)
)ENGINE = InnoDB;
CREATE TABLE Invoice (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	PhaseNumber		INT(10)			UNSIGNED	ZEROFILL		NOT NULL,
	PurchaseDate	DATE										NOT NULL,
	PurchaseCost	DECIMAL(12, 2)								NOT NULL,
	Depreciation	INT											NOT NULL,
	ScanPath		TINYTEXT					DEFAULT NULL,
	Provider		INT 			UNSIGNED					NOT NULL,
	PRIMARY KEY (id),
	UNIQUE (PhaseNumber),
	FOREIGN KEY (Provider) REFERENCES Company (Id)
)ENGINE = InnoDB;
-- ^ InvoicesModel

CREATE TABLE ItemMainCategory (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Name			VARCHAR(255)									NOT NULL,
	Description		TEXT						DEFAULT NULL,
	PRIMARY KEY (Id),
	UNIQUE (Name)
)ENGINE = InnoDB;
CREATE TABLE ItemSubCategory (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Name			VARCHAR(255)									NOT NULL,
	Description		TEXT						DEFAULT NULL,
	MainCategory	INT				UNSIGNED					NOT NULL,
	PRIMARY KEY (Id),
	UNIQUE (Name),
	FOREIGN KEY (MainCategory) REFERENCES ItemMainCategory (Id)
)ENGINE = InnoDB;
CREATE TABLE ItemBrand (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Name			VARCHAR(255)									NOT NULL,
	Description		TEXT						DEFAULT NULL,
	PRIMARY KEY (Id),
	UNIQUE (Name)
)ENGINE = InnoDB;
CREATE TABLE ItemState (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Name			VARCHAR(255)									NOT NULL,
	Description		TEXT						DEFAULT NULL,
	Usable			BOOLEAN						DEFAULT TRUE	NOT NULL,
	PRIMARY KEY (Id),
	UNIQUE (Name)
)ENGINE = InnoDB;
CREATE TABLE Item (
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
	FOREIGN KEY (Brand) REFERENCES ItemBrand (Id),
	FOREIGN KEY (RelatedInvoice) REFERENCES Invoice (Id),
	FOREIGN KEY (SubCategory) REFERENCES ItemSubCategory (Id),
	FOREIGN KEY (CurrentState) REFERENCES ItemState (id)
)ENGINE = InnoDB;
CREATE TABLE ItemRestoration (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	BeginningDate	DATE										NOT NULL,
	EndingDate		DATE						DEFAULT NULL,
	Repaired		INT				UNSIGNED					NOT NULL,
	Repairer		INT				UNSIGNED					NOT NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (Repaired) REFERENCES Item (Id),
	FOREIGN KEY (Repairer) REFERENCES Company (Id)
)ENGINE = InnoDB;
-- ^ ItemsModel

CREATE TABLE Pack (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Name			VARCHAR(255)									NOT NULL,
	Description		TEXT			DEFAULT NULL,
	Reservable		BOOLEAN			DEFAULT TRUE				NOT NULL,
	PRIMARY KEY (Id),
	UNIQUE (Name)
)ENGINE = InnoDB;
CREATE TABLE PackagedItem (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	UsedItem		INT				UNSIGNED					NOT NULL,
	UsedPack		INT				UNSIGNED					NOT NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (UsedItem) REFERENCES Item (Id),
	FOREIGN KEY (UsedPack) REFERENCES Pack (Id)
)ENGINE = InnoDB;
CREATE TABLE PackagedItemCategory (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	UsedCategory	INT				UNSIGNED					NOT NULL,
	UsedPack		INT				UNSIGNED					NOT NULL,
	PRIMARY KEY (id),
	FOREIGN KEY (UsedCategory) REFERENCES ItemSubCategory (Id),
	FOREIGN KEY (UsedPack) REFERENCES Pack (Id)
)ENGINE = InnoDB;
-- ^ PacksModel

CREATE TABLE ReservationPlanning (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	BeginningDate	DATETIME									NOT NULL,
	EndingDate		DATETIME					DEFAULT NULL,
	PRIMARY KEY (id)
)ENGINE = InnoDB;
CREATE TABLE ReservationEvent (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Confirmed		BOOLEAN						DEFAULT FALSE	NOT NULL,
	InitialPlanning	INT				UNSIGNED					NOT NULL,
	Reserver		INT				UNSIGNED					NOT NULL,
	PRIMARY KEY (id),
	FOREIGN KEY (InitialPlanning) REFERENCES ReservationPlanning (Id),
	FOREIGN KEY (Reserver) REFERENCES Account (Id)
)ENGINE = InnoDB;
CREATE TABLE ReservationItem (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Reservation		INT				UNSIGNED					NOT NULL,
	RealPlanning	INT				UNSIGNED					NOT NULL,
	ReservedItem	INT				UNSIGNED					NOT NULL,
	ReservedPack	INT				UNSIGNED	DEFAULT NULL,
	InitialState	INT				UNSIGNED					NOT NULL,
	ReturnState		INT				UNSIGNED	DEFAULT NULL,
	PRIMARY KEY (id),
	FOREIGN KEY (Reservation) REFERENCES ReservationEvent (Id),
	FOREIGN KEY (RealPlanning) REFERENCES ReservationPlanning (Id),
	FOREIGN KEY (ReservedItem) REFERENCES Item (Id),
	FOREIGN KEY (ReservedPack) REFERENCES Pack (Id),
	FOREIGN KEY (InitialState) REFERENCES ItemState (Id),
	FOREIGN KEY (ReturnState) REFERENCES ItemState (Id)
)ENGINE = InnoDB;
-- ^ ReservationsModel

CREATE TABLE RecoveryEvent (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	RecoveringDate	DATETIME									NOT NULL,
	Recoverer		INT				UNSIGNED					NOT NULL,
	PRIMARY KEY (id),
	FOREIGN KEY (Recoverer) REFERENCES Account (Id)
)ENGINE = InnoDB;
CREATE TABLE RecoveryItem (
	Id				INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Recovery		INT				UNSIGNED					NOT NULL,
	RecoveredItem	INT				UNSIGNED					NOT NULL,
	RecoveredPack	INT				UNSIGNED	DEFAULT NULL,
	InitialState	INT				UNSIGNED					NOT NULL,
	ReturnState		INT				UNSIGNED					NOT NULL,
	PRIMARY KEY (id),
	FOREIGN KEY (Recovery) REFERENCES RecoveryEvent (Id),
	FOREIGN KEY (RecoveredItem) REFERENCES Item (Id),
	FOREIGN KEY (RecoveredPack) REFERENCES Pack (Id),
	FOREIGN KEY (InitialState) REFERENCES ItemState (Id),
	FOREIGN KEY (ReturnState) REFERENCES ItemState (Id)
);
-- ^ RecoveriesModel (optional)
