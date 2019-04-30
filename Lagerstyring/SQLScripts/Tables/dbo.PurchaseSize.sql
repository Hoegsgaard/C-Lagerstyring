CREATE TABLE [dbo].[PurchaseSize] (
    [PurchaseSizeID]     INT NOT NULL,
    [PurchaseSizeAmount] INT NOT NULL,
    [SizeID]             INT NOT NULL,
    [MerchandiseID]      INT NOT NULL,
    PRIMARY KEY CLUSTERED ([PurchaseSizeID] ASC),
    CONSTRAINT [FK_PurchaseSize_Size] FOREIGN KEY ([SizeID]) REFERENCES [dbo].[Size] ([SizeID])
);

