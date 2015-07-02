-- -----------   ---------------------------------------------------------------
-- DESCRIPTION : create views in PixLogicDB, removing previous views' versions
--      AUTHOR : by Arnaud Frechet, <frechet@intechinfo.fr> 
--   LAST EDIT : on 29 June, 2015
-- -----------   ---------------------------------------------------------------

USE PixLogicDB;

DROP VIEW IF EXISTS view_accounts;
-- ^ AccountsModel's view deletion

DROP VIEW IF EXISTS view_invoices;
-- ^ InvoicesModel's view deletion

DROP VIEW IF EXISTS view_items;
-- ^ ItemsModel's view deletion

DROP VIEW IF EXISTS view_packs;
-- ^ PacksModel's view deletion

DROP VIEW IF EXISTS view_reservations;
DROP VIEW IF EXISTS view_restorations;
-- ^ EventsModel's views deletion

CREATE VIEW view_accounts AS
SELECT Accounts.Id AS "AccountId", 
AccountCategories.Name AS "AccountCategory", 
AccountDivisions.Name AS "AccountDivision", 
Accounts.FirstName AS "AccountFirstName", 
Accounts.LastName AS "AccountLastName", 
Accounts.Email AS "AccountEmail", 
Accounts.Phone AS "AccountPhone", 
Accounts.Adress AS "AccountAdress", 
Accounts.Historic AS "AccountHistoric", 
Accounts.Wallet AS "AccountWallet", 
Accounts.PermissionLevel AS "AccountPermissionLevel", 
AccountDivisions.ReservationRight AS "DivisionReservationRight", 
Accounts.PortraitPath AS "AccountPortrait"
FROM Accounts INNER JOIN AccountDivisions
ON Accounts.Division = AccountDivisions.Id
INNER JOIN AccountCategories
ON AccountDivisions.Category = AccountCategories.Id;
-- ^ AccountsModel's view creation

CREATE VIEW view_invoices AS
SELECT Invoices.Id AS "InvoiceId",
Invoices.PhaseNumber AS "InvoicePhaseNumber",
Invoices.PurchaseDate AS "InvoiceDate",
Invoices.PurchaseCost AS "InvoiceCost",
Invoices.Depreciation AS "InvoiceDepreciation",
Invoices.Indication AS "InvoiceIndication",
Invoices.ScanPath AS "InvoiceScan",
Companies.Name AS "ProviderName"
FROM Invoices INNER JOIN Companies
ON Invoices.Provider = Companies.Id;
-- ^ InvoicesModel's view creation

CREATE VIEW view_items AS
SELECT Items.Id AS "ItemId",
ItemCategories.Name AS "ItemCategory",
ItemFunctionalCategories.Name AS "ItemFunctionalCategory",
Items.EAN13 AS "ItemEAN13",
ItemBrands.Name AS "ItemBrand",
Items.Reference AS "ItemReference",
Items.Description AS "ItemDescription",
Items.PicturePath AS "ItemPicture",
ItemStates.Name AS "ItemStateNow",
ItemStates.Usable AS "ItemIsUsable",
Items.Consumable AS "ItemIsConsumable",
Items.Reservable AS "ItemIsReservable",
Invoices.PhaseNumber AS "InvoicePhaseNumber"
FROM Items INNER JOIN Invoices 
ON Items.RelatedInvoice = Invoices.Id 
INNER JOIN ItemStates 
ON Items.CurrentState = ItemStates.Id 
INNER JOIN ItemBrands 
ON Items.Brand = ItemBrands.Id 
INNER JOIN ItemFunctionalCategories 
ON Items.FunctionalCategory = ItemFunctionalCategories.Id 
INNER JOIN ItemCategories 
ON ItemFunctionalCategories.Category = ItemCategories.Id;
-- ^ ItemsModel's view creation

CREATE VIEW view_packs AS 
SELECT Packs.Id AS "PackId", 
Packs.Name AS "PackName", 
Packs.Description AS "PackDescription", 
ItemCategories.Name AS "ItemCategory", 
ItemFunctionalCategories.Name AS "ItemFunctionalCategory", 
Items.EAN13 AS "ItemEAN13", 
ItemBrands.Name AS "ItemBrand", 
Items.Reference AS "ItemReference", 
Items.Description AS "ItemDescription", 
Items.ReservationCost AS "ItemCost", 
ItemStates.Name AS "ItemStateNow", 
ItemStates.Usable AS "ItemIsUsable", 
Items.Consumable AS "ItemIsConsumable" 
FROM Packs INNER JOIN PackagedItems 
ON Packs.Id = PackagedItems.UsedPack 
INNER JOIN Items 
ON PackagedItems.UsedItem = Items.Id 
INNER JOIN ItemStates 
ON Items.CurrentState = ItemStates.Id 
INNER JOIN ItemBrands 
ON Items.Brand = ItemBrands.Id 
INNER JOIN ItemFunctionalCategories 
ON Items.FunctionalCategory = ItemFunctionalCategories.Id 
INNER JOIN ItemCategories 
ON ItemFunctionalCategories.Category = ItemCategories.Id 
UNION
SELECT Packs.Id AS "PackId",
Packs.Name AS "PackName",
Packs.Description AS "PackDescription",
ItemCategories.Name AS "ItemCategory",
ItemFunctionalCategories.Name AS "ItemFunctionalCategory",
null, /* ItemEAN13 */
null, /* ItemBrand */
null, /* ItemReference */
null, /* ItemDescription */
null, /* ItemCost */
null, /* ItemStateNow*/
null, /* ItemIsUsable*/
null  /* ItemIsConsumable*/
FROM Packs INNER JOIN PackagedItemFunctionalCategories
ON Packs.Id = PackagedItemFunctionalCategories.UsedPack
INNER JOIN ItemFunctionalCategories
ON PackagedItemFunctionalCategories.UsedITemFunctionalCategory = ItemFunctionalCategories.Id
INNER JOIN ItemCategories
ON ItemFunctionalCategories.Category = ItemCategories.Id;
-- ^ PacksModel's view creation

