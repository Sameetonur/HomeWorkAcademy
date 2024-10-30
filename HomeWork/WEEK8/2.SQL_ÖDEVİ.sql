USE Northwind

--1.SORGU
--Hiç sipariş vermemiş müşterileri listeleyin.
SELECT
    c.CustomerID
FROM Customers c
    JOIN Orders o ON o.CustomerID=c.CustomerID
WHERE o.OrderID =NULL

--2.SORGU
--Her bir ürün için, o ürünü sipariş eden benzersiz müşteri sayısını bulun.
SELECT
    p.ProductName AS [ÜRÜNLER],
    COUNT(DISTINCT o.CustomerID) AS [Benzersiz müşteri sayısı]
FROM Products p
    JOIN OrderDetails od ON p.ProductID = od.ProductID
    JOIN Orders o ON O.OrderID=od.OrderID
GROUP BY P.ProductName

--3.SORGU
--Çalışanların yöneticilerini (FirstName ve LastName) listeleyin. Yöneticisi olmayan çalışanlar da listelenmelidir. 
SELECT e.EmployeeID, e.FirstName, e.LastName, m.FirstName AS ManagerFirstName, m.LastName AS ManagerLastName
FROM Employees e
    LEFT JOIN Employees m ON e.ReportsTo = m.EmployeeID;

--4.SORGU
--Her bir tedarikçinin sağladığı ürünlerin ortalama fiyatını hesaplayın, ancak sadece 10'dan fazla ürün sağlayan tedarikçileri listeleyin.
SELECT
    sp.CompanyName,
    AVG(p.UnitPrice) AS [ortalama Fiyatı],
    COUNT(p.ProductID) AS [Tedarik Ürün Sayısı]

FROM Suppliers sp
    JOIN Products p ON p.SupplierID = sp.SupplierID
GROUP BY sp.CompanyName
having Count
(p.ProductID)>1

--5.SORGU
--En az 3 farklı kategoriden ürün sipariş etmiş müşterileri bulun.
SELECT
    ct.CustomerID,
    COUNT(DISTINCT o.OrderID) AS [Ürün Sayısı]
FROM Categories c
    JOIN Products p ON P.CategoryID=C.CategoryID
    JOIN OrderDetails OD ON OD.ProductID=P.ProductID
    JOIN Orders O ON O.OrderID=OD.OrderID
    JOIN Customers ct on ct.CustomerID=o.CustomerID
GROUP BY CT.CustomerID
HAVING COUNT(DISTINCT o.OrderID) =3

--6.SORGU
--Her bir çalışanın sorumlu olduğu bölgedeki (Territory) toplam satış miktarını hesaplayın.

SELECT
    e.FirstName +' '+e.LastName AS [Çalışan AdSoyad] ,
    T.TerritoryID AS [Sorumlu Bölgesi],
    SUM(Quantity) AS [TOPLAM SATIŞ MİK]
FROM Employees e
    JOIN Orders o ON O.EmployeeID = e.EmployeeID
    JOIN OrderDetails od ON OD.OrderID=O.OrderID
    JOIN EmployeeTerritories et ON ET.EmployeeID=E.EmployeeID
    JOIN Territories t on t.TerritoryID=et.TerritoryID
GROUP BY E.EmployeeID,E.FirstName,E.LastName,T.TerritoryID
--7.SORGU
--1997 yılının en yüksek cirolu ayını bulun.
SELECT top 1
    YEAR(o.OrderDate) AS [YIL],
    MONTH(o.OrderDate) AS [AY],
    SUM(od.Quantity*od.UnitPrice) AS [ciro]
FROM orders o
    JOIN OrderDetails od ON od.OrderID=o.OrderID
WHERE YEAR(o.OrderDate)=1997
GROUP BY YEAR(o.OrderDate),MONTH(o.OrderDate)
ORDER BY SUM(od.Quantity*od.UnitPrice) DESC

--8.SORGU
--Siparişlerin ortalama teslimat süresini (ShippedDate - OrderDate) hesaplayın ve bu ortalamadan daha uzun sürede teslim edilen siparişleri listeleyin.
select o.EmployeeID, e.FirstName, avg(DATEDIFF(day,o.ShippedDate,o.RequiredDate)) as a
from Orders o
    join Employees e on o.EmployeeID=e.EmployeeID

group by o.EmployeeID,e.FirstName
having (select avg(DATEDIFF(day,o.ShippedDate,o.RequiredDate))
from Orders o )<avg(DATEDIFF(day,o.ShippedDate,o.RequiredDate))

