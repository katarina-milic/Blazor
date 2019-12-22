CREATE TABLE [dbo].[Korisnici] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Username]  NVARCHAR (30)  NOT NULL,
    [FirstName] NVARCHAR (MAX) NULL,
    [LastName]  NVARCHAR (MAX) NULL,
    [Password]  NVARCHAR (MAX) NOT NULL,
	 [Email]  NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Korisnici] PRIMARY KEY CLUSTERED ([Id] ASC)
);

