--CREATE DATABASE agency
--USE agency

--/*------------------------------------------------------------
---- Table: timeSlot
--------------------------------------------------------------*/
--CREATE TABLE timeSlot(
--	id         INT  NOT NULL ,
--	timeSlot   VARCHAR (50) NOT NULL  ,
--	CONSTRAINT timeSlot_PK PRIMARY KEY (id)
--);


--/*------------------------------------------------------------
---- Table: typeOfEstate
--------------------------------------------------------------*/
--CREATE TABLE typeOfEstate(
--	id     INT  NOT NULL ,
--	type   VARCHAR (50) NOT NULL  ,
--	CONSTRAINT typeOfEstate_PK PRIMARY KEY (id)
--);


--/*------------------------------------------------------------
---- Table: customers
--------------------------------------------------------------*/
--CREATE TABLE customers(
--	id                INT  NOT NULL ,
--	lastname          VARCHAR (50) NOT NULL ,
--	firstname         VARCHAR (50) NOT NULL ,
--	birthDate         DATETIME  NOT NULL ,
--	mailAdress        VARCHAR (100) NOT NULL ,
--	budget            INT  NOT NULL ,
--	id_typeOfEstate   INT  NOT NULL  ,
--	CONSTRAINT customers_PK PRIMARY KEY (id)

--	,CONSTRAINT customers_typeOfEstate_FK FOREIGN KEY (id_typeOfEstate) REFERENCES typeOfEstate(id)
--);


--/*------------------------------------------------------------
---- Table: realEstate
--------------------------------------------------------------*/
--CREATE TABLE realEstate(
--	id                INT  NOT NULL ,
--	nameEstate        VARCHAR (50) NOT NULL ,
--	postalCode        VARCHAR (50) NOT NULL ,
--	price             INT  NOT NULL ,
--	id_typeOfEstate   INT  NOT NULL  ,
--	CONSTRAINT realEstate_PK PRIMARY KEY (id)

--	,CONSTRAINT realEstate_typeOfEstate_FK FOREIGN KEY (id_typeOfEstate) REFERENCES typeOfEstate(id)
--);


--/*------------------------------------------------------------
---- Table: appointments
--------------------------------------------------------------*/
--CREATE TABLE appointments(
--	id              INT  NOT NULL ,
--	date            DATETIME  NOT NULL ,
--	id_realEstate   INT  NOT NULL ,
--	id_timeSlot     INT  NOT NULL ,
--	id_customers    INT  NOT NULL  ,
--	CONSTRAINT appointments_PK PRIMARY KEY (id)

--	,CONSTRAINT appointments_realEstate_FK FOREIGN KEY (id_realEstate) REFERENCES realEstate(id)
--	,CONSTRAINT appointments_timeSlot0_FK FOREIGN KEY (id_timeSlot) REFERENCES timeSlot(id)
--	,CONSTRAINT appointments_customers1_FK FOREIGN KEY (id_customers) REFERENCES customers(id)
--);

--INSERT INTO [typeOfEstate] ([id], [type])
--VALUES
--(1, 'Maison'),
--(2, 'Appartement'),
--(3, 'Terrain')
--GO

--INSERT INTO [dbo].[realEstate] ([id], [nameEstate], [postalCode], [price], [id_typeOfEstate])
--VALUES
--(1,'Maison A', '60400', 100000, 1),
--(2,'Maison B', '60400', 100000, 1),
--(3,'Maison C', '60400', 100000, 1),
--(4,'Maison D', '60400', 100000, 1),
--(5,'Maison E', '60400', 100000, 1),
--(6,'Maison F', '60400', 150000, 1),
--(7,'Maison G', '60400', 150000, 1),
--(8,'Maison H', '60400', 150000, 1),
--(9,'Maison I', '60400', 150000, 1),
--(10,'Maison de John Snow', '75008', 800000, 1),
--(11,'Appartement A', '60200',80000 , 2),
--(12,'Appartement B', '60200', 80000, 2),
--(13,'Appartement C', '60200', 80000, 2),
--(14,'Appartement D', '60200', 80000, 2),
--(15,'Appartement E', '60200', 80000, 2),
--(16,'Appartement F', '60200', 80000, 2),
--(17,'Appartement G', '60200', 80000, 2),
--(18,'Appartement H', '60200', 80000, 2),
--(19,'Appartement I', '60200', 80000, 2),
--(20,'Appartement J', '60200', 80000, 2),
--(21,'Terrain A', '83500', 50000, 3),
--(22,'Terrain B', '83500', 50000, 3),
--(23,'Terrain C', '83500', 50000, 3),
--(24,'Terrain D', '83500', 50000, 3),
--(25,'Terrain E', '83500', 50000, 3),
--(26,'Terrain F', '83500', 50000, 3),
--(27,'Terrain G', '83500', 50000, 3),
--(28,'Terrain H', '83500', 50000, 3),
--(29,'Terrain I', '83500', 50000, 3),
--(30,'Terrain J', '83500', 50000, 3);


--INSERT INTO [timeSlot] ([id], [timeSlot])
--VALUES
--(1, '9h-10h'),
--(2, '10-11h'),
--(3, '11h-12h'),
--(4, '14h-15h'),
--(5, '15h-16h'),
--(6, '16h-17h')
--GO

