CREATE TABLE [dbo].[Students] (
    [Id]                 INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]          NVARCHAR (MAX) NULL,
    [LastName]           NVARCHAR (MAX) NULL,
    [CourseId]           INT            NOT NULL,
    [CourseEnrolledDate] DATETIME       NOT NULL,
    [CourseStatus]       INT            NOT NULL,
    [Grade]              NVARCHAR (MAX) NULL,
    [Age]                INT NULL,
    CONSTRAINT [PK_dbo.Students] PRIMARY KEY CLUSTERED ([Id] ASC)
);