-- 9. Aynı gün içinde birden fazla sipariş veren müşterileri ve bu siparişlerin tarihlerini listeleyin.
SELECT CustomerID, OrderDate, COUNT(OrderID) AS OrderCount
FROM Orders
GROUP BY CustomerID, OrderDate
HAVING COUNT(OrderID) > 1;

-- 10. Çalışanların yaptığı satışları yıllık bazda karşılaştırın ve her yıl için en başarılı çalışanı bulun.

-- 11. Hem 1997 hem de 1998 yıllarında sipariş vermiş müşterileri listeleyin.
    SELECT CustomerID
    FROM Orders
    WHERE YEAR(OrderDate) = 1997
INTERSECT
    SELECT CustomerID
    FROM Orders
    WHERE YEAR(OrderDate) = 1998;
-- 12. Hiç sipariş almamış çalışanları bulun (eğer varsa).
SELECT EmployeeID, FirstName, LastName
FROM Employees
WHERE EmployeeID NOT IN (SELECT DISTINCT EmployeeID
FROM Orders);

-- 13. Her bir ülke için, o ülkedeki müşterilerin verdiği siparişlerin ortalama tutarını hesaplayın, ancak sadece toplam sipariş tutarı 5000'den fazla olan ülkeleri listeleyin.
SELECT c.Country, AVG(od.Quantity * od.UnitPrice) AS AvgOrderAmount
FROM Customers c
    JOIN Orders o ON c.CustomerID = o.CustomerID
    JOIN OrderDetails od ON o.OrderID = od.OrderID
GROUP BY c.Country
HAVING SUM(od.Quantity * od.UnitPrice) > 5000;

-- 14. En az 5 farklı ürün sipariş etmiş ve toplam sipariş tutarı 10000'den fazla olan müşterileri bulun.

SELECT
    c.CustomerID,
    COUNT(DISTINCT O.OrderID)AS [Farklı Sipariş],
    SUM(od.UnitPrice*Quantity*(1-od.Discount)) As[Tutar]
FROM Customers c
    JOIN Orders o ON C.CustomerID=O.CustomerID
    JOIN OrderDetails od ON OD.OrderID=O.OrderID

GROUP BY C.CustomerID
HAVING COUNT(DISTINCT O.OrderID)>5 AND SUM
(od.UnitPrice*Quantity*
(1-od.Discount))>1000
ORDER BY SUM(od.UnitPrice*Quantity*
    (1-od.Discount)) DESC



-- 15. Her bir çalışan için, o çalışanın aldığı siparişlerin ortalama gecikme süresini hesaplayın (RequiredDate ve ShippedDate arasındaki fark).
SELECT
    o.EmployeeID,
    avg(DATEDIFF(day,o.ShippedDate,o.RequiredDate))
from Orders o
group by o.EmployeeID
-- 16. Ürünleri, bulundukları kategorinin ortalama fiyatına göre "Ucuz", "Ortalama" veya "Pahalı" olarak sınıflandırın.

-- 17. Her bir kargo şirketi için, taşıdıkları siparişlerin ortalama ağırlığını hesaplayın (Freight).
SELECT s.ShipperID, s.CompanyName, AVG(o.Freight) AS AvgFreight
FROM Shippers s
    JOIN Orders o ON s.ShipperID = o.ShipVia
GROUP BY s.ShipperID, s.CompanyName;
-- 18. En az 10 farklı müşteriye satılmış ürünleri ve bu ürünlerin satıldığı benzersiz müşteri sayısını listeleyin.
SELECT ProductID, COUNT(DISTINCT CustomerID) AS UniqueCustomerCount
FROM OrderDetails od
    JOIN Orders o ON od.OrderID = o.OrderID
GROUP BY ProductID
HAVING COUNT(DISTINCT CustomerID) >= 10;

-- 19. Her bir çalışanın, her bir müşteriye yaptığı toplam satış tutarını bulun ve sadece 5000'den fazla satış yapılan müşteri-çalışan çiftlerini listeleyin.
SELECT o.EmployeeID, o.CustomerID, SUM(od.Quantity * od.UnitPrice) AS TotalSales
FROM Orders o
    JOIN OrderDetails od ON o.OrderID = od.OrderID
GROUP BY o.EmployeeID, o.CustomerID
HAVING SUM(od.Quantity * od.UnitPrice) > 5000;

-- 20. Her bir tedarikçinin sağladığı ürünlerin toplam satış miktarını hesaplayın ve tedarikçileri bu miktara göre sıralayın.
SELECT p.SupplierID, SUM(od.Quantity) AS TotalQuantitySold
FROM Products p
    JOIN OrderDetails od ON p.ProductID = od.ProductID
GROUP BY p.SupplierID
ORDER BY TotalQuantitySold DESC;

                




