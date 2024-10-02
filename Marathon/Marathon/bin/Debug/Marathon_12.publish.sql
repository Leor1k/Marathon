/*
Скрипт развертывания для Marathon

Этот код был создан программным средством.
Изменения, внесенные в этот файл, могут привести к неверному выполнению кода и будут потеряны
в случае его повторного формирования.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "Marathon"
:setvar DefaultFilePrefix "Marathon"
:setvar DefaultDataPath "C:\Users\medvedskijae\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\medvedskijae\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

GO
:on error exit
GO
/*
Проверьте режим SQLCMD и отключите выполнение скрипта, если режим SQLCMD не поддерживается.
Чтобы повторно включить скрипт после включения режима SQLCMD выполните следующую инструкцию:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'Для успешного выполнения этого скрипта должен быть включен режим SQLCMD.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
/*
Столбец DateOfBirth таблицы [dbo].[Runner] необходимо изменить с NULL на NOT NULL. Если таблица содержит данные, скрипт ALTER может оказаться неработоспособным. Чтобы избежать возникновения этой проблемы, необходимо добавить значения этого столбца во все строки, пометить его как допускающий значения NULL или разрешить формирование интеллектуальных умолчаний в параметрах развертывания.
*/

IF EXISTS (select top 1 1 from [dbo].[Runner])
    RAISERROR (N'Обнаружены строки. Обновление схемы завершено из-за возможной потери данных.', 16, 127) WITH NOWAIT

GO
PRINT N'Идет изменение Таблица [dbo].[Runner]…';


GO
ALTER TABLE [dbo].[Runner] ALTER COLUMN [DateOfBirth] DATE NOT NULL;


GO
PRINT N'Идет изменение Таблица [dbo].[User]…';


GO
ALTER TABLE [dbo].[User] ALTER COLUMN [FirstName] NCHAR (30) NOT NULL;

ALTER TABLE [dbo].[User] ALTER COLUMN [LastName] NCHAR (30) NOT NULL;


GO
PRINT N'Обновление завершено.';


GO
