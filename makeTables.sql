SELECT TOP 1(SIZE * 8) / 1024 SizeMB FROM sys.master_files WHERE DB_NAME(database_id) = 'Inv'

CREATE TABLE [dbo].[Items] (
    [id]   INT            IDENTITY (1, 1) NOT NULL,
    [name] NVARCHAR (MAX) NOT NULL,
    [code] NVARCHAR (MAX) NOT NULL,
    [inv]  NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[AddItems] (
    [id]     INT            IDENTITY (1, 1) NOT NULL,
    [itemId] INT            NOT NULL,
    [date]   NVARCHAR (MAX) NOT NULL,
    [count]  INT            NOT NULL,
    CONSTRAINT [PK_AddItems] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_AddItems_Items_itemId] FOREIGN KEY ([itemId]) REFERENCES [dbo].[Items] ([id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_AddItems_itemId]
    ON [dbo].[AddItems]([itemId] ASC);


CREATE TABLE [dbo].[SubItems] (
    [id]        INT            IDENTITY (1, 1) NOT NULL,
    [itemId]    INT            NOT NULL,
    [date]      NVARCHAR (MAX) NOT NULL,
    [count]     INT            NOT NULL,
    [recipient] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_SubItems] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_SubItems_Items_itemId] FOREIGN KEY ([itemId]) REFERENCES [dbo].[Items] ([id]) ON DELETE CASCADE
);
GO
CREATE NONCLUSTERED INDEX [IX_SubItems_itemId]
    ON [dbo].[SubItems]([itemId] ASC);


