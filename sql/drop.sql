-- drop all fk constraints
DECLARE @sql NVARCHAR(MAX) = N'';

SELECT @sql += '
ALTER TABLE ' + QUOTENAME(OBJECT_SCHEMA_NAME(parent_object_id)) +
'.' + QUOTENAME(OBJECT_NAME(parent_object_id)) +
' DROP CONSTRAINT ' + QUOTENAME(name) + ';'
FROM sys.foreign_keys;

EXEC sp_executesql @sql;

-- drop all tables
SET @sql = N'';

SELECT @sql += '
DROP TABLE ' + QUOTENAME(SCHEMA_NAME(schema_id)) +
'.' + QUOTENAME(name) + ';'
FROM sys.tables;

EXEC sp_executesql @sql;
