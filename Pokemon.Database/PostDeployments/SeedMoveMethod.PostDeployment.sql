GO
IF EXISTS (SELECT 1 FROM [MoveMethod])
    RETURN;

BEGIN TRANSACTION
SET XACT_ABORT ON;

SET IDENTITY_INSERT [dbo].[MoveMethod] ON;

INSERT INTO [MoveMethod](Id, Identifier) VALUES
(1, 'level-up'),
(2, 'egg'),
(3, 'tutor'),
(4, 'machine'),
(5, 'stadium-surfing-pikachu'),
(6, 'light-ball-egg'),
(7, 'colosseum-purification'),
(8, 'xd-shadow'),
(9, 'xd-purification'),
(10, 'form-change'),
(11, 'zygarde-cube');

SET IDENTITY_INSERT [dbo].[MoveMethod] OFF;

COMMIT TRANSACTION


