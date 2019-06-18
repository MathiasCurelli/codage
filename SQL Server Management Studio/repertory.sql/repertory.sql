--CREATE DATABASE repertory
--/*------------------------------------------------------------
-- Table: users
------------------------------------------------------------*/
--CREATE TABLE users(
--	idUser      INT IDENTITY (1,1) NOT NULL ,
--	lastname    VARCHAR (50) NOT NULL ,
--	firstname   VARCHAR (50) NOT NULL ,
--	username    VARCHAR (50) NOT NULL ,
--	mail        VARCHAR (100) NOT NULL ,
--	password    VARCHAR (225) NOT NULL  ,
--	CONSTRAINT users_PK PRIMARY KEY (idUser)
--);


--/*------------------------------------------------------------
---- Table: contact
--------------------------------------------------------------*/
--CREATE TABLE contact(
--	idContact     INT IDENTITY (1,1) NOT NULL ,
--	lastname      VARCHAR (50) NOT NULL ,
--	firstname     VARCHAR (50) NOT NULL ,
--	mail          VARCHAR (100) NOT NULL ,
--	phoneNumber   VARCHAR (255) NOT NULL ,
--	address       VARCHAR (255) NOT NULL ,
--	photo         VARCHAR (255) NOT NULL ,
--	idUser        INT  NOT NULL  ,
--	CONSTRAINT contact_PK PRIMARY KEY (idContact)

--	,CONSTRAINT contact_users_FK FOREIGN KEY (idUser) REFERENCES users(idUser)
--);



