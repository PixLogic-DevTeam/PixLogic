-- -----------   ---------------------------------------------------------------
-- DESCRIPTION : empty the tables in PixLogicDB
--      AUTHOR : by Arnaud Frechet, <frechet@intechinfo.fr> 
--   LAST EDIT : on 11 June, 2015
-- -----------   ---------------------------------------------------------------

USE PixLogicDB;

DELETE FROM RecoveryItems;
DELETE FROM RecoveryEvents;
-- ^ RecoveriesModel

DELETE FROM ReservationItems; 
DELETE FROM ReservationEvents; 
DELETE FROM ReservationPlannings;
-- ^ ReservationsModel

DELETE FROM PackagedItemCategories; 
DELETE FROM PackagedItems;
DELETE FROM Packs;
-- | PacksModel

DELETE FROM ItemRestorations;
DELETE FROM Items;
DELETE FROM ItemStates;
DELETE FROM ItemBrands;
DELETE FROM ItemSubCategories;
DELETE FROM ItemMainCategories;
-- ^ ItemsModel

DELETE FROM Invoices;
DELETE FROM Contacts;
DELETE FROM Companies;
-- ^ InvoicesModel

DELETE FROM Accounts;
DELETE FROM AccountSubCategories;
DELETE FROM AccountMainCategories;
-- ^ AccountsModel
