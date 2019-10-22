DROP DATABASE IF EXISTS `library_registrar_db`;
CREATE DATABASE `library_registrar_db`;
USE `library_registrar_db`;


CREATE TABLE `items`;
USE `items`(
    `ItemId` int(11) NOT NULL AUTO_INCREMENT,
    `description` VARCHAR(255) DEFAULT NULL, 
     PRIMARY KEY (`ItemId`)
)

CREATE TABLE `categories`;
USE `categories`(
    `CategoryId` int(11) NOT NULL AUTO_INCREMENT, 
    `name` VARCHAR(255) DEFAULT NULL,
    FOREIGN KEY (`CategoryId`)
)

CREATE TABLE `categoriesItems`;
USE `categoriesItems`(
    `CategoryItemId` int(11) NOT NULL AUTO_INCREMENT,
    `ItemId` int(11) DEFAULT `0`,
    `CategoryId` int(11) DEFAULT `0`,
    PRIMARY KEY(`CategoryItemId`),
    FOREIGN KEY (`CategoryId`, `ItemId`) REFERENCES ( `clients.CategoryId`, `items.ItemId`)
)


