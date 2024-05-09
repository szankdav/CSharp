CREATE SCHEMA `exam_demo_product` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci ;

use exam_demo_product;

CREATE TABLE `exam_demo_product`.`product` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(150) NOT NULL,
  `net_price` INT NOT NULL,
  `vat_id` INT NOT NULL,
  `manufacturer` VARCHAR(150) NOT NULL,
  `model` VARCHAR(150) NULL,
  `category_id` INT NOT NULL,
  `created_at` TIMESTAMP NULL,
  PRIMARY KEY (`id`));
  
  CREATE TABLE `exam_demo_product`.`vat_category` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(100) NOT NULL,
  `value` INT NOT NULL,
  PRIMARY KEY (`id`));


CREATE TABLE `exam_demo_product`.`product_category` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`id`));

INSERT INTO `exam_demo_product`.`vat_category` (`name`, `value`) VALUES ('adómentes 0%', '0');
INSERT INTO `exam_demo_product`.`vat_category` (`name`, `value`) VALUES ('12%', '12');
INSERT INTO `exam_demo_product`.`vat_category` (`name`, `value`) VALUES ('27', '27');

INSERT INTO `exam_demo_product`.`product_category` (`name`) VALUES ('asztali PC');
INSERT INTO `exam_demo_product`.`product_category` (`name`) VALUES ('notebook');
INSERT INTO `exam_demo_product`.`product_category` (`name`) VALUES ('periféria');
INSERT INTO `exam_demo_product`.`product_category` (`name`) VALUES ('egyéb');

INSERT INTO `exam_demo_product`.`product` (`name`, `net_price`, `vat_id`, `manufacturer`, `model`, `category_id`) VALUES ('Dell PC F-353', '190000', '3', 'Dell', 'F-353-4444', '1');
INSERT INTO `exam_demo_product`.`product` (`name`, `net_price`, `vat_id`, `manufacturer`, `model`, `category_id`) VALUES ('Asus notebook', '300000', '1', 'Asus', 'G-324-341', '2');


