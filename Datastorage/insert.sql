-- -----------   ---------------------------------------------------------------
-- DESCRIPTION : insert data in PixLogicDB, removing others data
--      AUTHOR : by Arnaud Frechet, <frechet@intechinfo.fr> 
--   LAST EDIT : on 29 June, 2015
-- -----------   ---------------------------------------------------------------

USE PixLogicDB;

DELETE FROM RestoredItems;
DELETE FROM RestorationEvents;
DELETE FROM ReservedItems;
DELETE FROM ReservationEvents;
-- ^ EventsModel's data deletion

DELETE FROM PackagedItemFunctionalCategories;
DELETE FROM PackagedItems;
DELETE FROM Packs;
-- | PacksModel's data deletion

DELETE FROM Items;
DELETE FROM ItemBrands;
DELETE FROM ItemFunctionalCategories;
DELETE FROM ItemCategories;
DELETE FROM ItemStates;
-- ^ ItemsModel's data deletion

DELETE FROM Invoices;
DELETE FROM Contacts;
DELETE FROM Companies;
-- ^ InvoicesModel's data deletion

DELETE FROM Accounts;
DELETE FROM AccountDivisions;
DELETE FROM AccountCategories;
-- ^ AccountsModel's data deletion

INSERT INTO AccountCategories 
	(Id,	Name,		Description) 
VALUES 
	(1,		"Étudiant",	"Étudiant en photographie");

INSERT INTO AccountDivisions 
	(Id,	Name,		Description,					Category) 
VALUES 
	(1,		"CE3P/13", "Promotion de septembre 2013",	1);

INSERT INTO Accounts 
	(Id,	FirstName,	LastName,		Email,					PermissionLevel,	Division) 
VALUES 
	(1,		"Bob", 		"Maurane",		"bmaurane@email.com",	"Actived",			1), 
	(2,		"Charles",	"Gaulle (de)",	"cdegaulle@email.com",	"Desactived",		1), 
	(3,		"Robert",	"Badinter",		"rbadinter@email.com",	"Actived",			1), 
	(4,		"Benny",	"Hill",			"bhill@email.com",		"Actived",			1);
-- ^ AccountsModel's data insertion

INSERT INTO Companies 
	(Id,	Name,	Website) 
VALUES 
	(1,		"MX2",	"www.MX2.fr"), 
	(2,		"Rakuten Group", "www.priceminister.com"), 
	(3,		"Groupe Ebay", "www.ebay.fr"), 
	(4,		"Photo Ciné Réparation", "www.photo-cine-reparation.com");

INSERT INTO Invoices 
	(Id,	PhaseNumber,	PurchaseDate,	PurchaseCost,	Depreciation,	Provider) 
VALUES 
	(1,		0,				"2015-05-19",	6.30,			100,			1), 
	(2,		1,				"2015-05-19",	100,			20,				2), 
	(3,		2,				"2015-05-20",	95,				20,				3);
-- ^ InvoicesModel's data insertion

INSERT INTO ItemStates 
	(Id,	Name,			Usable) 
VALUES 
	(1,		"Neuf",	true), 
	(2,		"Occasion",		true), 
	(3,		"Cassé(e)",		false),
	(4,		"Bonne état",	true),
	(5,		"Mauvais état",	true);

INSERT INTO ItemCategories 
	(Id,	Name) 
VALUES 
	(1,		"Appareil photo"), 
	(2,		"Flash"), 
	(3,		"Pellicule");

INSERT INTO ItemFunctionalCategories 
	(Id,	Name,							Category) 
VALUES 
	(1,		"Appareil photo reflex",		1), 
	(2,		"Flash Canon",					2), 
	(3,		"Pellicule photo argentique",	3);

INSERT INTO ItemBrands 
	(Id,	Name) 
VALUES 
	(1,		"Canon"), 
	(2,		"ADOX");

INSERT INTO Items 
	(Id,	Reference,				ReservationCost,	Consumable,	Reservable,	Description,	Brand,	RelatedInvoice,	FunctionalCategory, CurrentState) 
