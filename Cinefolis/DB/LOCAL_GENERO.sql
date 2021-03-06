﻿CREATE TABLE [dbo].[LOCAL_GENERO]
(
	[ID] INT NOT NULL IDENTITY(1, 1) UNIQUE, 
    [ID_LOCAL] INT NOT NULL, 
    [ID_GENERO] INT NOT NULL, 
    [COMENTARIO] VARCHAR(MAX) NULL, 
    PRIMARY KEY ([ID_GENERO], [ID_LOCAL]), 
    CONSTRAINT [FK_LOCAL_GENERO_USUARIO] FOREIGN KEY ([ID_LOCAL]) REFERENCES [LOCAL]([ID]), 
    CONSTRAINT [FK_LOCAL_GENERO_MOVIE] FOREIGN KEY ([ID_GENERO]) REFERENCES [GENERO]([ID])
)
