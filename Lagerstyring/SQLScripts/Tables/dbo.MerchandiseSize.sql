CREATE TABLE [dbo].[MerchandiseSize] (
    [MerchandiseID] INT NOT NULL,
    [SizeID]        INT NOT NULL,
    PRIMARY KEY CLUSTERED ([SizeID] ASC, [MerchandiseID] ASC)
);

