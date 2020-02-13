CREATE TABLE [dbo].[tblstaff] (
    [employee_id] INT           IDENTITY (1, 1) NOT NULL,
	[salary] INT NOT NULL,
    [first_name]  VARCHAR (255) NOT NULL,
    [last_name]   VARCHAR (255) NOT NULL,
    [active]      BIT           DEFAULT ((1)) NOT NULL,
    [created_at]  DATETIME      DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([employee_id] ASC)
);