CREATE VIEW view_reservations AS
SELECT ReservationEvents.Id AS "ReservationId", 
ReservationEvents.EventState AS "ReservationEventState",
ReservationEvents.Indication AS "ReservationIndication",
Accounts.Email AS "ReserverEmail", 
Accounts.Wallet AS "ReserverWallet",
Accounts.Historic AS "ReserverHistoric",
ReservationEvents.PlannedStartDate AS "PlannedStartDate", 
ReservedItems.RealStartDate AS "RealStartDate", 
ReservationEvents.PlannedEndDate AS "PlannedEndDate", 
ReservedItems.RealEndDate AS "RealEndDate", 
Packs.Name AS "UsedPack", 
Items.EAN13 AS "ItemEAN13",
ItemBrands.Name AS "ItemBrand", 
Items.Reference AS "ItemReference", 
Items.Description AS "ItemDescription", 
Items.ReservationCost AS "ItemCost", 
ItemStateBefore.Name AS "ItemStateBefore", 
ItemStateAfter.Name AS "ItemStateAfter", 
ItemStateNow.Name AS "ItemStateNow",
ItemStateNow.Usable AS "ItemIsUsable", 
Items.Consumable AS "ItemIsConsumable"
FROM ReservedItems INNER JOIN ReservationEvents 
ON ReservedItems.Reservation = ReservationEvents.Id 
INNER JOIN Items
ON ReservedItems.UsedItem = Items.Id
INNER JOIN ItemStates AS ItemStateNow
ON Items.CurrentState = ItemStateNow.Id
INNER JOIN ItemStates AS ItemStateAfter
ON ReservedItems.ReturnState = ItemStateAfter.Id
INNER JOIN ItemStates AS ItemStateBefore
ON ReservedItems.InitialState = ItemStateBefore.Id
INNER JOIN ItemBrands
ON Items.Brand = ItemBrands.Id
INNER JOIN Packs
ON ReservedItems.UsedPack = Packs.Id
INNER JOIN Accounts
ON ReservationEvents.Reserver = Accounts.Id;

CREATE VIEW view_restorations AS 
SELECT RestorationEvents.Id AS "RestorationId", 
RestorationEvents.Indication AS "RestorationIndication", 
RestorationEvents.EventState AS "RestorationEventState", 
Companies.Name AS "RestorerName", 
RestorationEvents.PlannedStartDate AS "PlannedStartDate", 
RestoredItems.RealStartDate AS "RealStartDate", 
RestorationEvents.PlannedEndDate AS "PlannedEndDate", 
RestoredItems.RealEndDate AS "RealEndDate", 
Items.EAN13 AS "ItemEAN13", 
ItemBrands.Name AS "ItemBrand", 
Items.Reference AS "ItemReference", 
Items.Description AS "ItemDescription", 
ItemStateBefore.Name AS "ItemStateBefore", 
ItemStateAfter.Name AS "ItemStateAfter", 
ItemStateNow.Name AS "ItemStateNow", 
ItemStateNow.Usable AS "ItemIsUsable", 
Items.Reservable AS "ItemIsReservable", 
Items.Consumable AS "ItemIsConsumable" 
FROM RestoredItems INNER JOIN RestorationEvents 
ON RestoredItems.Restoration = RestorationEvents.Id 
INNER JOIN Items 
ON RestoredItems.UsedItem = Items.Id 
INNER JOIN ItemStates AS ItemStateNow 
ON Items.CurrentState = ItemStateNow.Id 
INNER JOIN ItemStates AS ItemStateAfter 
ON RestoredItems.ReturnState = ItemStateAfter.Id 
INNER JOIN ItemStates AS ItemStateBefore 
ON RestoredItems.InitialState = ItemStateBefore.Id 
INNER JOIN ItemBrands 
ON Items.Brand = ItemBrands.Id 
INNER JOIN Companies 
ON RestorationEvents.Restorer = Companies.Id;
-- EventsModel's views creation
