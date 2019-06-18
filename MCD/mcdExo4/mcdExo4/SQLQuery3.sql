USE [agenda]
GO

ALTER TABLE [dbo].[appointments] DROP CONSTRAINT [appointments_customers0_FK]
GO

ALTER TABLE [dbo].[appointments]  WITH CHECK ADD  CONSTRAINT [appointments_customers0_FK] FOREIGN KEY([idCustomer])
REFERENCES [dbo].[customers] ([idCustomer])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[appointments] CHECK CONSTRAINT [appointments_customers0_FK]
GO


