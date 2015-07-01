-- -----------   ---------------------------------------------------------------
-- DESCRIPTION : create PixLogicDB, removing previous DB's version
--      AUTHOR : by Arnaud Frechet, <frechet@intechinfo.fr> 
--   LAST EDIT : on 29 June, 2015
-- -----------   ---------------------------------------------------------------

DROP DATABASE IF EXISTS PixLogicDB;
CREATE DATABASE PixLogicDB;
ALTER DATABASE PixLogicDB CHARACTER SET utf8 COLLATE utf8_general_ci;

USE PixLogicDB;

DROP TABLE IF EXISTS RestoredItems;
DROP TABLE IF EXISTS RestorationEvents;
DROP TABLE IF EXISTS ReservedItems;
DROP TABLE IF EXISTS ReservationEvents;
-- ^ EventsModel's tables deletion

DROP TABLE IF EXISTS PackagedItemFunctionalCategories;
DROP TABLE IF EXISTS PackagedItems;
DROP TABLE IF EXISTS Packs;
-- | PacksModel's tables deletion

DROP TABLE IF EXISTS Items;
DROP TABLE IF EXISTS ItemBrands;
DROP TABLE IF EXISTS ItemFunctionalCategories;
DROP TABLE IF EXISTS ItemCategories;
DROP TABLE IF EXISTS ItemStates;
-- ^ ItemsModel's tables deletion

DROP TABLE IF EXISTS Invoices;
DROP TABLE IF EXISTS Contacts;
DROP TABLE IF EXISTS Companies;
-- ^ InvoicesModel's tables deletion

DROP TABLE IF EXISTS Accounts;
DROP TABLE IF EXISTS AccountDivisions;
DROP TABLE IF EXISTS AccountCategories;
-- ^ AccountsModel's tables deletion

CREATE TABLE AccountCategories (
	Id					INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Name				VARCHAR(255)								NOT NULL,
	Description			TEXT						DEFAULT NULL,
	PRIMARY KEY (Id),
	UNIQUE (Name)
)ENGINE = InnoDB;
CREATE TABLE AccountDivisions (
	Id					INT				UNSIGNED	AUTO_INCREMENT		NOT NULL,
	Name				VARCHAR(255)									NOT NULL,
	Description			TEXT						DEFAULT NULL,
	ReservationRight	ENUM("Refused", "Authorized", "Free")
						DEFAULT "Authorized"								NOT NULL,
	Category			INT				UNSIGNED						NOT NULL,
	PRIMARY KEY (Id),
	UNIQUE (Name),
	FOREIGN KEY (Category) REFERENCES AccountCategories (Id)
)ENGINE = InnoDB;
CREATE TABLE Accounts (
	Id					INT				UNSIGNED	AUTO_INCREMENT		NOT NULL,
	FirstName			TINYTEXT										NOT NULL,
	LastName			TINYTEXT										NOT NULL,
	Email				VARCHAR(255)									NOT NULL,
	Phone				TINYTEXT					DEFAULT NULL,
	Adress				TINYTEXT					DEFAULT NULL,
	Historic			TEXT						DEFAULT NULL,
	Wallet				INT							DEFAULT 0			NOT NULL,
	PermissionLevel		ENUM("Desactived", "Actived", "Banned")
						DEFAULT "Actived"								NOT NULL,
	PortraitPath		TINYTEXT					DEFAULT NULL,
	Division			INT				UNSIGNED						NOT NULL,
	PRIMARY KEY (Id),
	UNIQUE (Email),
	FOREIGN KEY (Division) REFERENCES AccountDivisions (Id)
)ENGINE = InnoDB;
-- ^ AccountsModel's tables creation