VALUES 
	(1,		"AE1 Program",			100,				false,		true,		"",				1,		2,				1,					2), 
	(2,		"AE1 Program",			100,				false,		true,		"",				1,		3,				1,					2), 
	(3,		"Flash speedlite 166A",	10,					false,		true,		"",				1,		3,				2,					3), 
	(4,		"CMS 20 II 36poses",	10,					true,		true,		"Film négatif pellicule photo n&b ADOX Silvermax 100iso 36poses 24x36 135\nFilm basé sur l'émulsion de la AGFA APX 100 mais plus riche en argent.\n\nExtrait de l'article rédigé par Philippe Bachelier dans le magazine Réponses Photo No 248 Page 114, Novembre 2012\n\"La particularité de ce film est de convenir aussi bien pour réaliser des négatifs que des positifs. Son émulsion posséde un taux d'argent élevé, d'où son nom.\nAdox annonce une capacité à différencier 14IL avec un révélateur liquide concentré dédié, lui aussi nommé Silvermax.\nSa couche anti-halo, placée entre le support (du triacétate) et l'émulsion, est censée favoriser une netteté d'image optimale.\nLa granulation serait aussi fine que sur les films utilisant des grains tabulaires.\"\n\nTemps de développement dans de l'ADOX Silvermax : 11min/ 20°C", 
																								2,		1,				3,					3);
-- ^ ItemsModel's data insertion

INSERT INTO Packs 
	(Id,	Name, Description) 
VALUES 
	(1,		"Pack argentique", "Canon AE1 Program, Flash speedlite 166A, ADOX CMS 20 II 36poses"), 
	(2,		"Pack argentique générique", "Appareil photo reflex, Flash Canon, Pellicule photo Argentique"),
	(3,		"Pack Argentique mix (appareil au choix)", "Appareil photo reflex,  Flash speedlite 166A, ADOX CMS 20 II 36poses");

INSERT INTO PackagedItems 
	(Id,	UsedItem,	UsedPack) 
VALUES 
	(1,		1,			1), 
	(2,		3,			1), 
	(3,		4,			1),
	(4, 	3,			3),
	(5,		4,			3);

INSERT INTO PackagedItemFunctionalCategories 
	(Id,	UsedItemFunctionalCategory, UsedPack) 
VALUES 
	(1,		1,							2), 
	(2,		2,							2), 
	(3,		3,							2),
	(4,		1,							3);
-- ^ PacksModel's data insertion

INSERT INTO ReservationEvents 
	(Id,	EventState, 	PlannedStartDate,	PlannedEndDate,		Reserver) 
VALUES 
	(1,		"Confirmed",			"2015-05-02 10:00",	"2015-05-06 17:00",	1), 
	(2,		"Confirmed",			"2015-05-12 10:00",	"2015-05-14 17:00",	1),
	(3,		"Cancelled",		"2015-05-20 10:00", "2015-05-20 17:00", 2);

INSERT INTO ReservedItems 
	(Id,	RealStartDate,		RealEndDate,		UsedItem,	UsedPack,	InitialState,	ReturnState,	Reservation) 
VALUES 
	(1,		"2015-05-02 10:25",	"2015-05-11 12:30",	1,			1,			1,				1,				1), 
	(2,		"2015-05-02 10:25",	"2015-05-11 12:30",	3,			1,			2,				2,				1), 
	(3,		"2015-05-02 10:25",	"2015-05-11 12:30",	4,			1,			1,				1,				1), 
	(4,		"2015-05-12 10:15",	"2015-05-14 18:00",	1,			2,			1,				1,				2), 
	(5,		"2015-05-12 10:15",	"2015-05-14 18:00",	3,			2,			2,				3,				2), 
	(6,		"2015-05-12 10:15",	"2015-05-14 18:00",	4,			2,			1,				3,				2),
	(7,		"2015-05-20 10:00", "2015-05-20 10:00", 3,			null,		2,				2,				3);

INSERT INTO RestorationEvents 
	(Id,	EventState,	PlannedStartDate,	PlannedEndDate,		Restorer) 
VALUES 
	(1,		"Confirmed",			"2015-05-25 9:05",	"2015-07-01 14:45",	4);

INSERT INTO RestoredItems 
	(Id,	RealStartDate,		RealEndDate,		UsedItem,	InitialState,	ReturnState,	Restoration) 
VALUES 
	(1,		"2015-05-25 9:05",	"2015-07-01 14:45",	2,			3,				4,				1),
	(2,		"2015-05-25 9:05",	"2015-07-01 14:45",	3,			3,				5,				1);
-- ^ EventsModel's data insertion
