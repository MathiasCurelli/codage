--CREATE DATABASE library
--USE library
--GO

/*------------------------------------------------------------
*        Script SQLSERVER 
------------------------------------------------------------*/


/*------------------------------------------------------------
-- Table: typeOfBooks
------------------------------------------------------------*/
--CREATE TABLE typeOfBooks(
--	id     INT IDENTITY (1,1) NOT NULL ,
--	type   VARCHAR (50) NOT NULL  ,
--	CONSTRAINT typeOfBooks_PK PRIMARY KEY (id)
--);


--/*------------------------------------------------------------
---- Table: customers
--------------------------------------------------------------*/
--CREATE TABLE customers(
--	id               INT IDENTITY (1,1) NOT NULL ,
--	lastName         VARCHAR (50) NOT NULL ,
--	firstName        VARCHAR (50) NOT NULL ,
--	birthdayDate     DATETIME  NOT NULL ,
--	mailAdress       VARCHAR (100) NOT NULL ,
--	id_typeOfBooks   INT  NOT NULL  ,
--	CONSTRAINT customers_PK PRIMARY KEY (id)

--	,CONSTRAINT customers_typeOfBooks_FK FOREIGN KEY (id_typeOfBooks) REFERENCES typeOfBooks(id)
--);


--/*------------------------------------------------------------
---- Table: authors
--------------------------------------------------------------*/
--CREATE TABLE authors(
--	id                INT IDENTITY (1,1) NOT NULL ,
--	lastNameAuthor    VARCHAR (50) NOT NULL ,
--	firstNameAuthor   VARCHAR (50) NOT NULL  ,
--	CONSTRAINT authors_PK PRIMARY KEY (id)
--);


--/*------------------------------------------------------------
---- Table: books
--------------------------------------------------------------*/
--CREATE TABLE books(
--	id               INT IDENTITY (1,1) NOT NULL ,
--	title            VARCHAR (50) NOT NULL ,
--	id_authors       INT  NOT NULL ,
--	id_typeOfBooks   INT  NOT NULL  ,
--	CONSTRAINT books_PK PRIMARY KEY (id)

--	,CONSTRAINT books_authors_FK FOREIGN KEY (id_authors) REFERENCES authors(id)
--	,CONSTRAINT books_typeOfBooks0_FK FOREIGN KEY (id_typeOfBooks) REFERENCES typeOfBooks(id)
--);


--/*------------------------------------------------------------
---- Table: register
--------------------------------------------------------------*/
--CREATE TABLE register(
--	id              INT IDENTITY (1,1) NOT NULL ,
--	borrowingDate   DATETIME  NOT NULL ,
--	returnDate      DATETIME   ,
--	id_books        INT  NOT NULL ,
--	id_customers    INT  NOT NULL  ,
--	CONSTRAINT register_PK PRIMARY KEY (id)

--	,CONSTRAINT register_books_FK FOREIGN KEY (id_books) REFERENCES books(id)
--	,CONSTRAINT register_customers0_FK FOREIGN KEY (id_customers) REFERENCES customers(id)
--);






--INSERT INTO [typeOfBooks] ([type])
--VALUES
--('roman'),
--('jeunesse'),
--('science fiction'),
--('horreur');

--INSERT INTO [authors] ([lastNameAuthor], [firstNameAuthor])
--VALUES
--('Rowling', 'JK'),
--('Verne', 'Jules'),
--('Tolkien', 'JR'),
--('Saint-Exupery', 'Antoine'),
--('King', 'Stephane');

