BACKUP DATABASE WadelisStore 
TO DISK = 'C:\BACKUP\fullbackup.BAK'
WITH INIT ,
NOUNLOAD , NAME = N'NormalBackup', NOSKIP ,
STATS = 10, NOFORMAT
GO

BACKUP DATABASE WadelisStore TO
DISK = 'C:\BACKUP\differencialbackup.BAK' WITH DIFFERENTIAL,
NOUNLOAD , NAME = 'DiferencialBackup', NOSKIP ,
STATS = 10, NOFORMAT
GO

BACKUP LOG WadelisStore 
TO DISK = 'C:\BACKUP\logbackup.TRN'
GO

--Para realizar la copia de seguridad de log, se tuvo que cambiar el tipo de recovery
--y volver a realizar las primeras backups
USE master;  
ALTER DATABASE WadelisStore 
SET RECOVERY FULL
GO

USE WadelisStore
GO