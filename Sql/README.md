> 1) Создаем БД
```sql
CREATE TABLE Products (
    ID INT PRIMARY KEY,
    ProductName VARCHAR(50)
);

CREATE TABLE Categories (
    ID INT PRIMARY KEY,
    CategoryName VARCHAR(50)
);

CREATE TABLE ProductCategory (
    ProductID INT,
    CategoryID INT,
    FOREIGN KEY(ProductID) REFERENCES Products(ID),
    FOREIGN KEY(CategoryID) REFERENCES  Categories(ID)
);
```

> 2) Заливаем БД
```sql
INSERT INTO Categories (ID, CategoryName)
VALUES
    (1, 'Фрукты'),
    (2, 'Овощи'),
    (3, 'Тест');

INSERT INTO Products (ID, ProductName)
VALUES
    (1, 'Банан'),
    (2, 'Груша'),
    (3, 'Огурец'),
    (4, 'Неизвестное');

INSERT INTO ProductCategory (ProductID, CategoryID)
VALUES
    (1, 1),
    (2, 1),
    (3, 2),
	(4, null);
```

> 3) Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

```sql
SELECT рroducts.ProductName, COALESCE(categories.CategoryName, 'Нет категории') AS CategoryName
FROM Products as рroducts
LEFT JOIN ProductCategory productCategory ON рroducts.ID = productCategory.ProductID
LEFT JOIN Categories categories ON productCategory.CategoryID = categories.ID
ORDER BY рroducts.ProductName;
```

> 4) Результат
> 
| Продукты | Категории |
|----------|-----------|
| Банан    | Фрукты    |
| Груша    | Фрукты    |
| Неизвестное | Нет категории |
| Огурец    | Овощи    |