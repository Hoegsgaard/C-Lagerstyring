CREATE TABLE [dbo].[Purchase] (
    [PurchaseID]     INT  NOT NULL,
    [PurchasePrice]  INT  NOT NULL,
    [PurchaseDate]   DATE NOT NULL,
    [PurchaseAmount] INT  NOT NULL,
    PRIMARY KEY CLUSTERED ([PurchaseID] ASC)
);

