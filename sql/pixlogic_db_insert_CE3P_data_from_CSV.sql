-- -----------------------------------------------------
-- DESCRIPTION : try to insert data in pixlogic_db from
-- CSV files
-- AUTHOR : Benoit Humblot <humblot@intechinfo.fr> 
-- LAST EDIT : 20 May, 2015
-- -----------------------------------------------------
USE pixlogic_db;

INSERT INTO capitalized_main_categories (id, name)
VALUES 
(1, "Boitiers"),
(2, "Optiques"),
(3, "Boitiers"),
(4, "Dos"),
(5, "Eclairage"),
(6, "Chambres"),
(7, "Divers");

INSERT INTO capitalized_sub_categories (id, name, main_category)
VALUES 
(1, "Cellules de mesure", 7),
(2, "Divers studio", 7),
(3, "Eclairage studio", 5),
(4, "Chambres photographiques", 6),
(5, "Accessoires eclairage", 5),
(6, "Eclairage reportage", 5),
(7, "Optiques moyen format", 2),
(8, "Boitiers PF argentique", 1),
(9, "Boitiers moyen format", 1),
(10, "Boitiers numérique", 3),
(11, "Dos numérique", 4),
(12, "Optiques chambre", 2),
(13, "Optiques reflex", 2),
(14, "Equipement", 7);

INSERT INTO brands(id, name)
VALUES (1, "Non définie");

INSERT INTO states (id, name)
VALUES (1, "Non défini");

INSERT INTO companies (id, name)
VALUES (1, "Non défini");

LOAD DATA INFILE "./invoices_raw_data.csv" 
INTO TABLE invoices
FIELDS TERMINATED BY ";" 
ENCLOSED BY ""
LINES TERMINATED BY "\n"
IGNORE 1 ROWS;

LOAD DATA INFILE "./capitalized_with_no_ean13_raw_data.csv"
INTO TABLE capitalized
FIELDS TERMINATED BY ";" 
ENCLOSED BY ""
LINES TERMINATED BY "\n"
IGNORE 1 ROWS
(id, product_reference, @dummy, @dummy, @dummy, @dummy, @dummy, @dummy, @dummy, @dummy);

LOAD DATA INFILE "./capitalized_raw_data.csv"
INTO TABLE capitalized
FIELDS TERMINATED BY ";" 
ENCLOSED BY ""
LINES TERMINATED BY "\n"
IGNORE 1 ROWS
(id, product_reference, @dummy, @dummy, ean13, @dummy, @dummy, @dummy, @dummy, @dummy);