-- -----------   ---------------------------------------------------------------
-- DESCRIPTION : erase PixLogicDB, recreate it and configure it
--      AUTHOR : by Arnaud Frechet, <frechet@intechinfo.fr> 
--   LAST EDIT : on 25 June, 2015
-- -----------   ---------------------------------------------------------------

DROP DATABASE IF EXISTS PixLogicDB;
CREATE DATABASE PixLogicDB;
ALTER DATABASE PixLogicDB CHARACTER SET utf8 COLLATE utf8_general_ci;
