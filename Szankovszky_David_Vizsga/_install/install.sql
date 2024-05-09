CREATE SCHEMA `exam_cars` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci ;

use exam_cars;

CREATE TABLE `exam_cars`.`car` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `licence_plate_number` VARCHAR(15) NOT NULL,
  `net_price` INT NOT NULL,
  `manufacturer` VARCHAR(50) NOT NULL,
  `model` VARCHAR(50) NULL,
  `category_id` INT NOT NULL,
  `km_amount` INT NULL,
  `status` TINYINT NULL,
  PRIMARY KEY (`id`));
  
ALTER TABLE `exam_cars`.`car` 
RENAME TO  `exam_cars`.`cars` ;

ALTER TABLE `exam_cars`.`cars` 
CHANGE COLUMN `status` `status_id` TINYINT(4) NOT NULL ;

ALTER TABLE `exam_cars`.`cars` 
CHANGE COLUMN `status_id` `status_id` INT NOT NULL ;
  
CREATE TABLE `exam_cars`.`car_category` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `category_name` VARCHAR(15) NOT NULL,
  PRIMARY KEY (`id`));
  
CREATE TABLE `exam_cars`.`car_status` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`id`));
  
ALTER TABLE `exam_cars`.`car_status` 
ADD COLUMN `value` INT NOT NULL AFTER `name`;
  
INSERT INTO `exam_cars`.`car_category` (`category_name`) VALUES ('Személyautó');
INSERT INTO `exam_cars`.`car_category` (`category_name`) VALUES ('Teherautó');
INSERT INTO `exam_cars`.`car_category` (`category_name`) VALUES ('Egyéb');

INSERT INTO `exam_cars`.`cars` (`licence_plate_number`, `net_price`, `manufacturer`, `model`, `category_id`, `km_amount`, `status_id`) VALUES ('KRC667', '1000000', 'SKODA', 'SUPERB', '1', '217000', '1');
INSERT INTO `exam_cars`.`cars` (`licence_plate_number`, `net_price`, `manufacturer`, `model`, `category_id`, `km_amount`, `status_id`) VALUES ('GDR842', '350000', 'SUZUKI', 'SWIFT', '1', '315325', '0');
INSERT INTO `exam_cars`.`cars` (`licence_plate_number`, `net_price`, `manufacturer`, `category_id`, `km_amount`, `status_id`) VALUES ('AKRE1517', '25000000', 'MAN', '2', '1200', '1');
UPDATE `exam_cars`.`cars` SET `status_id` = '2' WHERE (`id` = '2');

INSERT INTO `exam_cars`.`car_status` (`name`, `value`) VALUES ('Aktív', '1');
INSERT INTO `exam_cars`.`car_status` (`name`, `value`) VALUES ('Inaktív', '0');