--INSERT INTO [books] ([title], [id_authors], [id_typeOfBooks])
--VALUES
--('Le petit prince', 4, 2),
--('Japprends � compter avec Le petit prince', 4, 2),
--('Une journ�e avec Le petit prince', 4, 2),
--('Voyage avec Le petit prince', 4, 2),
--('Le petit prince sous les �toiles', 4, 2),
--('Le petit prince sous la mer', 4, 2),
--('Le petit prince en afrique', 4, 2),
--('Le petit prince en Asie', 4, 2),
--('Le petit prince et son ami imaginaire', 4, 2),
--('Le petit prince et Josette le serpent � sonette', 4, 2),
--('Le seigneur des anneaux : la communaut� de lanneau', 3, 1),
--('Le seigneur des anneaux : les deux tours', 3, 1),
--('Le seigneur des anneaux : le retour du roi', 3, 1),
--('Le hobbit', 3, 1),
--('Le Silmarillion', 3, 1),
--('Les enfants du Hurin', 3, 1),
--('Le livre des contes perdus', 3, 1),
--('The war of the ring', 3, 1),
--('Un vice secret', 3, 1),
--('Feuille de Niggle', 3, 1),
--('Autour de la Lune', 2, 3),
--('De la Terre � la Lune', 2, 3),
--('Hector Servadac', 2, 3),
--('L�le � h�lice', 2, 3),
--('La Maison � vapeur', 2, 3),
--('Ma�tre du monde', 2, 3),
--('Voyage au centre de la Terre', 2, 3),
--('Robur-le-Conqu�rant', 2, 3),
--('Sans dessus dessous', 2, 3),
--('Vingt mille lieues sous les mers', 2, 3),
--('Harry potter � l�cole des sorciers', 1, 1),
--('Harry potter et la chambre des secrets', 1, 1),
--('Harry potter et le prisonnier dAzkaban', 1, 1),
--('Harry potter et la coupe de feu', 1, 1),
--('Harry potter et lordre du phoenix', 1, 1),
--('Harry potter et le prince de sang m�l�', 1, 1),
--('Harry potter et les reliques de la mort', 1, 1),
--('Harry potter et lenfant maudit', 1, 1),
--('Les animaux fantastiques', 1, 3),
--('Une place � prendre', 1, 1),
--('Anatomie de lhorreur', 5, 4),
--('�a', 5, 4),
--('carrie', 5, 4),
--('Shining', 5, 4),
--('Simetierre', 5, 4),
--('Salem', 5, 4),
--('Misery', 5, 4),
--('Le fl�au', 5, 4),
--('D�me', 5, 4),
--('Docteur Sleep', 5, 4);

--INSERT INTO [dbo].[customers] ([lastName], [firstName], [birthdayDate], [mailAdress], [id_typeOfBooks])
--VALUES
--('Pose', 'Joshua', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'jpose@hotmail.fr', 4),
--('Schuvey', 'Cl�ment', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'sclement@hotmail.fr', 3),
--('Curelli', 'Mathiaas', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'cmathias@hotmail.fr', 3),
--('Lhermitte', 'Oph�lia', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'lophelia@hotmail.fr', 1),
--('Becquerel', 'Nicolas', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'bnicolas@hotmail.fr', 3),
--('Andre', 'Victor', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'andre.victor60@free.fr', 3),
--('Perreira', 'Valentin', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'pvalentin@hotmail.fr', 4),
--('Monard', 'Cl�ment', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'mclement@hotmail.fr', 3),
--('Angers', 'Julien', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'ajulien@hotmail.fr', 2),
--('Gavillan', 'Marta', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'gmarta@hotmail.fr', 1),
--('No�l', 'Micka�l', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'nmickael@hotmail.fr', 2),
--('Oriol', 'Sandrine', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'osandrine@hotmail.fr', 1),
--('Randomis', 'Randomus', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'rrandomus@hotmail.fr', 2),
--('Randomas', 'Randomas', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'rrandomas@hotmail.fr', 3),
--('Random', 'Random', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'rrandom@hotmail.fr', 1),
--('Revel', 'Am�lie', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'ramelie@homail.fr', 1),
--('Lente', 'Chlo�', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'lchloe@hotmail.fr', 2),
--('Jesais', 'pas', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'jpas@hotmail.fr', 2),
--('Oui', 'Non', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'onon@hotmail.fr', 4),
--('Dernier', 'client', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'dclient@hotmail.fr', 2)
--GO

