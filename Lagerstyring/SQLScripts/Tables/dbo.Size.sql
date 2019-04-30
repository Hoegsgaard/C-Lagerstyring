CREATE TABLE [dbo].[Size] (
    [SizeID]        INT          NOT NULL,
    [Size]          VARCHAR (50) NOT NULL,
    [SizePrice]     INT          NOT NULL,
    [SizeInventory] INT          DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([SizeID] ASC)
);

