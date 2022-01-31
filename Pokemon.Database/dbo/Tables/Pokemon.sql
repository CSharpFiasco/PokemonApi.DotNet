CREATE TABLE [dbo].[Pokemon]
(
    [Id] INT NOT NULL IDENTITY,
    [Identifier] VARCHAR(255) NOT NULL,
    [Height] SMALLINT NOT NULL,
    [Weight] SMALLINT NOT NULL,
    [BaseExperience] SMALLINT NOT NULL,
    [Order] SMALLINT NULL,
    [IsDefault] BIT NOT NULL,
    CONSTRAINT [PK_Pokemon] PRIMARY KEY CLUSTERED ([Id] ASC)
);

GO
CREATE NONCLUSTERED INDEX [IX_Pokemon01] ON [dbo].[Pokemon]([Id] ASC, [Identifier] ASC, [Height] ASC, [Weight] ASC, [BaseExperience] ASC, [Order] ASC, [IsDefault] ASC);

GO
