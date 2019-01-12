CREATE TABLE [dbo].[Uredjaj	]
(
	[Sifra] INT NOT NULL PRIMARY KEY, 
    [Marka] VARCHAR(50) NOT NULL, 
    [Model ] VARCHAR(50) NOT NULL, 
    [Komponenta] VARCHAR(MAX) NOT NULL, 
    [Rok] DATE NOT NULL
)
