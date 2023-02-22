--Task-1
select FirstName,LastName
from Person.Person 
--where Title not like 'Null'
--where title is not Null
where title !='null'
 --- all the above comments are correct

 --Task-2
 select FirstName,LastName 
 from Person.Person
 where FirstName like '%a%' and LastName like '%a%'

 --Task-3
select cur.CurrencyCode,Name
from Sales.Currency cur, Sales.CountryRegionCurrency

--Task-4
select * into HumanResources.hr_dept
from HumanResources.Department 

select * from HumanResources.hr_dept

--task-5

create table task5
(
sno int identity (1,1),
fname varchar(20),
lname varchar(20),
gender varchar(2),
bloodgroup varchar(3)
)

insert into task5
values('gugan','r','m','O+')
insert into task5
values('vignesh','sj','m','o+')

select*from task5

--task-6
select p.BusinessEntityID, AddressTypeID
from HumanResources.Department dept
join Person.BusinessEntityAddress p 
on p.BusinessEntityID = dept.DepartmentID  

--task-7
select distinct GroupName
from HumanResources.Department

--task-8
select sum(ListPrice), sum(p.StandardCost), ProductSubcategoryID
from Production.ProductCostHistory p 
join Production.Product prod
on p.ProductID = prod.ProductID
group by ProductSubcategoryID

--task-9
select datediff(year, StartDate, EndDate) Role
from HumanResources.EmployeeDepartmentHistory

--task-11
select max(TaxRate) Max_taxrate
from Sales.SalesTaxRate

--task-12 
select dept.DepartmentID, emp.BusinessEntityID, dhis.ShiftID, emp.BirthDate
from HumanResources.Department dept 
join HumanResources.Employee emp 
on dept.DepartmentID = emp.BusinessEntityID
join HumanResources.EmployeeDepartmentHistory dhis
on dhis.BusinessEntityID = emp.BusinessEntityID

--task-13
create view NameAge
as
Select dept.DepartmentID, emp.BusinessEntityID, dhis.ShiftID, emp.BirthDate, getdate() as CurrentDate, year(getdate())-year(emp.BirthDate) as age 
from HumanResources.Department dept
join HumanResources.Employee emp 
on dept.DepartmentID = emp.BusinessEntityID
join HumanResources.EmployeeDepartmentHistory dhis
on dhis.BusinessEntityID = emp.BusinessEntityID

select*from NameAge

--task-14  
select count(*) [No_of_rows_hr] from HumanResources.Department, HumanResources.Employee

--task-15
select max(Rate) Max_Rate,Name
from HumanResources.EmployeePayHistory emp join
HumanResources.Department dept
on emp.BusinessEntityID = dept.DepartmentID
group by Name

--task-16
select FirstName,MiddleName,Title,AddressTypeID,buis.BusinessEntityID
from Person.Person p
left join Person.BusinessEntityAddress buis
on p.BusinessEntityID=buis.BusinessEntityID
where Title is not null 

--task-17
select ProductID,pl.LocationID,Shelf
from Production.ProductInventory p
join Production.Location pl
on p.LocationID=pl.LocationID
where ProductID>=300 and ProductID<=350 and pl.LocationID=50 or Shelf='E'

--task-18
select Shelf,Name,p.LocationID
from Production.ProductInventory p
join Production.Location pl
on p.LocationID=pl.LocationID

--task-19
select AddressID,AddressLine1,AddressLine2,ps.StateProvinceID,StateProvinceCode,CountryRegionCode
from Person.StateProvince ps
join Person.Address padd
on ps.StateProvinceID=padd.StateProvinceID

--task-20
select  CurrencyCode,Sum(SubTotal+TaxAmt) as total
from Sales.SalesOrderHeader so
join Sales.SalesTerritory st
on st.TerritoryID=so.TerritoryID
join Sales.CountryRegionCurrency sc
on sc.CountryRegionCode=st.CountryRegionCode
group by CurrencyCode

