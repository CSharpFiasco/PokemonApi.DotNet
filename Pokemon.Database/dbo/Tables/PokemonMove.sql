CREATE TABLE [dbo].[PokemonMove]
(
    [PokemonId] INT NOT NULL,
    [MoveId] INT NOT NULL,
    [Level] INT NOT NULL,
    CONSTRAINT [PK_PokemonMove] PRIMARY KEY CLUSTERED ([PokemonId] ASC, [MoveId] ASC)
);

GO
ALTER TABLE [PokemonMove] ADD CONSTRAINT [FK_PokemonMove_Pokemon] FOREIGN KEY ([PokemonId]) REFERENCES [Pokemon]([Id])

GO
ALTER TABLE [PokemonMove] ADD CONSTRAINT [FK_PokemonMove_Move] FOREIGN KEY ([MoveId]) REFERENCES [Move]([Id])

GO
CREATE NONCLUSTERED INDEX [IX_PokemonMove01] ON [dbo].[PokemonMove]([PokemonId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_PokemonMove02] ON [dbo].[PokemonMove]([MoveId] ASC);

