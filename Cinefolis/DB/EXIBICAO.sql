﻿CREATE TABLE [dbo].[EXIBICAO]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [ID_EVENTO] INT NOT NULL, 
    [HORARIO] DATETIME NULL, 
    CONSTRAINT [FK_EXIBICAO_EVENTO] FOREIGN KEY ([ID_EVENTO]) REFERENCES [EVENTO]([ID])
)
