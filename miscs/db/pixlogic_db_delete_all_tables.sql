-- -----------   ---------------------------------------------------------------
-- DESCRIPTION : delete tables in PixLogicDB
--      AUTHOR : by Arnaud Frechet, <frechet@intechinfo.fr> 
--   LAST EDIT : on 09 June, 2015
-- -----------   ---------------------------------------------------------------

USE PixLogicDB;

DROP TABLE  RecoveryItem;
DROP TABLE  RecoveryEvent;
-- ^ RecoveriesModel

DROP TABLE  ReservationItem; 
DROP TABLE  ReservationEvent; 
DROP TABLE  ReservationPlanning;
-- ^ ReservationsModel

DROP TABLE  PackagedItemCategory; 
DROP TABLE  PackagedItem;
DROP TABLE  Pack;
-- ^ PacksModel

DROP TABLE  ItemRestoration; 
DROP TABLE  Item;
DROP TABLE  ItemState; 
DROP TABLE  ItemBrand;
DROP TABLE  ItemSubCategory;
DROP TABLE  ItemMainCategory;
-- ^ ItemsModel

DROP TABLE  Invoice;
DROP TABLE  Contact;
DROP TABLE  Company;
-- ^ InvoicesModel

DROP TABLE  Account;
DROP TABLE  AccountSubCategory;
DROP TABLE  AccountMainCategory;
-- ^ AccountsModel
