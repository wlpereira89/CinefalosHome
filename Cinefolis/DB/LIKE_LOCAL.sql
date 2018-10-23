﻿CREATE TABLE [dbo].[LIKE_LOCAL]
(
	[ID] INT NOT NULL IDENTITY(1, 1) UNIQUE, 
    [ID_USUARIO] INT NOT NULL, 
    [ID_GENERO] INT NOT NULL, 
    [COMENTARIO] NCHAR(10) NULL, 
    PRIMARY KEY ([ID_GENERO], [ID_USUARIO]), 
    CONSTRAINT [FK_LIKE_LOCAL_USUARIO] FOREIGN KEY ([ID_USUARIO]) REFERENCES [USUARIO]([ID]), 
    CONSTRAINT [FK_LIKE_LOCAL_GENERO] FOREIGN KEY ([ID_GENERO]) REFERENCES [GENERO]([ID])
)

