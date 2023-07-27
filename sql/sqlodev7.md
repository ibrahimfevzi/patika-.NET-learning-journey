sqlodev7.md
Aşağıdaki sorgu senaryolarını dvdrental örnek veri tabanı üzerinden gerçekleştiriniz.

film tablosunda bulunan filmleri rating değerlerine göre gruplayınız.
film tablosunda bulunan filmleri replacement_cost sütununa göre grupladığımızda film sayısı 50 den fazla olan replacement_cost değerini ve karşılık gelen film sayısını sıralayınız.

´´´sql
SELECT rating, COUNT(\*) FROM film
GROUP BY rating;
´´´

´´´sql
SELECT replacement_cost, COUNT(_) FROM film
GROUP BY replacement_cost
HAVING COUNT(_) > 50;
´´´
