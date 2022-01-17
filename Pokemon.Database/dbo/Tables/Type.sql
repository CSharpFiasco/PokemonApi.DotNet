﻿CREATE TABLE [dbo].[Type]
(
    [Id] TINYINT NOT NULL IDENTITY,
    [Identifier] VARCHAR(10) NOT NULL,
    CONSTRAINT [PK_Type] PRIMARY KEY CLUSTERED ([Id] ASC)
);

GO
CREATE UNIQUE INDEX [AK_Type01] ON [dbo].[Type]([Identifier]);
