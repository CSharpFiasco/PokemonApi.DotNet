GO
IF EXISTS (SELECT TOP 1 1 FROM [Type])
    RETURN;

BEGIN TRANSACTION
SET XACT_ABORT ON;

SET IDENTITY_INSERT [dbo].[Type] ON;

INSERT INTO [Type]
VALUES
    (1, 'normal'),
    (2, 'fighting'),
    (3, 'flying'),
    (4, 'poison'),
    (5, 'ground'),
    (6, 'rock'),
    (7, 'bug'),
    (8, 'ghost'),
    (9, 'steel'),
    (10, 'fire'),
    (11, 'water'),
    (12, 'grass'),
    (13, 'electric'),
    (14, 'psychic'),
    (15, 'ice'),
    (16, 'dragon'),
    (17, 'dark'),
    (18, 'fairy');

SET IDENTITY_INSERT [dbo].[Type] OFF;

COMMIT TRANSACTION