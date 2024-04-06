CREATE TABLE [User] (
	Id INT NOT NULL IDENTITY(1,1) ,
    [Account] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
    [Role] INT NOT NULL,
    PRIMARY KEY (Id)
);

CREATE TABLE [Type] (
	Id INT NOT NULL IDENTITY(1,1) ,
    [Name] [nvarchar](50) NULL,
	[Time] [int] NOT NULL,
    PRIMARY KEY (Id)
);






