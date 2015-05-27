-- -----------------------------------------------------
-- DESCRIPTION : (erase and) create pixlogic_db and 
-- tables
-- AUTHOR : Arnaud Frechet <frechet@intechinfo.fr> 
-- LAST EDIT : 27 May, 2015
-- -----------------------------------------------------
DROP DATABASE pixlogic_db;
CREATE DATABASE pixlogic_db;
ALTER DATABASE pixlogic_db CHARACTER SET utf8 COLLATE utf8_general_ci;
USE pixlogic_db;

-- -----------------------------------------------------
-- Create the tables
-- -----------------------------------------------------
CREATE TABLE accounts_main_categories (
	id				INT				UNSIGNED 		AUTO_INCREMENT		NOT NULL,
	name			TINYTEXT		NOT NULL,
	description		TEXT			DEFAULT NULL,
	PRIMARY KEY (id)
)ENGINE = InnoDB;
CREATE TABLE accounts_sub_categories (
	id				INT				UNSIGNED 		AUTO_INCREMENT		NOT NULL,
	name			TINYTEXT		NOT NULL,
	description		TEXT			DEFAULT NULL,
	main_category	INT				UNSIGNED		NOT NULL,
	PRIMARY KEY (id),
	INDEX accounts_main_categories_idx (main_category ASC),
	CONSTRAINT accounts_main_categories_cstrt
		FOREIGN KEY (main_category)
		REFERENCES accounts_main_categories (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)ENGINE = InnoDB;
CREATE TABLE accounts (
	id				INT				UNSIGNED 		AUTO_INCREMENT		NOT NULL,
	first_name		TINYTEXT		NOT NULL,
	last_name		TINYTEXT		NOT NULL,
	email			VARCHAR(100)	UNIQUE 			NOT NULL,
	password		TINYTEXT		NOT NULL,
	active			BOOLEAN			DEFAULT TRUE	NOT NULL,
	wallet			INT				DEFAULT 0		NOT NULL,
	sub_category	INT				UNSIGNED		NOT NULL,
	PRIMARY KEY (id),
	INDEX accounts_sub_categories_idx (sub_category ASC),
	CONSTRAINT accounts_sub_categories_cstrt
		FOREIGN KEY (sub_category)
		REFERENCES accounts_sub_categories (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)ENGINE = InnoDB;
-- ^ Users' accounts data ^
CREATE TABLE companies (
	id				INT				UNSIGNED 		AUTO_INCREMENT		NOT NULL,
	name			TINYTEXT		NOT NULL,
	phone			INT(20)			UNSIGNED		DEFAULT NULL,
	adress			TINYTEXT		DEFAULT NULL,
	PRIMARY KEY (id)
)ENGINE = InnoDB;
CREATE TABLE contacts (
	id				INT				UNSIGNED 		AUTO_INCREMENT		NOT NULL,
	first_name		TINYTEXT		NOT NULL,
	last_name		TINYTEXT		NOT NULL,
	phone			INT(20)			UNSIGNED		DEFAULT NULL,
	email			TINYTEXT		DEFAULT NULL,
	company			INT				UNSIGNED		NOT NULL,
	PRIMARY	KEY (id),
	INDEX contacts_companies_idx (company ASC),
	CONSTRAINT contacts_companies_cstrt
		FOREIGN KEY (company)
		REFERENCES companies (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)ENGINE = InnoDB;
CREATE TABLE invoices (
	id							INT				UNSIGNED 		AUTO_INCREMENT		NOT NULL,
	purchase_date				DATE			NOT NULL,
	purchase_cost				DECIMAL(8, 2)	NOT NULL,
	annual_depreciation_rate	INT				NOT NULL,
	phase_number				INT(10)			UNSIGNED		ZEROFILL			NOT NULL,
	description					TEXT			DEFAULT NULL,
	company						INT 			UNSIGNED		NOT NULL,
	PRIMARY KEY (id),
	UNIQUE INDEX phase_number_UNIQUE (phase_number ASC),
	INDEX invoices_companies_idx (company ASC),
	CONSTRAINT invoices_companies_cstrt
		FOREIGN KEY (company)
		REFERENCES companies (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)ENGINE = InnoDB;
-- ^ Accounting data ^
CREATE TABLE brands (
	id				INT				UNSIGNED 		AUTO_INCREMENT		NOT NULL,
	name			TINYTEXT		NOT NULL,
	description		TEXT			DEFAULT NULL,
	PRIMARY KEY (id)
)ENGINE = InnoDB;
CREATE TABLE states (
	id				INT				UNSIGNED 		AUTO_INCREMENT		NOT NULL,
	name			TINYTEXT		NOT NULL,
	description		TEXT			DEFAULT NULL,
	reservable		BOOLEAN			DEFAULT TRUE	NOT NULL,
	PRIMARY KEY (id)
)ENGINE = InnoDB;
-- ^ Brands and states data ^
CREATE TABLE capitalized_main_categories (
	id				INT				UNSIGNED 		AUTO_INCREMENT		NOT NULL,
	name			TINYTEXT		NOT NULL,
	description		TEXT			DEFAULT NULL,
	PRIMARY KEY (id)
)ENGINE = InnoDB;
CREATE TABLE capitalized_sub_categories (
	id				INT				UNSIGNED 		AUTO_INCREMENT		NOT NULL,
	name			TINYTEXT		NOT NULL,
	description		TEXT			DEFAULT NULL,
	main_category	INT				UNSIGNED		NOT NULL,
	PRIMARY KEY (id),
	INDEX capitalized_main_categories_idx (main_category ASC),
	CONSTRAINT capitalized_main_categories_cstrt
		FOREIGN KEY (main_category)
		REFERENCES capitalized_main_categories (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)ENGINE = InnoDB;
CREATE TABLE capitalized (
	id					INT				UNSIGNED 		AUTO_INCREMENT		NOT NULL,
	product_reference	TINYTEXT		NOT NULL,
	description			TEXT			DEFAULT NULL,
	picture_path		TINYTEXT		DEFAULT NULL,
	ean13				INT(13)			UNSIGNED		DEFAULT NULL,
	brand				INT				UNSIGNED		NOT NULL,
	reservation_cost	INT				UNSIGNED		DEFAULT 1,
	sub_category		INT				UNSIGNED		NOT NULL,
	invoice				INT				UNSIGNED		NOT NULL,
	current_state		INT				UNSIGNED		NOT NULL,
	PRIMARY KEY (id),
	UNIQUE INDEX code_UNIQUE (ean13 ASC),
	INDEX capitalized_brand_idx(brand ASC),
	INDEX capitalized_sub_categories_idx (sub_category ASC),
	INDEX capitalized_invoices_idx (invoice ASC),
	INDEX capitalized_current_states_idx (current_state ASC),
	CONSTRAINT capitalized_brand_cstrt
		FOREIGN KEY (brand)
		REFERENCES brands (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	CONSTRAINT capitalized_sub_categories_cstrt
		FOREIGN KEY (sub_category)
		REFERENCES capitalized_sub_categories (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	CONSTRAINT capitalized_invoices_cstrt
		FOREIGN KEY (invoice)
		REFERENCES invoices (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	CONSTRAINT capitalized_current_states_cstrt
		FOREIGN KEY (current_state)
		REFERENCES states (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)ENGINE = InnoDB;
CREATE TABLE repairs (
	id				INT				UNSIGNED 		AUTO_INCREMENT		NOT NULL,
	start_date		DATE			NOT NULL,
	return_date		DATE			DEFAULT NULL,
	item			INT				UNSIGNED		NOT NULL,
	repairer		INT				UNSIGNED		NOT NULL,
	PRIMARY KEY (id),
	INDEX repairs_companies_idx (repairer ASC),
	INDEX repairs_item_idx (item ASC),
	CONSTRAINT repairs_companies_cstrt
		FOREIGN KEY (repairer)
		REFERENCES companies (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	CONSTRAINT repairs_item_cstrt
		FOREIGN KEY (item)
		REFERENCES capitalized (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)ENGINE = InnoDB;
-- ^ Capitalized data ^
CREATE TABLE consumables_main_categories (
	id				INT				UNSIGNED 		AUTO_INCREMENT		NOT NULL,
	name			TINYTEXT		NOT NULL,
	description		TEXT			DEFAULT NULL,
	PRIMARY KEY (id)
)ENGINE = InnoDB;
CREATE TABLE consumables_sub_categories (
	id				INT				UNSIGNED 		AUTO_INCREMENT		NOT NULL,
	name			TINYTEXT		NOT NULL,
	description		TEXT			DEFAULT NULL,
	main_category	INT				UNSIGNED		NOT NULL,
	PRIMARY KEY (id),
	INDEX consumables_main_categories_idx (main_category ASC),
	CONSTRAINT consumable_main_categories_cstrt
		FOREIGN KEY (main_category)
		REFERENCES consumables_main_categories (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)ENGINE = InnoDB;
CREATE TABLE consumables (
	id					INT			UNSIGNED 		AUTO_INCREMENT		NOT NULL,
	product_reference	TINYTEXT		DEFAULT NULL,
	description			TEXT			DEFAULT NULL,
	brand				INT				UNSIGNED		NOT NULL,
	reservation_cost	INT				UNSIGNED		DEFAULT 1,
	sub_category		INT				UNSIGNED		NOT NULL,
	invoice				INT				UNSIGNED		NOT NULL,
	current_state		INT				UNSIGNED		NOT NULL,
	PRIMARY KEY (id),
	INDEX consumables_brands_idx (brand ASC),
	INDEX consumables_sub_categories_idx (sub_category ASC),
	INDEX consumables_invoices_idx (invoice ASC),
	INDEX consumables_current_states_idx (current_state ASC),
	CONSTRAINT consumables_brands_cstrt
		FOREIGN KEY (brand)
		REFERENCES brands (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	CONSTRAINT consumables_sub_categories_cstrt
		FOREIGN KEY (sub_category)
		REFERENCES consumables_sub_categories (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	CONSTRAINT consumables_invoices_cstrt
		FOREIGN KEY (invoice)
		REFERENCES invoices (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	CONSTRAINT consumables_current_states_cstrt
		FOREIGN KEY (current_state)
		REFERENCES states (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)ENGINE = InnoDB;
-- ^ Consumables data ^
CREATE TABLE reservations (
	id						INT				UNSIGNED 		AUTO_INCREMENT		NOT NULL,
	start_date				DATETIME		NOT NULL,
	estimated_return_date	DATETIME		NOT NULL,
	confirmed				BOOLEAN			DEFAULT FALSE	NOT NULL,
	taken_out				BOOLEAN			DEFAULT FALSE	NOT NULL,
	account					INT				UNSIGNED		NOT NULL,
	PRIMARY KEY (id),
	INDEX reservations_accounts_idx (account ASC),
	CONSTRAINT reservations_accounts_cstrt
		FOREIGN KEY (account)
		REFERENCES accounts (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)ENGINE = InnoDB;
CREATE TABLE capitalized_reserved (
	id					INT				UNSIGNED 		AUTO_INCREMENT		NOT NULL,
	real_return_date	DATETIME		DEFAULT NULL,
	reservation			INT				UNSIGNED		NOT NULL,
	item				INT				UNSIGNED		NOT NULL,
	initial_state		INT				UNSIGNED		NOT NULL,
	return_state		INT				UNSIGNED		DEFAULT NULL,
	PRIMARY KEY (id),
	INDEX capitalized_reserved_reservations_idx (reservation ASC),
	INDEX capitalized_reserved_items_idx (item ASC),
	INDEX capitalized_reserved_initial_states_idx (initial_state ASC),
	INDEX capitalized_reserved_return_states_idx (return_state ASC),
	CONSTRAINT capitalized_reserved_reservations_cstrt
		FOREIGN KEY (reservation)
		REFERENCES reservations (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	CONSTRAINT capitalized_reserved_items_cstrt
		FOREIGN KEY (item)
		REFERENCES capitalized (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	CONSTRAINT capitalized_reserved_initial_states_cstrt
		FOREIGN KEY (initial_state)
		REFERENCES states (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	CONSTRAINT capitalized_reserved_return_states_cstrt
		FOREIGN KEY (return_state)
		REFERENCES states (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)ENGINE = InnoDB;
CREATE TABLE consumables_reserved (
	id					INT				UNSIGNED 		AUTO_INCREMENT		NOT NULL,
	real_return_date	DATETIME		DEFAULT NULL,
	reservation			INT				UNSIGNED		NOT NULL,
	item				INT				UNSIGNED		NOT NULL,
	initial_state		INT				UNSIGNED		NOT NULL,
	return_state		INT				UNSIGNED		DEFAULT NULL,
	PRIMARY KEY (id),
	INDEX consumables_reserved_reservations_idx (reservation ASC),
	INDEX consumables_reserved_items_idx (item ASC),
	INDEX consumables_reserved_initial_states_idx (initial_state ASC),
	INDEX consumables_reserved_return_states_idx (return_state ASC),
	CONSTRAINT consumables_reserved_reservations_cstrt
		FOREIGN KEY (reservation)
		REFERENCES reservations (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	CONSTRAINT consumables_reserved_items_cstrt
		FOREIGN KEY (item)
		REFERENCES consumables (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	CONSTRAINT consumables_reserved_initial_states_cstrt
		FOREIGN KEY (initial_state)
		REFERENCES states (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	CONSTRAINT consumables_reserved_return_states_cstrt
		FOREIGN KEY (return_state)
		REFERENCES states (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)ENGINE = InnoDB;
-- ^ Reservations data ^
CREATE TABLE packs (
	id				INT				UNSIGNED 		AUTO_INCREMENT		NOT NULL,
	name			TINYTEXT		NOT NULL,
	description		TEXT			DEFAULT NULL,
	PRIMARY KEY (id)
)ENGINE = InnoDB;
CREATE TABLE capitalized_items_in_packs (
	id				INT				UNSIGNED 		AUTO_INCREMENT		NOT NULL,
	item			INT				UNSIGNED		NOT NULL,
	pack			INT				UNSIGNED		NOT NULL,
	PRIMARY KEY (id),
	INDEX capitalized_items_in_packs_items_idx (item ASC),
	INDEX capitalized_items_in_packs_packs_idx (pack ASC),
	CONSTRAINT capitalized_items_in_packs_items_cstrt
		FOREIGN KEY (item)
		REFERENCES capitalized (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	CONSTRAINT capitalized_items_in_packs_packs_cstrt
		FOREIGN KEY (pack)
		REFERENCES packs (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)ENGINE = InnoDB;
CREATE TABLE capitalized_categories_in_packs (
	id				INT				UNSIGNED 		AUTO_INCREMENT		NOT NULL,
	category		INT				UNSIGNED		NOT NULL,
	pack			INT				UNSIGNED		NOT NULL,
	PRIMARY KEY (id),
	INDEX capitalized_categories_in_packs_categories_idx (category ASC),
	INDEX capitalized_categories_in_packs_packs_idx (pack ASC),
	CONSTRAINT capitalized_categories_in_packs_categories_cstrt FOREIGN KEY (category) REFERENCES capitalized_sub_categories (id) ON DELETE NO ACTION ON UPDATE NO ACTION,
	CONSTRAINT capitalized_categories_in_packs_packs_cstrt FOREIGN KEY (pack) REFERENCES packs (id) ON DELETE NO ACTION ON UPDATE NO ACTION
)ENGINE = InnoDB;
CREATE TABLE consumables_items_in_packs (
	id				INT				UNSIGNED 		AUTO_INCREMENT		NOT NULL,
	item			INT				UNSIGNED		NOT NULL,
	pack			INT				UNSIGNED		NOT NULL,
	PRIMARY KEY (id),
	INDEX consumables_items_in_packs_items_idx (item ASC),
	INDEX consumables_items_in_packs_packs_idx (pack ASC),
	CONSTRAINT consumables_items_in_packs_items_cstrt
		FOREIGN KEY (item)
		REFERENCES consumables (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	CONSTRAINT consumables_items_in_packs_packs_cstrt
		FOREIGN KEY (pack)
		REFERENCES packs (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)ENGINE = InnoDB;
CREATE TABLE consumables_categories_in_packs (
	id				INT				UNSIGNED 		AUTO_INCREMENT		NOT NULL,
	category		INT				UNSIGNED		NOT NULL,
	pack			INT				UNSIGNED		NOT NULL,
	PRIMARY KEY (id),
	INDEX consumables_categories_in_packs_categories_idx (category ASC),
	INDEX consumables_categories_in_packs_packs_idx (pack ASC),
	CONSTRAINT consumables_categories_in_packs_categories_cstrt
		FOREIGN KEY (category)
		REFERENCES consumables_sub_categories (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	CONSTRAINT consumables_categories_in_packs_packs_cstrt
		FOREIGN KEY (pack)
		REFERENCES packs (id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)ENGINE = InnoDB;
-- ^ Packs data ^
