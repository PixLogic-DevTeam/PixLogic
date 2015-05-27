-- -----------------------------------------------------
-- DESCRIPTION : delete data in pixlogic_db
-- AUTHOR : Arnaud Frechet <frechet@intechinfo.fr> 
-- LAST EDIT : 27 May, 2015
-- -----------------------------------------------------
USE pixlogic_db;

-- -----------------------------------------------------
-- Delete the data (reserve order of insert)
-- -----------------------------------------------------
DELETE FROM consumables_categories_in_packs;
DELETE FROM consumables_items_in_packs;
DELETE FROM capitalized_categories_in_packs;
DELETE FROM capitalized_items_in_packs;
DELETE FROM packs;
-- ^ Packs data ^
DELETE FROM consumables_reserved;
DELETE FROM capitalized_reserved;
DELETE FROM reservations;
-- ^ Reservations data ^
DELETE FROM consumables;
DELETE FROM consumables_sub_categories;
DELETE FROM consumables_main_categories;
-- ^ Consumables data ^
DELETE FROM repairs;
DELETE FROM capitalized;
DELETE FROM capitalized_sub_categories;
DELETE FROM capitalized_main_categories;
-- ^ Capitalized data ^
DELETE FROM states;
DELETE FROM brands;
-- ^ Common data ^
DELETE FROM invoices;
DELETE FROM contacts;
DELETE FROM companies;
-- ^ Accounting data ^
DELETE FROM accounts;
DELETE FROM accounts_sub_categories;
DELETE FROM accounts_main_categories;
-- ^ Users' accounts data ^
