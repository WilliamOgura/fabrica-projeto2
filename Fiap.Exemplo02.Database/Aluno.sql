CREATE TABLE [dbo].[Aluno]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] NVARCHAR(50) NOT NULL, 
    [DataNascimento] DATETIME NOT NULL, 
    [Bolsa] BIT NOT NULL, 
    [Desconto] FLOAT NULL
)
