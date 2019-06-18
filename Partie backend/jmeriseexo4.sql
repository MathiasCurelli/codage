--CREATE DATABASE medicalCabinet
--USE [medicalCabinet]



--/*------------------------------------------------------------
---- Table: specialities
--------------------------------------------------------------*/
--CREATE TABLE specialities(
--	id             INT IDENTITY (1,1) NOT NULL ,
--	specialities   VARCHAR (50) NOT NULL  ,
--	CONSTRAINT specialities_PK PRIMARY KEY (id)
--);


--/*------------------------------------------------------------
---- Table: doctors
--------------------------------------------------------------*/
--CREATE TABLE doctors(
--	id                INT IDENTITY (1,1) NOT NULL ,
--	lastname          VARCHAR (50) NOT NULL ,
--	firstname         VARCHAR (50) NOT NULL ,
--	mailAdress        VARCHAR (100) NOT NULL ,
--	id_specialities   INT  NOT NULL  ,
--	CONSTRAINT doctors_PK PRIMARY KEY (id)

--	,CONSTRAINT doctors_specialities_FK FOREIGN KEY (id_specialities) REFERENCES specialities(id)
--);


--/*------------------------------------------------------------
---- Table: patients
--------------------------------------------------------------*/
--CREATE TABLE patients(
--	id           INT IDENTITY (1,1) NOT NULL ,
--	lastname     VARCHAR (50) NOT NULL ,
--	firstname    VARCHAR (50) NOT NULL ,
--	birthDate    DATETIME  NOT NULL ,
--	id_doctors   INT  NOT NULL  ,
--	CONSTRAINT patients_PK PRIMARY KEY (id)

--	,CONSTRAINT patients_doctors_FK FOREIGN KEY (id_doctors) REFERENCES doctors(id)
--);


--/*------------------------------------------------------------
---- Table: timeslot
--------------------------------------------------------------*/
--CREATE TABLE timeslot(
--	id         INT IDENTITY (1,1) NOT NULL ,
--	timeSlot   VARCHAR (50) NOT NULL  ,
--	CONSTRAINT timeslot_PK PRIMARY KEY (id)
--);


--/*------------------------------------------------------------
---- Table: appointments
--------------------------------------------------------------*/
--CREATE TABLE appointments(
--	id            INT IDENTITY (1,1) NOT NULL ,
--	date          DATETIME  NOT NULL ,
--	id_timeslot   INT  NOT NULL ,
--	id_patients   INT  NOT NULL ,
--	id_doctors    INT  NOT NULL  ,
--	CONSTRAINT appointments_PK PRIMARY KEY (id)

--	,CONSTRAINT appointments_timeslot_FK FOREIGN KEY (id_timeslot) REFERENCES timeslot(id)
--	,CONSTRAINT appointments_patients0_FK FOREIGN KEY (id_patients) REFERENCES patients(id)
--	,CONSTRAINT appointments_doctors1_FK FOREIGN KEY (id_doctors) REFERENCES doctors(id)
--);

--INSERT INTO [specialities] ([specialities])
--VALUES
--('Généraliste'),
--('Neurologue'),
--('Oncologue');

--INSERT INTO [doctors] ([lastname], [firstname], [mailAdress], [id_specialities])
--VALUES
--('Jacques', 'Jacquy', 'jjacquy@hotmail.fr', 1),
--('Starck', 'Tony', 'stony@hotmail.fr', 2),
--('Monard', 'Clem', 'mclem@hotmail.fr', 3),
--('Pose', 'Joshua', 'pjoshua@hotmail.fr', 1),
--('Curelli', 'Mathias', 'cmathias@hotmail.fr', 1);

--INSERT INTO [patients] ([lastname], [firstname], [birthDate], [id_doctors])
--VALUES
--('LouisA', 'JeanA', '19790329 00:00:00', 1),
--('LouisZ', 'JeanZ', '19790329 00:00:00', 2),
--('LouisE', 'JeanE', '19790329 00:00:00', 3),
--('LouisR', 'JeanR', '19790329 00:00:00', 4),
--('LouisT', 'JeanT', '19790329 00:00:00', 5),
--('LouisY', 'JeanY', '19790329 00:00:00', 1),
--('LouisU', 'JeanU', '19790329 00:00:00', 1),
--('LouisI', 'JeanI', '19790329 00:00:00', 1),
--('LouisO', 'JeanO', '19790329 00:00:00', 3),
--('LouisP', 'JeanP', '19790329 00:00:00', 3),
--('LouisQ', 'JeanQ', '19790329 00:00:00', 2),
--('LouisS', 'JeanS', '19790329 00:00:00', 1),
--('LouisD', 'JeanD', '19790329 00:00:00', 4),
--('LouisF', 'JeanF', '19790329 00:00:00', 4),
--('LouisG', 'JeanG', '19790329 00:00:00', 5),
--('LouisH', 'JeanH', '19790329 00:00:00', 5),
--('LouisJ', 'JeanJ', '19790329 00:00:00', 1),
--('LouisK', 'JeanK', '19790329 00:00:00', 2),
--('LouisL', 'JeanL', '19790329 00:00:00', 2),
--('LouisM', 'JeanM', '19790329 00:00:00', 3);

