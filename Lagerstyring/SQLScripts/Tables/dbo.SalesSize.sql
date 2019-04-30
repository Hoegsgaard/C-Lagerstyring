CREATE TABLE [dbo].[SalesSize] (
    [SalesSizeID]     INT          NOT NULL,
    [SalesSizeAmount] INT          NOT NULL,
    [SalesSizePrice]  NUMERIC (18) NOT NULL,
    [SizeID]          INT          NOT NULL,
    [MerchandiseID]   INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([SalesSizeID] ASC),
    CONSTRAINT [FK_SalesSize_Size] FOREIGN KEY ([SizeID]) REFERENCES [dbo].[Size] ([SizeID]),
    CONSTRAINT [FK_SalesSize_Merchandise] FOREIGN KEY ([MerchandiseID]) REFERENCES [dbo].[Merchandise] ([MerchandiseID])
);

