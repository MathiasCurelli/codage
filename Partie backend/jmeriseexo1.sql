--CREATE DATABASE [primaryschool]
--GO

--/*------------------------------------------------------------
---- Table: teachers
--------------------------------------------------------------*/
--CREATE TABLE teachers(
--	id           INT  NOT NULL ,
--	name         VARCHAR (50) NOT NULL ,
--	firstName    VARCHAR (50) NOT NULL ,
--	mailAdress   VARCHAR (100) NOT NULL  ,
--	CONSTRAINT teachers_PK PRIMARY KEY (id)
--);


--/*------------------------------------------------------------
---- Table: classes
--------------------------------------------------------------*/
--CREATE TABLE classes(
--	id            INT  NOT NULL ,
--	CP            INT  NOT NULL ,
--	CE1           INT  NOT NULL ,
--	CE2           INT  NOT NULL ,
--	CM1           INT  NOT NULL ,
--	CM2           INT  NOT NULL ,
--	id_teachers   INT  NOT NULL  ,
--	CONSTRAINT classes_PK PRIMARY KEY (id)

--	,CONSTRAINT classes_teachers_FK FOREIGN KEY (id_teachers) REFERENCES teachers(id)
--	,CONSTRAINT classes_teachers_AK UNIQUE (id_teachers)
--);


--/*------------------------------------------------------------
---- Table: students
--------------------------------------------------------------*/
--CREATE TABLE students(
--	id            INT IDENTITY (1,1) NOT NULL ,
--	name          VARCHAR (50) NOT NULL ,
--	firstName     VARCHAR (50) NOT NULL ,
--	id_teachers   INT  NOT NULL ,
--	id_classes    INT  NOT NULL  ,
--	CONSTRAINT students_PK PRIMARY KEY (id)

--	,CONSTRAINT students_teachers_FK FOREIGN KEY (id_teachers) REFERENCES teachers(id)
--	,CONSTRAINT students_classes0_FK FOREIGN KEY (id_classes) REFERENCES classes(id)
--);


--/*------------------------------------------------------------
---- Table: matters
--------------------------------------------------------------*/
--CREATE TABLE matters(
--	id           INT  NOT NULL ,
--	french       INT  NOT NULL ,
--	english      INT  NOT NULL ,
--	history      INT  NOT NULL ,
--	geographic   INT  NOT NULL ,
--	sports       INT  NOT NULL ,
--	maths        INT  NOT NULL  ,
--	CONSTRAINT matters_PK PRIMARY KEY (id)
--);


--/*------------------------------------------------------------
---- Table: notations
--------------------------------------------------------------*/
--CREATE TABLE notations(
--	id                 INT IDENTITY (1,1) NOT NULL ,
--	studentName        VARCHAR (50) NOT NULL ,
--	firstNameStudent   VARCHAR (50) NOT NULL ,
--	studentNotation    REAL  NOT NULL ,
--	id_students        INT  NOT NULL ,
--	id_matters         INT  NOT NULL  ,
--	CONSTRAINT notations_PK PRIMARY KEY (id)

--	,CONSTRAINT notations_students_FK FOREIGN KEY (id_students) REFERENCES students(id)
--	,CONSTRAINT notations_matters0_FK FOREIGN KEY (id_matters) REFERENCES matters(id)
--);

--INSERT INTO [teachers] ([id], [name], [firstName], [mailAdress])
--VALUES 
--('1', 'Renault','LaDurée', 'rladuree@hotmail.fr'),
--('2','Théodule', 'Grenin', 'tgrenin@hotmail.fr'),
--('3', 'Françoise', 'Dubo', 'fdubo@hotmail.fr'),
--('4', 'Marie', 'Nova', 'mnova@hotmail.fr'),
--('5', 'Clément', 'Monard', 'cmonard@hotmail.fr');

--ALTER TABLE [classes]
--  ADD classe VARCHAR(50); 

  --ALTER TABLE [matters]
  --ADD matter VARCHAR(50);
  --INSERT INTO [matters] ([id], [matter])
  --VALUES
  --(1,'Sports'),
  --(2,'Anglais'),
  --(3,'Maths'),
  --(4,'Français'),
  --(5,'Histoire'),
  --(6,'Géographie');

  --INSERT INTO [classes] ([id], [id_teachers], [classe])
  --VALUES
  --(1, 1, 'CP'),
  --(2, 2, 'CE1'),
  --(3, 3, 'CE2'),
  --(4, 4, 'CM1'),
  --(5, 5, 'CM2');

--INSERT INTO [students] (name, firstName, [id_teachers], [id_classes] )
--VALUES 
--('Jeana','Paula', 1, 1),
--('Jeanz','Paulz', 1, 1),
--('Jeane','Paule', 1, 1),
--('Jeanr','Paulr', 1, 1),
--('Jeant','Pault', 1, 1),
--('Jeany','Pauly', 1, 1),
--('Jeanu','Paulu', 1, 1),
--('Jeani','Pauli', 1, 1),
--('Jeano','Paulo', 2, 2),
--('Jeanp','Paulp', 2, 2),
--('Jeanq','Paulq', 2, 2),
--('Jeans','Pauls', 2, 2),
--('Jeand','Pauld', 2, 2),
--('Jeanf','Paulf', 2, 2),
--('Jeang','Paulg', 3, 3),
--('Jeang','Paulh', 3, 3),
--('Jeanh','Paulj', 3, 3),
--('Jeanj','Paulk', 3, 3),
--('Jeank','Paull', 3, 3),
--('Jeanl','Paulm', 3, 3),
--('Jeanm','Paulw', 4, 4),
--('Jeanw','Paulx', 4, 4),
--('Jeanx','Paulc', 4, 4),
--('Jeanc','Paulv', 4, 4),
--('Jeanv','Paulb', 4, 4),
--('Jeanb','Pauln', 4, 4),
--('Jeann','Paulaa', 5, 5),
--('Jeanaz','Paulzz', 5, 5),
--('Jeanza','Paulee', 5, 5),
--('Jeanev','Paulsd', 5, 5);



INSERT INTO [notations] ([studentNotation], [id_students], [id_matters])
VALUES
('12', 1, 1),
('13', 2, 2),
('11', 3, 3),
('13', 4, 4),
('14', 5, 5),
('16', 6, 6),
('17', 7, 2),
('18', 8, 3),
('19', 9, 1),
('20', 10, 4),
('20', 11, 3),
('3', 12, 6),
('4', 13, 2),
('5', 14, 2),
('6', 15, 1),
('7', 16, 1),
('8', 17, 4),
('9', 18, 4),
('10', 19, 3),
('11', 20, 5),
('0', 21, 6),
('1', 22, 6),
('2', 23, 6),
('12', 24, 3),
('1', 25, 2),
('11', 26, 3),
('7', 27, 4),
('8', 28, 1),
('14', 29, 4),
('16', 30, 2),
('18', 21, 6),
('18', 25, 5),
('6', 17, 5),
('15', 18, 6),
('16', 20, 3),
('14', 9, 4),
('13', 23, 3),
('12', 3, 1),
('15', 21, 2),
('4', 21, 3),
('6', 18, 4),
('16', 15, 5),
('5', 9, 6),
('16', 18, 5),
('8', 29, 4),
('9', 23, 3),
('9', 18, 4),
('10', 29, 3),
('13', 18, 5),
('13', 23, 3);

SELECT * FROM [notations];