--INSERT INTO [register] ([borrowingDate], [returnDate], [id_books], [id_customers])
--VALUES
--('19790329 00:00:00', NULL, 1, 1),
--('19790329 00:00:00', NULL, 2, 2),
--('19790329 00:00:00', NULL, 3, 3),
--('19790329 00:00:00', NULL, 4, 4),
--('19790329 00:00:00', NULL, 5, 5),
--('19790329 00:00:00', NULL, 6, 6),
--('19790329 00:00:00', NULL, 7, 7),
--('19790329 00:00:00', NULL, 8, 8),
--('19790329 00:00:00', NULL, 9, 9),
--('19790329 00:00:00', NULL, 10, 10),
--('19790329 00:00:00', NULL, 11, 11),
--('19790329 00:00:00', NULL, 12, 12),
--('19790329 00:00:00', NULL, 13, 13),
--('19790329 00:00:00', NULL, 14, 14),
--('19790329 00:00:00', CONVERT(DATETIME,'31-03-2019 15:00:00'), 15, 15),
--('19790329 00:00:00', CONVERT(DATETIME,'31-03-2019 15:00:00'), 16, 16),
--('19790329 00:00:00', CONVERT(DATETIME,'31-03-2019 15:00:00'), 17, 17),
--('19790329 00:00:00', CONVERT(DATETIME,'31-03-2019 15:00:00'), 18, 18),
--('19790329 00:00:00', CONVERT(DATETIME,'31-03-2019 15:00:00'), 19, 19),
--('19790329 00:00:00', CONVERT(DATETIME,'31-03-2019 15:00:00'), 20, 20),
--('19790329 00:00:00', CONVERT(DATETIME,'31-03-2019 15:00:00'), 21, 5),
--('19790329 00:00:00', CONVERT(DATETIME,'31-03-2019 15:00:00'), 22, 4),
--('19790329 00:00:00', CONVERT(DATETIME,'31-03-2019 15:00:00'), 23, 1),
--('19790329 00:00:00', CONVERT(DATETIME,'31-03-2019 15:00:00'), 24, 14),
--('19790329 00:00:00', CONVERT(DATETIME,'31-03-2019 15:00:00'), 25, 16),
--('19790329 00:00:00', CONVERT(DATETIME,'31-03-2019 15:00:00'), 26, 18),
--('19790329 00:00:00', CONVERT(DATETIME,'31-03-2019 15:00:00'), 27, 3),
--('19790329 00:00:00', CONVERT(DATETIME,'31-03-2019 15:00:00'), 28, 6),
--('19790329 00:00:00', CONVERT(DATETIME,'31-03-2019 15:00:00'), 29, 8),
--('19790329 00:00:00', CONVERT(DATETIME,'31-03-2019 15:00:00'), 30, 9),
--('19790329 00:00:00', CONVERT(DATETIME,'31-03-2019 15:00:00'), 31, 3),
--('19790329 00:00:00', CONVERT(DATETIME,'31-03-2019 15:00:00'), 32, 1);

--Exo 1

--SELECT 
--    [books].[title] AS [titre du livre], 
--    [customers].[lastName] AS [nom du client], 
--    [customers].[firstName] AS [pr�nom du client], 
--    [register].[borrowingDate] AS [date d'emprunt], 
--    [register].[returnDate] AS [date de retour]
--FROM
--    [register]
--INNER JOIN
--    [books]
--ON
--    [books].[id] = [register].[id_books]
--INNER JOIN
--    [customers]
--ON
--    [customers].[id] = [register].[id_customers]
--GROUP BY 
--    [books].[title], 
--    [customers].[lastName], 
--    [customers].[firstName], 
--    [register].[borrowingDate], 
--    [register].[returnDate]
--GO

--Exo 2


--SELECT 
--    [books].[title] AS [Titre du livre],
--    [typeOfBooks].[type] AS [ Type du livre],
--    [authors].[lastNameAuthor] AS [Nom de l'auteur],
--    [authors].[firstNameAuthor] AS [Pr�nom de l'auteur],
--    CAST( 
--    CASE
--        WHEN [register].[borrowingDate] < [register].[returnDate]
--            THEN 'Disponible'
--        ELSE 'Non disponible'
--    END AS char) AS [Disponibilit�]
--FROM 
--    [books]
--INNER JOIN
--    [authors]
--ON
--    [authors].[id] = [books].[id_authors]
--INNER JOIN
--    [register]
--ON
--    [register].[id_books] = [books].[id]
--INNER JOIN
--    [typeOfBooks]
--ON
--    [typeOfBooks].[id] = [books].[id_typeOfBooks]
--GROUP BY
--    [typeOfBooks].[id],
--    [register].[id_customers],
--    [register].[id],
--    [register].[id_books],
--    [authors].[id],
--    [books].[id_typeOfBooks],
--    [books].[id_authors],
--    [books].[id],
--    [books].[title],
--    [typeOfBooks].[type],
--    [authors].[lastNameAuthor],
--    [authors].[firstNameAuthor],
--    [register].[returnDate],
--    [register].[borrowingDate]
--GO


--Exo 3

SELECT [typeOfBooks].[type], COUNT ([typeOfBooks].[type]) AS [Nombre de livres]
FROM [typeOfBooks]
INNER JOIN [books]
ON [typeOfBooks].id = [books].[id_typeOfBooks]
GROUP BY [typeOfBooks].[type];