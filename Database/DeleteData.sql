-- -----------   ---------------------------------------------------------------
-- DESCRIPTION : delete data in PixLogicDB
--      AUTHOR : by Arnaud Frechet, <frechet@intechinfo.fr> 
--   LAST EDIT : on 25 June, 2015
-- -----------   ---------------------------------------------------------------

USE PixLogicDB;

DELETE FROM RestorationItems;
DELETE FROM RestorationEvents;
DELETE FROM ReservationItems; 
DELETE FROM ReservationEvents; 
DELETE FROM Plannings;
-- ^ EventsModel

DELETE FROM PackagedItemFunctionalCategories; 
DELETE FROM PackagedItems;
DELETE FROM Packs;
-- | PacksModel

DELETE FROM Items;
DELETE FROM ItemBrands;
DELETE FROM ItemFunctionalCategories;
DELETE FROM ItemCategories;
DELETE FROM ItemStates;
-- ^ ItemsModel

DELETE FROM Invoices;
DELETE FROM Contacts;
DELETE FROM Companies;
-- ^ InvoicesModel

DELETE FROM Accounts;
DELETE FROM AccountDivisions;
DELETE FROM AccountCategories;
-- ^ AccountsModel
