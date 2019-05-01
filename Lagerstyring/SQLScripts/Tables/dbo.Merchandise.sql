CREATE TABLE [dbo].[Merchandise] (
    [MerchandiseID]   INT          NOT NULL,
    [MerchandiseName] VARCHAR (50) NOT NULL,
    [Income]          INT          DEFAULT ((0)) NOT NULL,
    [Expense]         INT          DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([MerchandiseID] ASC)
);

