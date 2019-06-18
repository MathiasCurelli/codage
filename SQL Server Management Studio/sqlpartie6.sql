

--CREATE TABLE [dbo].[ide](
  --[id] SMALLINT IDENTITY (1,1) NOT NULL PRIMARY KEY,
  --[name] VARCHAR (50) NOT NULL,
	--[version] VARCHAR (50) NOT NULL,
	--[date] DATE NOT NULL,
--)
--GO

 --Insertion des données dans la table ide
--INSERT INTO [dbo].[ide] ([name], [version], [date]) VALUES 
  --('Eclipse', '3.3', '2007-06-01'),
  --('Eclipse', '3.5', '2009-06-01'),
  --('Eclipse', '3.6', '2010-06-01'),
  --('Eclipse', '3.7', '2011-06-01'),
  --('Eclipse', '4.3', '2013-06-13'),
  --('NetBeans', '7', '2011-04-01'),
  --('NetBeans', '8.2', '2016-10-03');

--Exo 1

--use [webDevelopment]
--SELECT [id], [framework], [version] FROM [frameworks] WHERE [version] LIKE '2%';

--Exo 2

--use [webDevelopment]
--SELECT * FROM [frameworks] WHERE [id] = '1' OR [id] = '3';

--Exo 3

--use [webDevelopment]
--SELECT * FROM [dbo].[ide] WHERE [date] BETWEEN '2010-01-01' AND '2011-12-31';
