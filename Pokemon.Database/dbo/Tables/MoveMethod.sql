CREATE TABLE [dbo].[MoveMethod]
(
    [Id] INT NOT NULL IDENTITY,
    [Identifier] VARCHAR(10) NOT NULL,
    CONSTRAINT [PK_MoveMethod] PRIMARY KEY CLUSTERED ([Id] ASC)
);

GO
CREATE UNIQUE INDEX [AK_MoveMethod01] ON [dbo].[MoveMethod]([Identifier]);
