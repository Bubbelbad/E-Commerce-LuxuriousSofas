CREATE DATABASE webshopdb;
USE webshopdb; 
CREATE USER webshopadmin IDENTIFIED BY "admin";

GRANT ALL
ON webshopdb.*
TO webshopadmin; 