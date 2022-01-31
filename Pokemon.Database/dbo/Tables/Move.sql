CREATE TABLE [dbo].[Move]
(
    [Id] INT NOT NULL IDENTITY,
    [Identifier] VARCHAR(32) NOT NULL,
    [TypeId] TINYINT NOT NULL,
    [Power] SMALLINT NULL,
    [PP] SMALLINT NOT NULL,
    [Accuracy] TINYINT NULL,
    [Priority] SMALLINT NOT NULL,
    [DamageClassId] TINYINT NOT NULL,
    CONSTRAINT [PK_Move] PRIMARY KEY CLUSTERED ([Id] ASC)
);

GO
ALTER TABLE [Move] ADD CONSTRAINT [FK_Move_Type] FOREIGN KEY ([TypeId]) REFERENCES [Type]([Id])

GO
ALTER TABLE [Move] ADD CONSTRAINT [FK_DamageClass_Type] FOREIGN KEY ([DamageClassId]) REFERENCES [DamageClass]([Id])

GO
CREATE UNIQUE INDEX [AK_Move01] ON [dbo].[Move]([Identifier]);

GO
CREATE NONCLUSTERED INDEX [IX_Move01] ON [dbo].[Move]([TypeId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_Move02] ON [dbo].[Move]([DamageClassId] ASC);