--INSERT INTO [customers] ([id], [lastname], [firstname], [birthDate], [mailAdress], [budget], [id_typeOfEstate])
--VALUES
--(1, 'Paulus', 'Jean',  '19790329 00:00:00', 'pjean@hotmail.fr', 150000, 1),
--(2, 'Paula', 'Jeana',  '19790329 00:00:00', 'pjeana@hotmail.fr', 120000, 2),
--(3, 'Paulo', 'Paulu', '19790329 00:00:00', 'ppaulu@hotmail.fr', 500000, 3),
--(4, 'Polik', 'Polizcky', '19790329 00:00:00', 'ppolizicky@hotmail.fr', 200000, 1),
--(5, 'Kolak', 'Makarov', '19790329 00:00:00', 'kmakarov@hotmail.fr', 1000000, 2),
--(6, 'Jul', 'juljuljul', '19790329 00:00:00', 'jul@hotmail.fr', 5000000, 3),
--(7, 'François', 'Saperlu', '19790329 00:00:00', 'fsaperlu@hotmail.fr', 149000, 1),
--(8, 'Ludovic', 'Plio', '19790329 00:00:00', 'lplio@hotmail.fr', 350000, 2),
--(9, 'Chloé', 'Frout', '19790329 00:00:00', 'cfrout@hotmail.fr', 239000, 3),
--(10, 'Augustine', 'Lamotte', '19790329 00:00:00', 'alamotte@hotmail.fr', 100000, 1),
--(11, 'Jean', 'JeanA', '19790329 00:00:00', 'jjeana@hotmail.fr', 345000, 2),
--(12, 'JeanB', 'JeanB', '19790329 00:00:00', 'jjeanb@hotmail.fr', 230000, 3),
--(13, 'JeanC', 'JeanC', '19790329 00:00:00', 'jjeanc@hotmail.fr', 280000, 1),
--(14, 'JeanD', 'JeanD', '19790329 00:00:00', 'jjeand@hotmail.fr', 220000, 2),
--(15, 'JeanE', 'JeanE', '19790329 00:00:00', 'jjeane@hotmail.fr', 210000, 3),
--(16, 'JeanF', 'JeanF', '19790329 00:00:00', 'jjeanf@hotmail.fr', 290000, 1),
--(17, 'JeanG', 'JeanG', '19790329 00:00:00', 'jjeang@hotmail.fr', 200000, 2),
--(18, 'JeanH', 'JeanH', '19790329 00:00:00', 'jjeanh@hotmail.fr', 300000, 3),
--(19, 'JeanI', 'JeanI', '19790329 00:00:00', 'jjeani@hotmail.fr', 310000, 1),
--(20, 'Pose', 'Joshua', '19790329 00:00:00', 'pjoshua@hotmail.fr', 100000, 2)
--GO

--INSERT INTO [appointments] ([id], [date], [id_realEstate], [id_timeSlot], [id_customers])
--VALUES
--(1,'20190529 15:00:00', 1, 5, 1),
--(2,'20190530 15:00:00', 2, 5, 4),
--(3,'20190529 10:00:00', 3, 2, 7),
--(4,'20190529 10:00:00', 30, 2, 3),
--(5,'20190529 10:00:00', 24, 2, 6),
--(6,'20190529 10:00:00', 9, 2, 13),
--(7,'20190529 11:00:00', 13, 3, 2),
--(8,'20190529 11:00:00', 11, 3, 5),
--(9,'20190529 11:00:00', 21, 3, 18),
--(10,'20190529 14:00:00', 6, 4, 10);


--Exo 1

--SELECT [realEstate].[nameEstate] AS [Nom du bien], 
--[realEstate].[postalCode] AS [Code postal],
--[realEstate].[price] AS [Prix du bien],
--[typeOfEstate].[type] AS [Type de bien]
--FROM 
--    [realEstate]
--INNER JOIN 
--    [typeOfEstate]
--ON
--    [typeOfEstate].[id] = [realEstate].[id_typeOfEstate]
--ORDER BY 
--[realEstate].[price];


--Exo 2

--SELECT [appointments].[date] AS [Date du rendez-vous], 
--  [timeSlot].[timeSlot] AS [Créneau horaire], 
--  [realEstate].[nameEstate]AS [Nom du bien présenté],
--  [realEstate].[postalCode] AS [Code postal],
--  [realEstate].[price] AS [Prix du bien],
--  [customers].[lastname] AS [Nom du client],
--  [customers].[firstname] AS [Prénom],
--  [typeOfEstate].[type] AS [Type de bien]
--FROM 
--    [appointments]
--INNER JOIN
--    [timeSlot]
--ON
--    [timeSlot].[id] = [appointments].[id_timeSlot]
--INNER JOIN
--    [realEstate]
--ON
--    [realEstate].[id] = [appointments].[id_realEstate]
--INNER JOIN
--    [customers]
--ON
--    [customers].[id] = [appointments].[id_customers]
--INNER JOIN
--    [typeOfEstate]
--ON
--    [typeOfEstate].[id] = [realEstate].[id_typeOfEstate]
--ORDER BY
--[timeSlot].[timeSlot]; 

--Exo 3
    
--SELECT 
--    [customers].[lastname] AS [Nom du client], 
--    [customers].[firstname] AS [Prénom du client], 
--    [typeOfEstate].[type] AS [Type de bien recherché],
--    [customers].[budget] AS [Budget du client]
--FROM
--    [customers]
--INNER JOIN 
--    [typeOfEstate]
--ON
--    [typeOfEstate].[id] = [customers].[id_typeOfEstate]
--WHERE 
--    [typeOfEstate].[id] = '1'
--GROUP BY
--    [customers].[lastname], 
--    [customers].[firstname], 
--    [customers].[budget], 
--    [typeOfEstate].[type]
--GO
    