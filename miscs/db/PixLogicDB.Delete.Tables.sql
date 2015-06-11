-- -----------   ---------------------------------------------------------------
-- DESCRIPTION : delete tables in PixLogicDB
--      AUTHOR : by Arnaud Frechet, <frechet@intechinfo.fr> 
--   LAST EDIT : on 11 June, 2015
-- -----------   ---------------------------------------------------------------

USE PixLogicDB;

DROP TABLE  RecoveryItems;
DROP TABLE  RecoveryEvents;
-- ^ RecoveriesModel

DROP TABLE  ReservationItems; 
DROP TABLE  ReservationEvents; 
DROP TABLE  ReservationPlannings;
-- ^ ReservationsModel

DROP TABLE  PackagedItemCategories; 
DROP TABLE  PackagedItems;
DROP TABLE  Packs;
-- ^ PacksModel

DROP TABLE  ItemRestorations; 
DROP TABLE  Items;
DROP TABLE  ItemStates; 
DROP TABLE  ItemBrands;
DROP TABLE  ItemSubCategories;
DROP TABLE  ItemMainCategories;
-- ^ ItemsModel

DROP TABLE  Invoices;
DROP TABLE  Contacts;
DROP TABLE  Companies;
-- ^ InvoicesModel

DROP TABLE  Accounts;
DROP TABLE  AccountSubCategories;
DROP TABLE  AccountMainCategories;
-- ^ AccountsModel
