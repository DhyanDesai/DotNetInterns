--create database Banking_System;


--create table Customers(
--	CustomerId int PRIMARY KEY,
--	Name varchar(50) NOT NULL,
--	Address varchar(50) NOT NULL, 
--	Phone_Number char(10) UNIQUE NOT NULL,
--	Email varchar(50) UNIQUE NOT NULL
--);

--insert into Customers values (1,'Kirtan','146,valsad','9513578462','kirtan@gmail.com'),
--(2,'Dhyan','152,surat','9977553321','dhyan@gmail.com'),
--(3,'Nachi','G-45,ahmedabad','9513054512','Nachi@gmail.com'),
--(4,'Chintan','B-99,navsari','9513500062','Chintan@gmail.com'),
--(5,'Shubham','A-32','9500578462','Shubham@gmail.com');




--create table Account(
--AccountId int PRIMARY KEY,
--CustomerId int,
--Account_Type varchar(50) NOT NULL,
--Balance Decimal(10,2) DEFAULT 0.00,
--foreign key (CustomerId) references Customers(CustomerId)
--);

--insert into Account values(1001,1,'saving',100000.00),
--(1002,1,'current',50000.00),
--(1003,2,'saving',25000.00),
--(1004,3,'saving',10000.00),
--(1005,3,'current',370000.00),
--(1006,4,'current',180000.00),
--(1007,5,'saving',5000.00),
--(1008,5,'current',780000.00);



--create table Employees(
--EmployeeId int PRIMARY KEY,
--Emp_Name varchar(50),
--Department varchar(50) NOT NULL, 
--);

--insert into Employees values(2001,'raj','Finance'),
--(2002,'siddhart','Customer Service'),
--(2003,'siddh','Marketing'),
--(2004,'kaival','Finance'),
--(2005,'urvish','Marketing'),
--(2006,'arjun','Customer Service'),
--(2007,'neel','Finance'),
--(2008,'rohan','Customer Service');



--create table Transactions(
--TransactionId int PRIMARY KEY,
--AccountId int,
--EmployeeId int,
--Type varchar(50) NOT NULL,
--Amount decimal(10,2) NOT NULL,
--Transaction_Date date NOT NULL,
--foreign key (AccountId) references Account(AccountId),
--foreign key (EmployeeId) references Employees(EmployeeId)
--);

-- insert into Transactions values (3001,1001,2001,'deposit',5000.00,'2024-03-2'),
-- (3002,1003,2004,'deposit',15000.00,'2024-02-20'),
-- (3003,1004,2007,'withdraw',2000.00,'2024-01-15'),
-- (3004,1008,2004,'deposit',10000.00,'2024-03-13'),
-- (3005,1002,2001,'withdraw',15000.00,'2024-02-29');


																--Queries

--SELECT QUERY

Select * from Customers;
select * from Account;
select * from Transactions;
select * from Employees;

--1
--update Account set Account.Balance = Account.Balance + T.Amount from Transactions as T where Account.AccountId = T.AccountId and T.Type = 'deposit';

--2
--update Account set Account.Balance = Account.Balance - T.Amount from Transactions as T where Account.AccountId = T.AccountId and T.Type = 'withdraw';


--3
--Select Type, Amount, Transaction_Date from Transactions where Transaction_Date between '2024-02-01' and '2024-03-14';

--4
--select * from Customers order by Name DESC;

--5
--select * from Customers where Name Like 'kirtan';

--6
--select * from Employees where Department = 'Finance' OR  Department ='Customer Service';

--7
--select * from Employees where Department IN ('Finance','Customer Service','Marketing');

--8
--insert into Customers values (6,'Dharmik','F-9,pardi ','9510008462','Dharmik@gmail.com');

--9
--update Customers set Address= 'vapi' where CustomerId = 6;

--10
--delete from Customers where Name='Dharmik';

--11
--select Name, Address, Phone_Number from Customers where Name like '%__n%';

--12
--select * from Transactions where Transaction_Date IN ('2024-02-20','2024-03-02');

--13
--Select * from Transactions where Type = 'deposit' AND Amount >= 10000;

--14
--Select * from Employees where Emp_Name NOT Like '__d%';

--15
--select Amount, Transaction_Date from Transactions where EmployeeId = 2001;

--16
--select Name,Email,Phone_Number from Customers where Phone_Number Like '951%';

--17
--Select * from Employees where Emp_Name  Like '__d%';

--18
--select * from Transactions where Amount <> 15000 AND Amount <=50000;

--19
--select * from Transactions where NOT Amount Between 15000 and 30000 AND Amount <=5000;

--20
--select * from Employees where Department NOT IN ('Finance');

--21
--drop table Transactions;
--drop table Employees;
--drop table Account;
--drop table Customers;











--together data
--select C.Name, C.Address, C.Email, C.Phone_Number, A.Account_Type , A.Balance from Customers as C inner join Account as A on C.CustomerId = A.CustomerId;

--select C.Name, C.Address, C.Email, C.Phone_Number, A.Account_Type , A.Balance from Customers as C inner join Account as A on C.CustomerId = A.CustomerId where Balance >= 50000.00 and Account_Type = 'saving';



--select TOP 3 C.Name, C.Address, C.Email, C.Phone_Number, A.Account_Type , A.Balance from Customers as C inner join Account as A on C.CustomerId = A.CustomerId where  Account_Type = 'saving' order by Balance DESC;

--select TOP 3 C.Name, C.Address, C.Email, C.Phone_Number, A.Account_Type , A.Balance from Customers as C inner join Account as A on C.CustomerId = A.CustomerId where  Account_Type = 'current' order by Balance DESC;

--select C.Name, C.Address, C.Email, C.Phone_Number, A.Account_Type , A.Balance from Customers as C inner join Account as A on C.CustomerId = A.CustomerId where  Name Like '%a%' AND Account_Type = 'saving' ; 