--INSERT INTO [timeslot] ([timeSlot])
--VALUES
--('8h30-9h30'),
--('9h30-10h00'),
--('10h30-11h00'),
--('11h00-11h30'),
--('11h30-12h00'),
--('14h00-14h30'),
--('14h30-15h00'),
--('15h30-16h00')
--GO


--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20190210 06:42:15', 2, 18, 4);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20190120 09:46:10', 7, 19, 3);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20190512 12:49:08', 5, 12, 2);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20180812 14:05:18', 6, 3, 5);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20190314 16:34:05', 6, 13, 5);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20181124 15:13:40', 8, 13, 3);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20190118 11:59:13', 5, 10, 2);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20190829 02:47:45', 3, 17, 4);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20190218 12:37:12', 4, 9, 3);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20180826 11:03:42', 4, 10, 3);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20180627 23:45:41', 7, 5, 3);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20181103 03:49:03', 1, 7, 4);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20181031 09:29:08', 5, 2, 5);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20190323 05:24:13', 5, 19, 3);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20190404 09:09:34', 1, 6, 5);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20180917 01:03:57', 3, 14, 5);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20190701 13:48:24', 8, 18, 3);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20181210 22:58:47', 2, 4, 1);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20180515 23:59:45', 4, 4, 5);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20181023 07:05:48', 3, 1, 5);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20180805 18:52:56', 3, 18, 5);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20190128 19:13:24', 1, 13, 1);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20190505 04:40:41', 5, 12, 4);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20181229 16:05:18', 4, 15, 3);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20180530 01:52:58', 4, 16, 3);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20180911 08:55:30', 2, 15, 4);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20190719 11:21:50', 8, 10, 1);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20190123 09:40:17', 3, 3, 5);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20181111 11:03:57', 3, 19, 2);
--insert into [appointments] (date, id_timeSlot, id_patients, id_doctors) values ('20190518 10:18:34', 3, 18, 3);

--Exo 1

--SELECT 
--    [appointments].[date] AS [Date du rendez-vous], 
--    [timeslot].[timeSlot] AS [Créneau],
--    [patients].[lastname] AS [Nom du patient],
--    [patients].[firstname] AS [Prénom du patient],
--    [doctors].[lastname] AS [Nom du docteur],
--    [doctors].[firstname] AS [Prénom du docteur],
--    [specialities].[specialities] AS [Spécialité du docteur]
--FROM
--    [appointments]
--INNER JOIN
--    [patients]
--ON
--    [patients].[id] = [appointments].[id_patients]
--INNER JOIN
--    [doctors]
--ON
--    [doctors].[id] = [appointments].[id_doctors]
--INNER JOIN
--    [specialities]
--ON 
--    [specialities].[id] = [doctors].[id_specialities]
--INNER JOIN
--    [timeslot]
--ON
--    [timeSlot].[id] = [appointments].[id_timeslot]
--GROUP BY
--    [appointments].[date], 
--    [timeslot].[timeSlot],
--    [patients].[lastname],
--    [patients].[firstname],
--    [doctors].[lastname],
--    [doctors].[firstname],
--    [specialities].[specialities]
--GO    

--Exo 2

--SELECT
--    [doctors].[lastname] AS [Nom du docteur],
--    [doctors].[firstname] AS [Prénom du docteur],
--    [appointments].[date] AS [Date du rendez-vous],
--    [timeslot].[timeSlot] AS [Créneau du rendez-vous],
--    [patients].[lastname] AS [Nom du patient],
--    [patients].[firstname] AS [Prénom du patient]
--FROM
--    [appointments]
--INNER JOIN
--    [doctors]
--ON
--    [doctors].[id] = [appointments].[id_doctors]
--INNER JOIN
--    [timeslot]
--ON
--    [timeslot].[id] = [appointments].[id_timeslot]
--INNER JOIN
--    [patients]
--ON
--    [patients].[id] = [appointments].[id_patients]
--WHERE 
--    [doctors].[id] = 1
--GO


--Exo 3

SELECT 
	[dbo].[patients].[lastname] AS [Nom du patient],
	[dbo].[patients].[firstname] AS [Prénom du patient],
	[dbo].[doctors].[lastname] AS [Nom du docteur],
	[dbo].[doctors].[firstname] AS [Prénom du docteur],
	[dbo].[specialities].[specialities] AS [Spécialité],
	[dbo].[appointments].[date] AS [Rendez-vous],
	[dbo].[timeslot].[timeSlot] AS [Créneau horaire]
FROM
    [dbo].[patients]
INNER JOIN
    [dbo].[doctors]
	ON [dbo].[doctors].[id] = [dbo].[patients].[id_doctors]
INNER JOIN
    [dbo].[specialities]
	ON [dbo].[specialities].[id] = [dbo].[doctors].[id_specialities]
INNER JOIN
    [dbo].[appointments]
	ON [dbo].[appointments].[id_patients] = [dbo].[patients].[id]
INNER JOIN
    [dbo].[timeslot]
	ON [dbo].[timeslot].[id] = [dbo].[appointments].[id_timeslot]
WHERE
    [dbo].[patients].[id] = 2
GO


