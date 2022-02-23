CREATE TABLE [dbo].[Membre] (
    [idMembre]  INT            IDENTITY (1, 1) NOT NULL,
    [Nom]       NVARCHAR (50)  NOT NULL,
    [Prenom]    NVARCHAR (50)  NOT NULL,
    [Email]     NVARCHAR (256) NOT NULL,
    [Pays]      INT            NOT NULL,
    [Telephone] NVARCHAR (20)  NOT NULL,
    [Login]     NVARCHAR (50)  NOT NULL,
    [Password]  NVARCHAR (256) NOT NULL,
    CONSTRAINT [PK_membre] PRIMARY KEY CLUSTERED ([idMembre] ASC),
    CONSTRAINT [FK_Membre_Pays] FOREIGN KEY ([Pays]) REFERENCES [dbo].[Pays] ([idPays])
);



