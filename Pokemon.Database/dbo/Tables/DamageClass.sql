CREATE TABLE [dbo].[DamageClass]
(
    [Id] TINYINT NOT NULL IDENTITY,
    [Identifier] VARCHAR(8),
    CONSTRAINT [PK_DamageClass] PRIMARY KEY CLUSTERED ([Id] ASC)
);

GO
CREATE NONCLUSTERED INDEX [IX_DamageClass01] ON [dbo].[DamageClass]([Identifier] ASC);