CREATE TABLE Companies (
	Id					INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Name				VARCHAR(255)								NOT NULL,
	Phone				TINYTEXT					DEFAULT NULL,
	Email				TINYTEXT					DEFAULT NULL,
	Fax					TINYTEXT					DEFAULT NULL,
	Website				TINYTEXT					DEFAULT NULL,
	Adress				TINYTEXT					DEFAULT NULL,
	Historic			TEXT						DEFAULT NULL,
	LogoPath			TINYTEXT					DEFAULT NULL,
	PRIMARY KEY (Id),
	UNIQUE (Name)
)ENGINE = InnoDB;
CREATE TABLE Contacts (
	Id					INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	FirstName			TINYTEXT									NOT NULL,
	LastName			TINYTEXT									NOT NULL,
	Email				TINYTEXT					DEFAULT NULL,
	Phone				TINYTEXT					DEFAULT NULL,
	Fax					TINYTEXT					DEFAULT NULL,
	Historic			TEXT						DEFAULT NULL,
	PortraitPath		TINYTEXT					DEFAULT NULL,
	Employer			INT				UNSIGNED					NOT NULL,
	PRIMARY	KEY (Id),
	FOREIGN KEY (Employer) REFERENCES Companies (Id) ON DELETE CASCADE
)ENGINE = InnoDB;
CREATE TABLE Invoices (
	Id					INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	PhaseNumber			INT(10)			UNSIGNED	ZEROFILL		NOT NULL,
	PurchaseDate		DATE										NOT NULL,
	PurchaseCost		DECIMAL(12, 2)								NOT NULL,
	Depreciation		INT											NOT NULL,
	Indication			TEXT						DEFAULT NULL,
	ScanPath			TINYTEXT					DEFAULT NULL,
	Provider			INT 			UNSIGNED					NOT NULL,
	PRIMARY KEY (Id),
	UNIQUE (PhaseNumber),
	FOREIGN KEY (ProvIder) REFERENCES Companies (Id)
)ENGINE = InnoDB;
-- ^ InvoicesModel's tables creation

CREATE TABLE ItemStates (
	Id					INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Name				VARCHAR(255)								NOT NULL,
	Description			TEXT						DEFAULT NULL,
	Usable				BOOLEAN						DEFAULT TRUE	NOT NULL,
	PRIMARY KEY (Id),
	UNIQUE (Name)
)ENGINE = InnoDB;
CREATE TABLE ItemCategories (
	Id					INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Name				VARCHAR(255)								NOT NULL,
	Description			TEXT						DEFAULT NULL,
	PRIMARY KEY (Id),
	UNIQUE (Name)
)ENGINE = InnoDB;
CREATE TABLE ItemFunctionalCategories (
	Id					INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Name				VARCHAR(255)								NOT NULL,
	Description			TEXT						DEFAULT NULL,
	Category			INT				UNSIGNED					NOT NULL,
	PRIMARY KEY (Id),
	UNIQUE (Name),
	FOREIGN KEY (Category) REFERENCES ItemCategories (Id)
)ENGINE = InnoDB;
CREATE TABLE ItemBrands (
	Id					INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Name				VARCHAR(255)								NOT NULL,
	Description			TEXT						DEFAULT NULL,
	PRIMARY KEY (Id),
	UNIQUE (Name)
)ENGINE = InnoDB;
CREATE TABLE Items (
	Id					INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	EAN13				INT(13)			UNSIGNED	DEFAULT NULL,
	Reference			TINYTEXT									NOT NULL,
	ReservationCost		INT				UNSIGNED	DEFAULT 1		NOT NULL,
	Consumable			BOOLEAN						DEFAULT FALSE	NOT NULL,
	Reservable			BOOLEAN						DEFAULT TRUE	NOT NULL,
	Description			TEXT						DEFAULT NULL,
	PicturePath			TINYTEXT					DEFAULT NULL,
	Brand				INT				UNSIGNED					NOT NULL,
	RelatedInvoice		INT				UNSIGNED					NOT NULL,
	FunctionalCategory	INT				UNSIGNED					NOT NULL,
	CurrentState		INT				UNSIGNED					NOT NULL,
	PRIMARY KEY (Id),
	UNIQUE (EAN13),
	FOREIGN KEY (Brand) REFERENCES ItemBrands (Id),
	FOREIGN KEY (RelatedInvoice) REFERENCES Invoices (Id),
	FOREIGN KEY (FunctionalCategory) REFERENCES ItemFunctionalCategories (Id),
	FOREIGN KEY (CurrentState) REFERENCES ItemStates (Id)
)ENGINE = InnoDB;
-- ^ ItemsModel's tables creation

