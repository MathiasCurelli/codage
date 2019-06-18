USE [agenda]
GO

ALTER TABLE [dbo].[appointments] DROP CONSTRAINT [appointments_brokers_FK]
GO

ALTER TABLE [dbo].[appointments]  WITH CHECK ADD  CONSTRAINT [appointments_brokers_FK] FOREIGN KEY([idBroker])
REFERENCES [dbo].[brokers] ([idBroker])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[appointments] CHECK CONSTRAINT [appointments_brokers_FK]
GO


