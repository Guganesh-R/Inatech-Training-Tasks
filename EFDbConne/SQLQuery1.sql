create table Department
(
DepartmentID int identity(51,1),
DepartmentName varchar(25),
constraint PK_DeptID primary key(DepartmentID)
)

create table Employee
(
EmpID int,
EmpName varchar(25),
Gender char(1),
DeptID int,
constraint PK_EmpID primary key(EmpID),
constraint FK_DepID foreign key(DeptID) References Department(DepartmentID)
)

alter table Employee
add constraint CK_gender check(gender in ('m','f','t')) 

sp_help 'employee'