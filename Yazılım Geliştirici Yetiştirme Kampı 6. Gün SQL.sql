--Yazılım Geliştirici Yetiştirme Kampı 6. Gün SQL

--Select
--Select * from Customers --Customers tablosundaki tüm stunları getirir
--Select ContactName, CompanyName, City from Customers -- Customers tablosundaki "Customers", "CompanyName", "City" sütunlarını getirir.
--Select ContactName Adi, CompanyName ŞirketAdi, City Şehir from Customers --Alias kullanımı
--Select * from Customers where City ='London' -- Customers tablosundaki City sütunundan London olanları getirir.
--select * from Products where categoryID=1 or CategoryID=3 -- Products tablosundaki categoryID'si 1 veya 3 olanları getir.
--select * from Products where categoryID=1 and UnitPrice>=15 -- Products tablosundaki categoryID'si 1 ve UnitPrice'ı 15'den büyük eşit olanları getir.
--select * from Products order by ProductName -- Products tablosundaki tüm sütunları ProductName'e göre azdan çoka sırayıp getirir.
--select * from Products order by ProductName asc -- Products tablosundaki tüm sütunları ProductName'e göre azdan çoka sırayıp getirir.
--select * from Products order by ProductName desc-- Products tablosundaki tüm sütunları ProductName'e göre çoktan aza sırayıp getirir.
--select * from Products order by CategoryID, UnitPrice --Products tablosudaki tüm  sütunları önce CategoryID'ye göre sonra UnitPrice'a göre sıralayıp getirir.
--select * from Products where CategoryID=1 order by UnitPrice desc -- Products tablosudaki tüm sütunları CategoryID'si 1 olanları tersten sıralayarak getirir
--select count(*) from Products -- Products tablosundaki tüm satırların toplamını getirir.
--select count(*) Adet from Products -- Products tablosundaki tüm satırların toplamını getirir. Sütun başlığında da (Alias) Adet yazar.
--select CategoryID from Products group by CategoryID --CategoryID'leri listeler
--select CategoryID,count(*) from Products group by CategoryID
--select CategoryId,count(*) from products where UnitPrice>20 group by CategoryID having count(*)<10 -- Products tablosundaki tüm sütunların toplamını UnitPrice'ı 20'den büyük olanları getirerek ve CategoryID'si 10'dan küçük olanları toplayarak listeler.

--Join
--on: "Durumunda", "şartında" demek
--select * from Products inner join Categories on Products.CategoryID=Categories.CategoryID --Products tablosundaki CategoryID, Categories tablosudaki CategoryID'ye eşit ise Products tablosundaki ve Category tablosundaki tüm kolonları getir. Toplam 14 sütun (kolon) getirir. 
--select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName from Products inner join Categories on Products.CategoryID=Categories.CategoryID --Products tablosundaki CategoryID, Categories tablosudaki CategoryID'ye eşit ise Products tablosundaki ProductID, ProductName,UnitPrice kolonlarını ve Category tablosundaki CategoriesName kolonunu getir. Toplam 4 sütun (kolon) getirir.  
--select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName from Products inner join Categories on Products.CategoryID=Categories.CategoryID where Products.UnitPrice<10--Products tablosundaki CategoryID, Categories tablosudaki CategoryID'ye eşit ise Products tablosundaki ProductID, ProductName,UnitPrice kolonlarını ve Category tablosundaki CategoriesName kolonunu Products tablosundaki UnitPrice'ı 10'dan küçük olanları getir. Toplam 4 sütun (kolon) getirir.  

--Inner Join = Sadece eşleşen kayıtları getirir.

--Select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID -- Products tablosu "p" ile Order Details tablosu "od" ile yazımı kısaltılarak iki tablo birleştirilmiştir. p.ProductID ile od.ProductID eşit olanları listelemiştir.
--Select * from Customers c inner join Orders o on c.CustomerID = o.CustomerID --Customers tablosu "c" ile Orders tablosu "o" ile yazımı kısaltılarak iki tablo birleştirildi. c.Customer.Id ile o.CustomerID eşit olanlar listelenmiştir. 
--Yani müşterler listesindeki tüm müşterilerin vermiş olduğu siparişler listelenmiştir.

--Select * from Customers c left join Orders o on c.CustomerID = o.CustomerID --Customers tablosu "c" ile Orders tablosu "o" ile yazımı kısaltılarak iki tablo birleştirildi. c.Customer.Id ile o.CustomerID eşit olanlar listelenmiştir. 
--Fakat "left join" denildiği için sol tarafta belirtilen tablonun (Customers) tamamını getirir, sonrasında sağ tafta belirtilen tabloyu (Orders) da birleştirerek getirir.
--Yani sipariş listesindeki tüm sipariş veren yada vermeyen müşteriler ile müşteri listesi tablosu birleştirilerek listelenmiştir.

--Select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null -- Burada ise; üst tarafdaki sorgu haricinde where o.CustomersID is null kullanıldığı için:
--Sipariş listesinde, sipariş vermeyen müşteriler, müşteri tablosu ile sipariş tablosu birleştirilerek listelenmiştir.