test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.
Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.
Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.
Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.

```sql
CREATE TABLE employee (
    id INTEGER PRIMARY KEY,
    name VARCHAR(50),
    birthday DATE,
    email VARCHAR(100)
);

INSERT INTO employee (id, name, birthday, email) VALUES
(1, 'Mehmet', '1990-01-01', '

```

```sql
SELECT * FROM employee;
```

```sql
UPDATE employee SET name = 'Ahmet' WHERE id = 1;
UPDATE employee SET birthday = '1990-01-02' WHERE id = 1;
UPDATE employee SET email = '

```
