--Select
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where city = 'Berlin'

--case insensitive
Select * from Products where CategoryID = 1 or CategoryID = 3	

Select * from Products where CategoryID = 1 and UnitPrice> = 10

Select * from Products order by ProductName

Select * from Products where CategoryID = 1 order by UnitPrice desc   --ascending((artan demek)(asc)) --descending(düşen azalan demek(desc))

Select count(*) Adet from Products where CategoryID = 2

Select CategoryId,count(*) from products where UnitPrice>20 group by CategoryID having count (*)<10

Select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation Object

Select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

Select * from Customers c left join Orders o on c.CustomerID = o.CustomerID
where o.CustomerID is null









