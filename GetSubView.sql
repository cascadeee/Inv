CREATE VIEW GetSub
AS
SELECT
	name AS Наименование,
	code AS Артикул,
	inv AS 'Инв. №',
	date AS 'Дата расхода',
	count AS 'Количество',
	recipient AS Получатель
FROM SubItems
LEFT JOIN Items ON SubItems.ItemId = Items.id

