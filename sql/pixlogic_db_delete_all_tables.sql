-- -----------------------------------------------------
-- DESCRIPTION : delete tables in pixlogic_db
-- AUTHOR : Arnaud Frechet <frechet@intechinfo.fr> 
-- LAST EDIT : 27 May, 2015
-- -----------------------------------------------------
USE pixlogic_db;

-- -----------------------------------------------------
-- Delete the data (reserve order of insert)
-- -----------------------------------------------------
DROP TABLE consumables_categories_in_packs;
DROP TABLE consumables_items_in_packs;
DROP TABLE capitalized_categories_in_packs;
DROP TABLE capitalized_items_in_packs;
DROP TABLE packs;
-- ^ Packs data ^
DROP TABLE consumables_reserved;
DROP TABLE capitalized_reserved;
DROP TABLE reservations;
-- ^ Reservations data ^
DROP TABLE consumables;
DROP TABLE consumables_sub_categories;
DROP TABLE consumables_main_categories;
-- ^ Consumables data ^
DROP TABLE repairs;
DROP TABLE capitalized;
DROP TABLE capitalized_sub_categories;
DROP TABLE capitalized_main_categories;
-- ^ Capitalized data ^
DROP TABLE states;
DROP TABLE brands;
-- ^ Brands and states data ^
DROP TABLE invoices;
DROP TABLE contacts;
DROP TABLE companies;
-- ^ Accounting data ^
DROP TABLE accounts;
DROP TABLE accounts_sub_categories;
DROP TABLE accounts_main_categories;
-- ^ Users' accounts data ^
