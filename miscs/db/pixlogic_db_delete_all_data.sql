-- -----------   ---------------------------------------------------------------
-- DESCRIPTION : delete data in PixLogicDB
--      AUTHOR : by Arnaud Frechet, <frechet@intechinfo.fr> 
--   LAST EDIT : on 09 June, 2015
-- -----------   ---------------------------------------------------------------

USE PixLogicDB;

DELETE FROM RecoveryItem;
DELETE FROM RecoveryEvent;
-- ^ RecoveriesModel

DELETE FROM ReservationItem; 
DELETE FROM ReservationEvent; 
DELETE FROM ReservationPlanning;
-- ^ ReservationsModel

DELETE FROM PackagedItemCategory; 
DELETE FROM PackagedItem;
DELETE FROM Pack;
-- | PacksModel

DELETE FROM ItemRestoration;
DELETE FROM Item;
DELETE FROM ItemState;
DELETE FROM ItemBrand;
DELETE FROM ItemSubCategory;
DELETE FROM ItemMainCategory;
-- ^ ItemsModel

DELETE FROM Invoice;
DELETE FROM Contact;
DELETE FROM Company;
-- ^ InvoicesModel

DELETE FROM Account;
DELETE FROM AccountSubCategory;
DELETE FROM AccountMainCategory;
-- ^ AccountsModel
