IF EXISTS(SELECT 1 FROM sys.procedures WHERE Name = 'Proc_SelectColumnsFromTable')
BEGIN
    DROP PROCEDURE Proc_SelectColumnsFromTable
END
GO

CREATE PROCEDURE Proc_SelectColumnsFromTable
(
    @TABLE_NAME VARCHAR(150)
)
AS
BEGIN

    SELECT 
       TableName = tbl.table_schema + '.' + tbl.table_name, 
       ColumnName = col.column_name, 
       ColumnDataType = col.data_type
   FROM INFORMATION_SCHEMA.TABLES tbl
   INNER JOIN INFORMATION_SCHEMA.COLUMNS col 
       ON col.table_name = tbl.table_name
       AND col.table_schema = tbl.table_schema
   
   WHERE tbl.table_name = @TABLE_NAME

END