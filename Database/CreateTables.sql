-- -----------   ---------------------------------------------------------------
-- DESCRIPTION : create tables in PixLogicDB
--      AUTHOR : by Arnaud Frechet, <frechet@intechinfo.fr> 
--   LAST EDIT : on 25 June, 2015
-- -----------   ---------------------------------------------------------------

USE PixLogicDB;

CREATE TABLE AccountCategories (
	Id					INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Name				VARCHAR(255)								NOT NULL,
	Description			TINYTEXT					DEFAULT NULL,
	PRIMARY KEY (Id),
	UNIQUE (Name)
)ENGINE = InnoDB;
CREATE TABLE AccountDivisions (
	Id					INT				UNSIGNED	AUTO_INCREMENT		NOT NULL,
	Name				VARCHAR(255)									NOT NULL,
	Description			TINYTEXT					DEFAULT NULL,
	ReservationMod		ENUM("Inactive", "Active", "Free")
													DEFAULT "Active"	NOT NULL,
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
	Historic			LONGTEXT					DEFAULT NULL,
	Wallet				INT							DEFAULT 0			NOT NULL,
	AccountState		ENUM("Inactive", "Active", "Banned")
													DEFAULT "Active"	NOT NULL,
	PortraitPath		TINYTEXT					DEFAULT NULL,
	Division			INT				UNSIGNED						NOT NULL,
	PRIMARY KEY (Id),
	UNIQUE (Email),
	FOREIGN KEY (Division) REFERENCES AccountDivisions (Id)
)ENGINE = InnoDB;
-- ^ AccountsModel

CREATE TABLE Companies (
	Id					INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Name				VARCHAR(255)								NOT NULL,
	Phone				TINYTEXT					DEFAULT NULL,
	Email				TINYTEXT					DEFAULT NULL,
	Fax					TINYTEXT					DEFAULT NULL,
	Website				TINYTEXT					DEFAULT NULL,
	Adress				TINYTEXT					DEFAULT NULL,
	LogoPath			TINYTEXT					DEFAULT NULL,
	PRIMARY KEY (Id),
	UNIQUE (Name)
)ENGINE = InnoDB;
CREATE TABLE Contacts (
	Id					INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	FirstName			TINYTEXT									NOT NULL,
	LastName			TINYTEXT									NOT NULL,
	Phone				TINYTEXT					DEFAULT NULL,
	Email				TINYTEXT					DEFAULT NULL,
	Fax					TINYTEXT					DEFAULT NULL,
	PortraitPath		TINYTEXT					DEFAULT NULL,
	Employer			INT				UNSIGNED					NOT NULL,
	PRIMARY	KEY (Id),
	FOREIGN KEY (Employer) REFERENCES Companies (Id)
)ENGINE = InnoDB;
CREATE TABLE Invoices (
	Id					INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	PhaseNumber			INT(10)			UNSIGNED	ZEROFILL		NOT NULL,
	PurchaseDate		DATE										NOT NULL,
	PurchaseCost		DECIMAL(12, 2)								NOT NULL,
	Depreciation		INT											NOT NULL,
	ScanPath			TINYTEXT					DEFAULT NULL,
	Provider			INT 			UNSIGNED					NOT NULL,
	PRIMARY KEY (Id),
	UNIQUE (PhaseNumber),
	FOREIGN KEY (ProvIder) REFERENCES Companies (Id)
)ENGINE = InnoDB;
-- ^ InvoicesModel

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
-- ^ ItemsModel

CREATE TABLE Packs (
	Id					INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Name				VARCHAR(255)								NOT NULL,
	Description			TEXT						DEFAULT NULL,
	Reservable			BOOLEAN						DEFAULT TRUE	NOT NULL,
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
	FOREIGN KEY (UsedItemFunctionalCategory) REFERENCES ItemFunctionalCategories (Id) ON DELETE CASCADE,
	FOREIGN KEY (UsedPack) REFERENCES Packs (Id) ON DELETE CASCADE
)ENGINE = InnoDB;
-- ^ PacksModel

CREATE TABLE Plannings (
	Id					INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	BeginningDate		DATETIME									NOT NULL,
	EndingDate			DATETIME					DEFAULT NULL,
	PRIMARY KEY (Id)
)ENGINE = InnoDB;
CREATE TABLE ReservationEvents (
	Id					INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Indication			TINYTEXT					DEFAULT NULL,
	TakenOut			BOOLEAN						DEFAULT FALSE	NOT NULL,
	InitialPlanning		INT				UNSIGNED					NOT NULL,
	Reserver			INT				UNSIGNED					NOT NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (InitialPlanning) REFERENCES Plannings (Id),
	FOREIGN KEY (Reserver) REFERENCES Accounts (Id)
)ENGINE = InnoDB;
CREATE TABLE ReservationItems (
	Id					INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Reservation			INT				UNSIGNED					NOT NULL,
	RealPlanning		INT				UNSIGNED					NOT NULL,
	ReservedItem		INT				UNSIGNED					NOT NULL,
	RelatedPack			INT				UNSIGNED	DEFAULT NULL,
	InitialState		INT				UNSIGNED					NOT NULL,
	ReturnState			INT				UNSIGNED	DEFAULT NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (Reservation) REFERENCES ReservationEvents (Id) ON DELETE CASCADE,
	FOREIGN KEY (RealPlanning) REFERENCES Plannings (Id),
	FOREIGN KEY (ReservedItem) REFERENCES Items (Id) ON DELETE CASCADE,
	FOREIGN KEY (RelatedPack) REFERENCES Packs (Id) ON DELETE CASCADE,
	FOREIGN KEY (InitialState) REFERENCES ItemStates (Id),
	FOREIGN KEY (ReturnState) REFERENCES ItemStates (Id)
)ENGINE = InnoDB;
CREATE TABLE RestorationEvents (
	Id					INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Indication			TINYTEXT					DEFAULT NULL,
	TakenOut			BOOLEAN						DEFAULT FALSE	NOT NULL,
	InitialPlanning		INT				UNSIGNED					NOT NULL,
	Restorer			INT				UNSIGNED					NOT NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (InitialPlanning) REFERENCES Plannings (Id),
	FOREIGN KEY (Restorer) REFERENCES Companies (Id)
)ENGINE = InnoDB;
CREATE TABLE RestorationItems (
	Id					INT				UNSIGNED 	AUTO_INCREMENT	NOT NULL,
	Restoration			INT				UNSIGNED					NOT NULL,
	RealPlanning		INT				UNSIGNED					NOT NULL,
	RestoredItem		INT				UNSIGNED					NOT NULL,
	RelatedPack			INT				UNSIGNED	DEFAULT NULL,
	InitialState		INT				UNSIGNED					NOT NULL,
	ReturnState			INT				UNSIGNED	DEFAULT NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (Restoration) REFERENCES RestorationEvents (Id) ON DELETE CASCADE,
	FOREIGN KEY (RealPlanning) REFERENCES Plannings (Id),
	FOREIGN KEY (RestoredItem) REFERENCES Items (Id) ON DELETE CASCADE,
	FOREIGN KEY (RelatedPack) REFERENCES Packs (Id) ON DELETE CASCADE,
	FOREIGN KEY (InitialState) REFERENCES ItemStates (Id),
	FOREIGN KEY (ReturnState) REFERENCES ItemStates (Id)
)ENGINE = InnoDB;
-- ^ EventsModel
