GO
IF EXISTS (SELECT TOP 1 1 FROM [DamageClass])
    RETURN;

BEGIN TRANSACTION
SET XACT_ABORT ON;

SET IDENTITY_INSERT [dbo].[DamageClass] ON;

INSERT INTO [DamageClass] (Id, Identifier)
VALUES
    (1, 'status'),
    (2, 'physical'),
    (3, 'special');

SET IDENTITY_INSERT [dbo].[DamageClass] OFF;

COMMIT TRANSACTION