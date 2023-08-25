CREATE VIEW GetAdd
AS
SELECT 
    name AS Наименование,
    code AS Артикул,
    inv AS 'Инв. №',
    date AS 'Дата поступления',
    count AS 'Количество'
FROM AddItems
LEFT JOIN Items ON AddItems.ItemId = Items.id