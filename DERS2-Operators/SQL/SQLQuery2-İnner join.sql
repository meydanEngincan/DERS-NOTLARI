-- Northwind veritabanýndan ürünler ve ürün kategorilerini getiren inner join li sorguyu yazýnýz daha sonra 
-- ProductWithCategory isminde bir výew ile productID,ProductName,SuppliedID,UnitPrice,UnitsInStock ve 
-- categories tablosundan categoryname,description kolonlarýný listeleyiniz.

--select * from Products 
--inner join  
--Categories 
--on 
--Products.ProductID=Categories.CategoryID

--alter VIEW ProductWithCategory As
--Select
--Products.ProductID,Products.ProductName,Products.SupplierID,Products.UnitPrice,Products.UnitsInStock,
--Categories.CategoryName,Categories.Description from Products inner join Categories 
--on Products.CategoryID=Categories.CategoryID

--select * from ProductWithCategory

-- Yukarýda ki sorguya ek olarak Suppliers taplosundan CompanyName(Supplier olarak yaz) ve Phone(Supplier Phone) bilgisini getirecek þekilde
--P_CategorySupplier isminde bir VIEW tanýmlayýnýz.

--create VIEW P_CategorySupplier As
--Select
--Products.ProductID,Products.ProductName,Products.SupplierID,Products.UnitPrice,Products.UnitsInStock,Suppliers.CompanyName as 'SupplierName' ,Suppliers.Phone as 'Supplier Phone',
--Categories.CategoryName,Categories.Description from Products 
--inner join Categories 
--on Products.CategoryID=Categories.CategoryID 
--inner join Suppliers
--on Products.SupplierID=Suppliers.SupplierID

--	 BÝRDEN FAZLA STÜN BÝRLEÞTÝRÝLCEKSE TEK ÝNNER JOIN YETERLÝ OLUR.

--Select * from P_CategorySupplier
-- Orders tablosunda OrderDatei 1998 olanlarý döndüren VIEW yazýnýz.
--select * from Orders where OrderDate Like '%1998%'

 --select * from Orders where year(OrderDate) =1998


--Orders tablosunda USA'a gönderilen sipariþler için : OrderID,CustomerID ve Employee Name ve Surname verilerini VIEW Oluþtur.

--alter VIEW USA AS
--select
--Orders.CustomerID,Orders.OrderID,
--CONCAT(Employees.FirstName,' ', Employees.LastName) as 'Employees Name' from Orders
--inner join Employees
--on Orders.EmployeeID=Employees.EmployeeID
--where Orders.ShipCountry like '%USA%'

-- view þart ekleyerek yaptýk. view de þartý en son veririz.

--select * from USA

-- almanyaya yapýlan satýþlardan 200 dolardan fazla olanlarýn TotalPrice,CustomerID,ShipCity bilgilerini yazdýran VIEW tanýmlayýnýz.

--select * from Orders
--Select * from [Order Details] where OrderID=10248

--declare @price int , @qua int
--select @price = dbo.[Order Details].UnitPrice, @qua = dbo.[Order Details].Quantity from dbo.[Order Details]

select ([Order Details].UnitPrice*[Order Details].Quantity)  as 'Total Price',Orders.ShipCountry,Orders.CustomerID,Orders.ShipCity from [Order Details]
inner join Orders
on [Order Details].OrderID=Orders.OrderID where Orders.ShipCountry like '%GERMANY%' and  ([Order Details].UnitPrice*[Order Details].Quantity) > 200





