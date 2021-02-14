--Select
--ANSII
select ContactName Adi, CompanyName SirketAdi,City Sehir from Customers 

select * from Customers where City = 'Berlin'

--case insensitive
select * from Products where CategoryID=1 or CategoryID = 3

select * from Products where CategoryID=1 and UnitPrice > 10

select * from Products order by CategoryID,ProductName
select * from Products where CategoryID = 1 order by UnitPrice desc

select count(*) Adet from Products where CategoryID = 2

--her kategori de kaç adet ürün var ve 10 dan düşük kaç adet var 
select CategoryID,count(*) from Products where UnitPrice>20 
group by CategoryID having count(*)<10 
--having sorguya yazılan "where" dir. Kümülatiflere uygulanır.

--inner join sadece 2 tabloda eşleşen verileri getirir. eşleşmeyenleri getirmez.
select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where products.UnitPrice>10 order by UnitPrice

--DTO / Data transformation object

--yazıma göre solda olupta sağda olmayanları da getir demek. /Left join

select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID

--Müşterilerde olupta, ordersta olanları getirdi
select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID

--sisteme kayıt olupta aktif olmayanları getirir.
select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null --siparişte kaydı olmadığı için primary key'e yazıldı.

--2den fazla tablo
select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