CREATE TABLE Packs (
	Id					INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Name				VARCHAR(255)								NOT NULL,
	Description			TEXT						DEFAULT NULL,
	PRIMARY KEY (Id),
	UNIQUE (Name)
)ENGINE = InnoDB;
CREATE TABLE PackagedItems (
	Id					INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	UsedItem			INT				UNSIGNED					NOT NULL,
	UsedPack			INT				UNSIGNED					NOT NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (UsedItem) REFERENCES Items (Id) ON DELETE CASCADE,
	FOREIGN KEY (UsedPack) REFERENCES Packs (Id) ON DELETE CASCADE
)ENGINE = InnoDB;
CREATE TABLE PackagedItemFunctionalCategories (
	Id					INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	UsedItemFunctionalCategory 
						INT				UNSIGNED					NOT NULL,
	UsedPack			INT				UNSIGNED					NOT NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (UsedItemFunctionalCategory) REFERENCES ItemFunctionalCategories (Id),
	FOREIGN KEY (UsedPack) REFERENCES Packs (Id) ON DELETE CASCADE
)ENGINE = InnoDB;
-- ^ PacksModel's tables creation

CREATE TABLE ReservationEvents (
	Id					INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Indication			TEXT						DEFAULT NULL,
	EventState			ENUM("Pending", "Confirmed", "Cancelled")
						DEFAULT "Confirmed"							NOT NULL,
	PlannedStartDate	DATETIME									NOT NULL,
	PlannedEndDate		DATETIME									NOT NULL,
	Reserver			INT				UNSIGNED					NOT NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (Reserver) REFERENCES Accounts (Id)
)ENGINE = InnoDB;
CREATE TABLE ReservedItems (
	Id					INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	RealStartDate		DATETIME					DEFAULT NULL,
	RealEndDate			DATETIME					DEFAULT NULL,
	UsedItem			INT				UNSIGNED					NOT NULL,
	UsedPack			INT				UNSIGNED	DEFAULT NULL,
	InitialState		INT				UNSIGNED					NOT NULL,
	ReturnState			INT				UNSIGNED	DEFAULT NULL,
	Reservation			INT				UNSIGNED					NOT NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (UsedItem) REFERENCES Items (Id) ON DELETE CASCADE,
	FOREIGN KEY (UsedPack) REFERENCES Packs (Id) ON DELETE CASCADE,
	FOREIGN KEY (InitialState) REFERENCES ItemStates (Id),
	FOREIGN KEY (ReturnState) REFERENCES ItemStates (Id),
	FOREIGN KEY (Reservation) REFERENCES ReservationEvents (Id) ON DELETE CASCADE
)ENGINE = InnoDB;
CREATE TABLE RestorationEvents (
	Id					INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Indication			TEXT						DEFAULT NULL,
	EventState			ENUM("Pending", "Confirmed", "Cancelled") 
						DEFAULT "Confirmed"							NOT NULL,
	PlannedStartDate	DATETIME									NOT NULL,
	PlannedEndDate		DATETIME					DEFAULT NULL,
	Restorer			INT				UNSIGNED					NOT NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (Restorer) REFERENCES Companies (Id)
)ENGINE = InnoDB;
CREATE TABLE RestoredItems (
	Id					INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	RealStartDate		DATETIME					DEFAULT NULL,
	RealEndDate			DATETIME					DEFAULT NULL,
	UsedItem			INT				UNSIGNED					NOT NULL,
	InitialState		INT				UNSIGNED					NOT NULL,
	ReturnState			INT				UNSIGNED	DEFAULT NULL,
	Restoration			INT				UNSIGNED					NOT NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (UsedItem) REFERENCES Items (Id) ON DELETE CASCADE,
	FOREIGN KEY (InitialState) REFERENCES ItemStates (Id),
	FOREIGN KEY (ReturnState) REFERENCES ItemStates (Id),
	FOREIGN KEY (Restoration) REFERENCES RestorationEvents (Id) ON DELETE CASCADE
)ENGINE = InnoDB;
-- ^ EventsModel's tables creation
