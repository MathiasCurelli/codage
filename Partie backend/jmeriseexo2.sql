--CREATE DATABASE library
--USE library
--GO
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
--	returnDate      DATETIME  NOT NULL ,
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
--('Japprends à compter avec Le petit prince', 4, 2),
--('Une journée avec Le petit prince', 4, 2),
--('Voyage avec Le petit prince', 4, 2),
--('Le petit prince sous les étoiles', 4, 2),
--('Le petit prince sous la mer', 4, 2),
--('Le petit prince en afrique', 4, 2),
--('Le petit prince en Asie', 4, 2),
--('Le petit prince et son ami imaginaire', 4, 2),
--('Le petit prince et Josette le serpent à sonette', 4, 2),
--('Le seigneur des anneaux : la communauté de lanneau', 3, 1),
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
--('De la Terre à la Lune', 2, 3),
--('Hector Servadac', 2, 3),
--('LÎle à hélice', 2, 3),
--('La Maison à vapeur', 2, 3),
--('Maître du monde', 2, 3),
--('Voyage au centre de la Terre', 2, 3),
--('Robur-le-Conquérant', 2, 3),
--('Sans dessus dessous', 2, 3),
--('Vingt mille lieues sous les mers', 2, 3),
--('Harry potter à lécole des sorciers', 1, 1),
--('Harry potter et la chambre des secrets', 1, 1),
--('Harry potter et le prisonnier dAzkaban', 1, 1),
--('Harry potter et la coupe de feu', 1, 1),
--('Harry potter et lordre du phoenix', 1, 1),
--('Harry potter et le prince de sang mêlé', 1, 1),
--('Harry potter et les reliques de la mort', 1, 1),
--('Harry potter et lenfant maudit', 1, 1),
--('Les animaux fantastiques', 1, 3),
--('Une place à prendre', 1, 1),
--('Anatomie de lhorreur', 5, 4),
--('ça', 5, 4),
--('carrie', 5, 4),
--('Shining', 5, 4),
--('Simetierre', 5, 4),
--('Salem', 5, 4),
--('Misery', 5, 4),
--('Le fléau', 5, 4),
--('Dôme', 5, 4),
--('Docteur Sleep', 5, 4);

--INSERT INTO [dbo].[customers] ([lastName], [firstName], [birthdayDate], [mailAdress], [id_typeOfBooks])
--VALUES
--('Pose', 'Joshua', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'jpose@hotmail.fr', 4),
--('Schuvey', 'Clément', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'sclement@hotmail.fr', 3),
--('Curelli', 'Mathiaas', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'cmathias@hotmail.fr', 3),
--('Lhermitte', 'Ophélia', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'lophelia@hotmail.fr', 1),
--('Becquerel', 'Nicolas', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'bnicolas@hotmail.fr', 3),
--('Andre', 'Victor', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'andre.victor60@free.fr', 3),
--('Perreira', 'Valentin', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'pvalentin@hotmail.fr', 4),
--('Monard', 'Clément', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'mclement@hotmail.fr', 3),
--('Angers', 'Julien', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'ajulien@hotmail.fr', 2),
--('Gavillan', 'Marta', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'gmarta@hotmail.fr', 1),
--('Noël', 'Mickaël', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'nmickael@hotmail.fr', 2),
--('Oriol', 'Sandrine', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'osandrine@hotmail.fr', 1),
--('Randomis', 'Randomus', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'rrandomus@hotmail.fr', 2),
--('Randomas', 'Randomas', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'rrandomas@hotmail.fr', 3),
--('Random', 'Random', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'rrandom@hotmail.fr', 1),
--('Revel', 'Amélie', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'ramelie@homail.fr', 1),
--('Lente', 'Chloé', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'lchloe@hotmail.fr', 2),
--('Jesais', 'pas', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'jpas@hotmail.fr', 2),
--('Oui', 'Non', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'onon@hotmail.fr', 4),
--('Dernier', 'client', CONVERT(DATETIME, '17-11-1994 19:01:45'), 'dclient@hotmail.fr', 2)
--GO







