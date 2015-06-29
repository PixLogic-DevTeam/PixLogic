-- -----------   ---------------------------------------------------------------
-- DESCRIPTION : creates views in PixLogicDB
--      AUTHOR : by Arnaud Frechet, <frechet@intechinfo.fr> 
--   LAST EDIT : on 25 June, 2015
-- -----------   ---------------------------------------------------------------

USE PixLogicDB;

CREATE VIEW view_accounts AS
SELECT Accounts.Id AS "identifier", 
Accounts.Email AS "email",
Accounts.LastName AS "last_name",
Accounts.FirstName AS "first_name",
Accounts.Phone AS "phone",
Accounts.Adress AS "adress",
Accounts.Historic AS "historic",
Accounts.Wallet AS "wallet",
Accounts.Active AS "active",
Accounts.Banned AS "banned",
AccountCategories.Name AS "category", 
AccountDivisions.Name AS "division",
Accounts.PortraitPath AS "portrait"
FROM Accounts INNER JOIN AccountDivisions
ON Accounts.Division = AccountDivisions.Id
INNER JOIN AccountCategories
ON AccountDivisions.Category = AccountCategories.Id
INNER JOIN ReservationEvents
ON Accounts.Id = ReservationEvents.Reserver; -- Add the list of reservations
-- ^ AccountsModel

CREATE VIEW view_invoices AS
SELECT Invoices.Id AS "Identifier",
Invoices.PhaseNumber AS "Phase Number",
Invoices.PurchaseDate AS "Purchase Date",
Invoices.PurchaseCost AS "Purchase Cost",
Invoices.Depreciation AS "Depreciation",
Companies.Name AS "Provider Name"
FROM Invoices INNER JOIN Companies
ON Invoices.Provider = Companies.Id
INNER JOIN Items
ON Invoices.Id = Items.RelatedInvoice; -- Add the list of purchased items
-- ^ InvoicesModel

CREATE VIEW view_items AS
SELECT * -- Select usefull headers
FROM Items INNER JOIN ItemBrands
ON Items.Brand = ItemBrands.Id
INNER JOIN ItemStates
ON Items.CurrentState = ItemStates.Id 
INNER JOIN ItemFunctionalCategories
ON Items.FunctionalCategory = ItemFunctionalCategories.Id
INNER JOIN ItemCategories
ON ItemFunctionalCategories.Category = ItemCategories.Id
INNER JOIN Invoices
ON Items.RelatedInvoice = Invoices.Id;
-- ^ ItemsModel

CREATE VIEW view_packs AS
SELECT * -- Select usefull headers
FROM Packs INNER JOIN PackagedItems
ON Packs.Id = PackagedItems.UsedPack
INNER JOIN Items
ON PackagedItems.UsedItem = Items.Id
INNER JOIN PackagedItemFunctionalCategories
ON Packs.ID = PackagedItemFunctionalCategories.UsedPack
INNER JOIN ItemBrands
ON Items.Brand = ItemBrands.Id
INNER JOIN ItemStates
ON Items.CurrentState = ItemStates.Id
INNER JOIN ItemFunctionalCategories
ON Items.FunctionalCategory = ItemFunctionalCategories.Id
INNER JOIN ItemCategories
ON ItemFunctionalCategories.Category = ItemCategories.Id;
-- ^ PacksModel

CREATE VIEW view_reservations AS
SELECT ReservationEvents.Id AS "Identifier",
Accounts.Email AS "UsedAccountEmail",
DATE_FORMAT(PlanningsInitial.BeginningDate, "%e/%c/%Y %Hh%i") AS "EstimatedBeginningOfReservation",
DATE_FORMAT(PlanningsReal.BeginningDate, "%e/%c/%Y %Hh%i") AS "RealBeginningOfReservation",
DATEDIFF(PlanningsInitial.EndingDate, PlanningsInitial.BeginningDate) AS "InitialDayCount",
DATE_FORMAT(PlanningsInitial.EndingDate, "%e/%c/%Y %Hh%i") AS "EstimatedEndingOfReservation",
DATE_FORMAT(PlanningsReal.EndingDate, "%e/%c/%Y %Hh%i") AS "RealEndingOfReservation",
DATEDIFF(PlanningsReal.EndingDate, PlanningsReal.BeginningDate) AS "RealDayCount",
Packs.Name AS "ReservedPack", 
ItemBrands.Name AS "ItemBrand", 
Items.Reference AS "ItemReference", 
Items.ReservationCost AS "ItemCost",
ItemStatesInitial.Name AS "ItemStateBefore",
ItemStatesReturn.Name AS "ItemStateAfter",
ItemStatesCurrent.Name AS "ItemStateNow"
FROM ReservationItems INNER JOIN ReservationEvents 
ON ReservationItems.Reservation = ReservationEvents.Id 
INNER JOIN Plannings AS PlanningsInitial 
ON ReservationEvents.InitialPlanning = PlanningsInitial.Id
INNER JOIN Plannings AS PlanningsReal
ON ReservationItems.RealPlanning = PlanningsReal.Id
INNER JOIN Packs
ON ReservationItems.RelatedPack = Packs.Id
INNER JOIN Items
ON ReservationItems.ReservedItem = Items.Id
INNER JOIN ItemBrands
ON Items.Brand = ItemBrands.Id
INNER JOIN ItemStates AS ItemStatesInitial
ON ReservationItems.InitialState = ItemStatesInitial.Id
INNER JOIN ItemStates AS ItemStatesReturn
ON ReservationItems.ReturnState = ItemStatesReturn.Id
INNER JOIN ItemStates AS ItemStatesCurrent
ON Items.CurrentState = ItemStatesCurrent.Id
INNER JOIN Accounts
ON ReservationEvents.Reserver = Accounts.Id;

CREATE VIEW view_restorations AS
SELECT * -- Select usefull headers
FROM RestorationEvents INNER JOIN RestorationItems
ON RestorationEvents.Id = RestorationItems.Restoration
INNER JOIN Items
ON RestorationItems.RestoredItem = Items.Id
INNER JOIN ItemBrands
ON Items.Brand = ItemBrands.Id
INNER JOIN ItemStates
ON Items.CurrentState = ItemStates.Id
INNER JOIN Invoices
ON Items.RelatedInvoice = Invoices.Id;
-- EventsModel