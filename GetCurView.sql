CREATE VIEW GetCur
AS
SELECT 
    Items.name AS Наименование,
    Items.code AS Артикул,
    Items.inv AS 'Инв. №',
    AddItems.date AS 'Дата поступления', 
    MAX(SubItems.date) AS 'Дата последнего расхода',
    AddItems.count - IIF(SUM(SubItems.count) IS NOT NULL, SUM(SubItems.count),0) AS 'Кол-во'
FROM AddItems
LEFT JOIN SubItems ON AddItems.itemId = SubItems.itemId
LEFT JOIN Items ON AddItems.itemId = Items.id
GROUP BY name, code, inv, AddItems.date, AddItems.count