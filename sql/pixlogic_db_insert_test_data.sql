-- -----------------------------------------------------
-- DESCRIPTION : insert data in pixlogic_db
-- AUTHOR : Arnaud Frechet <frechet@intechinfo.fr> 
-- LAST EDIT : 27 May, 2015
-- -----------------------------------------------------
USE pixlogic_db;

-- -----------------------------------------------------
-- Insert the data
-- -----------------------------------------------------
INSERT INTO accounts_main_categories (id, name, description)
VALUES (1, "Étudiant", "Étudiant en système de l'information");
INSERT INTO accounts_sub_categories (id, name, description, main_category)
VALUES (1, "ITI13S", "Promotion de septembre 2013", 1);
INSERT INTO accounts (id, first_name, last_name, email, password, sub_category)
VALUES (1, "Loïc", "Donne", "donne@intechinfo.fr", "0000", 1), (2, "Arnaud", "Frechet", "frechet@intechinfo.fr", "0000", 1), (3, "Benoit", "Humblot", "humblot@intechinfo.fr", "0000", 1), (4, "Florian", "Cuchot", "cuchot@intechinfo.fr", "0000", 1);
-- ^ Users' accounts data ^
INSERT INTO companies (id, name)
VALUES (1, "www.MX2.fr"), (2, "www.priceminister.com"), (3, "www.ebay.fr"), (4, "www.photo-cine-reparation.com");
INSERT INTO invoices (id, purchase_date, purchase_cost, annual_depreciation_rate, phase_number, company)
VALUES (1, "2015-05-19", 6.30, 100, 0, 1), (2, "2015-05-19", 100, 20, 1, 2), (3, "2015-05-20", 95, 20, 2, 3);
-- ^ Accounting data ^
INSERT INTO brands (id, name)
VALUES (1, "Canon"), (2, "ADOX");
INSERT INTO states (id, name, reservable)
VALUES (1, "Neuf", true), (2, "Occasion", true), (3, "Cassé(e)", false);
-- ^ Brands and states data ^
INSERT INTO capitalized_main_categories (id, name)
VALUES (1, "Appareil photo"), (2, "Flash");
INSERT INTO capitalized_sub_categories (id, name, main_category)
VALUES (1, "Appareil photo reflex", 1), (2, "Flash Canon", 2);
INSERT INTO capitalized (id, product_reference, reservation_cost, brand, sub_category, invoice, current_state)
VALUES (1, "AE1 Program", 100, 1, 1, 2, 2), (2, "AE1 Program", 100, 1, 1, 3, 1), (3, "Flash speedlite 166A", 10, 1, 2, 3, 3);
INSERT INTO repairs (id, start_date, item, repairer)
VALUES (1, "2015-05-25", 3, 4);
-- ^ Capitalized data ^
INSERT INTO consumables_main_categories (id, name)
VALUES (1, "Pellicule");
INSERT INTO consumables_sub_categories (id, name, main_category)
VALUES (1, "Pellicule photo argentique", 1);
INSERT INTO consumables (id, product_reference, description, reservation_cost, brand, sub_category, invoice, current_state)
VALUES (1, "CMS 20 II 36poses", "Film négatif pellicule photo n&b ADOX Silvermax 100iso 36poses 24x36 135\nFilm basé sur l'émulsion de la AGFA APX 100 mais plus riche en argent.\n\nExtrait de l'article rédigé par Philippe Bachelier dans le magazine Réponses Photo No 248 Page 114, Novembre 2012\n\"La particularité de ce film est de convenir aussi bien pour réaliser des négatifs que des positifs. Son émulsion posséde un taux d'argent élevé, d'où son nom.\nAdox annonce une capacité à différencier 14IL avec un révélateur liquide concentré dédié, lui aussi nommé Silvermax.\nSa couche anti-halo, placée entre le support (du triacétate) et l'émulsion, est censée favoriser une netteté d'image optimale.\nLa granulation serait aussi fine que sur les films utilisant des grains tabulaires.\"\n\nTemps de développement dans de l'ADOX Silvermax : 11min/ 20°C", 10, 2, 1, 1, 1);
-- ^ Consumables data ^
INSERT INTO reservations (id, start_date, estimated_return_date, account)
VALUES (1, "2015-05-20", "2015-05-21", 1);
INSERT INTO capitalized_reserved (reservation, item, initial_state)
VALUES (1, 1, 1);
INSERT INTO consumables_reserved (reservation, item, initial_state)
VALUES (1, 1, 1);
-- ^ Reservations data ^
INSERT INTO packs (id, name)
VALUES (1, "Pack Argentique Express"), (2, "Canon AE1 Program & ADOX CMS 20 II 36poses");
INSERT INTO capitalized_categories_in_packs (category, pack)
VALUES (1, 1);
INSERT INTO consumables_categories_in_packs (category, pack)
VALUES (1, 1);
INSERT INTO capitalized_items_in_packs (item, pack)
VALUES (1, 2);
INSERT INTO consumables_items_in_packs (item, pack)
VALUES (1, 2);
-- ^ Packs data ^
