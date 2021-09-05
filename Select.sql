select p.Name, c.Name from Junction j
right join Products p on j.ProductID = p.ID
left join Categories c on j.CategoryID = c.ID

-- где таблица Junction содержит соотвествия
-- между продуктами и категориями