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
--(5,'Shubham','A-32','9500578462','Shubham@gmail.com'),
--(6, 'John Doe', '123 Main St', '5551234561', 'john.doe@example.com'),
--(7, 'Jane Smith', '456 Elm St', '5551234562', 'jane.smith@example.com'),
--(8, 'Alice Johnson', '789 Oak St', '5551234563', 'alice.johnson@example.com'),
--(9, 'Bob Williams', '101 Pine St', '5551234564', 'bob.williams@example.com'),
--(10, 'Mary Brown', '222 Maple St', '5551234565', 'mary.brown@example.com'),
--(11, 'James Wilson', '333 Cherry St', '5551234566', 'james.wilson@example.com'),
--(12, 'Emily Taylor', '444 Walnut St', '5551234567', 'emily.taylor@example.com'),
--(13, 'Michael Martinez', '555 Cedar St', '5551234568', 'michael.martinez@example.com'),
--(14, 'Sarah Anderson', '666 Birch St', '5551234569', 'sarah.anderson@example.com'),
--(15, 'David Thomas', '777 Pineapple St', '5551234570', 'david.thomas@example.com'),
--(16, 'Jessica Garcia', '888 Strawberry St', '5551234571', 'jessica.garcia@example.com'),
--(17, 'William Hernandez', '999 Orange St', '5551234572', 'william.hernandez@example.com'),
--(18, 'Ashley Lopez', '111 Apple St', '5551234573', 'ashley.lopez@example.com'),
--(19, 'Christopher Hill', '222 Grape St', '5551234574', 'christopher.hill@example.com'),
--(20, 'Amanda Clark', '333 Banana St', '5551234575', 'amanda.clark@example.com'),
--(21, 'Daniel Scott', '444 Lemon St', '5551234576', 'daniel.scott@example.com'),
--(22, 'Brittany Green', '555 Peach St', '5551234577', 'brittany.green@example.com'),
--(23, 'Matthew Adams', '666 Plum St', '5551234578', 'matthew.adams@example.com'),
--(24, 'Lauren Baker', '777 Pear St', '5551234579', 'lauren.baker@example.com'),
--(25, 'Andrew Gonzalez', '888 Watermelon St', '5551234580', 'andrew.gonzalez@example.com'),
--(26, 'Olivia Nelson', '999 Avocado St', '5551234581', 'olivia.nelson@example.com'),
--(27, 'Brandon Carter', '111 Blueberry St', '5551234582', 'brandon.carter@example.com'),
--(28, 'Elizabeth Perez', '222 Raspberry St', '5551234583', 'elizabeth.perez@example.com'),
--(29, 'Justin Roberts', '333 Blackberry St', '5551234584', 'justin.roberts@example.com'),
--(30, 'Megan Turner', '444 Cranberry St', '5551234585', 'megan.turner@example.com'),
--(31, 'Ryan Phillips', '555 Gooseberry St', '5551234586', 'ryan.phillips@example.com'),
--(32, 'Samantha Edwards', '666 Kiwi St', '5551234587', 'samantha.edwards@example.com'),
--(33, 'Nathan Morris', '777 Mango St', '5551234588', 'nathan.morris@example.com'),
--(34, 'Kayla Torres', '888 Papaya St', '5551234589', 'kayla.torres@example.com'),
--(35, 'Tyler Rivera', '999 Pine St', '5551234590', 'tyler.rivera@example.com'),
--(36, 'Hannah Collins', '111 Oak St', '5551234591', 'hannah.collins@example.com'),
--(37, 'Joseph Turner', '222 Elm St', '5551234592', 'joseph.turner@example.com'),
--(38, 'Alexis Cooper', '333 Maple St', '5551234593', 'alexis.cooper@example.com'),
--(39, 'Benjamin Jenkins', '444 Cherry St', '5551234594', 'benjamin.jenkins@example.com'),
--(40, 'Madison Barnes', '555 Walnut St', '5551234595', 'madison.barnes@example.com'),
--(41, 'Zachary Ross', '666 Cedar St', '5551234596', 'zachary.ross@example.com'),
--(42, 'Taylor Hill', '777 Pineapple St', '5551234597', 'taylor.hill@example.com'),
--(43, 'Victoria Watson', '888 Strawberry St', '5551234598', 'victoria.watson@example.com'),
--(44, 'Austin Sanders', '999 Orange St', '5551234599', 'austin.sanders@example.com'),
--(45, 'Kelly Ramirez', '111 Apple St', '5551234600', 'kelly.ramirez@example.com'),
--(46, 'Dylan Barnes', '222 Grape St', '5551234601', 'dylan.barnes@example.com'),
--(47, 'Morgan Hayes', '333 Banana St', '5551234602', 'morgan.hayes@example.com'),
--(48, 'Claire Coleman', '444 Lemon St', '5551234603', 'claire.coleman@example.com'),
--(49, 'Kyle Cooper', '555 Peach St', '5551234604', 'kyle.cooper@example.com'),
--(50, 'Gabriella Peterson', '666 Plum St', '5551234605', 'gabriella.peterson@example.com');




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
--(1008,5,'saving',780000.00), 
--(1009,6,'current',780000.00),
--(1010,7,'saving',750000.00),
--(1011,8,'current',80000.00),
--(1012,9,'saving',180000.00),
--(1013,10,'saving',7800.00),
--(1014,11,'current',7000.00),
--(1015,10,'current',1200.00),
--(1016,12,'saving',5000.00),
--(1017,13,'saving',700.00),
--(1018,13,'current',5000.00),
--(1019,15,'saving',150000.00),
--(1020,19,'current',78400.00),
--(1021,20,'saving',9000.00),
--(1022,22,'current',6000.00),
--(1023,23,'saving',23000.00),
--(1024,24,'saving',24000.00),
--(1025,25,'saving',32000.00),
--(1026,26,'current',64000.00),
--(1027,28,'saving',75000.00),
--(1028,29,'current',70000.00),
--(1029,30,'saving',7700.00);



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
--(2008,'rohan','Customer Service'),
--(2009, 'John Smith', 'IT'),
--(2010, 'Jane Doe', 'HR'),
--(2011, 'Alice Johnson', 'Finance'),
--(2012, 'Bob Williams', 'Marketing'),
--(2013, 'Mary Brown', 'Operations'),
--(2014, 'James Wilson', 'Sales'),
--(2015, 'Emily Taylor', 'IT'),
--(2016, 'Michael Martinez', 'Finance'),
--(2017, 'Sarah Anderson', 'HR'),
--(2018, 'David Thomas', 'Marketing'),
--(2019, 'Jessica Garcia', 'Operations'),
--(2020, 'William Hernandez', 'Sales'),
--(2021, 'Ashley Lopez', 'IT'),
--(2022, 'Christopher Hill', 'Finance'),
--(2023, 'Amanda Clark', 'HR'),
--(2024, 'Daniel Scott', 'Marketing'),
--(2025, 'Brittany Green', 'Operations'),
--(2026, 'Matthew Adams', 'Sales'),
--(2027, 'Lauren Baker', 'IT'),
--(2028, 'Andrew Gonzalez', 'Finance');



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

-- insert into Transactions values (3006,1011,2011,'withdraw',5100,'2024-01-30'),
--  (3007,1011,2016,'withdraw',5000,'2024-2-20'),
--   (3008,1012,2022,'deposit',2000,'2024-3-12'),
--   (3009,1013,2028,'withdraw',4000,'2024-2-4'),
--   (3010,1014,2011,'deposit',5000,'2024-01-3'),
--   (3011,1015,2016,'withdraw',2000,'2024-01-17'),
--   (3012,1016,2022,'deposit',4000,'2024-01-24'),
--   (3013,1017,2028,'withdraw',5000,'2024-3-18'),
--   (3014,1018,2011,'deposit',2000,'2024-3-1'),
--   (3015,1019,2016,'withdraw',4000,'2024-2-29'),
--   (3016,1020,2022,'deposit',5000,'2024-01-22');




--																--Queries

----SELECT QUERY

Select * from Customers;
select * from Account;
select * from Transactions;
select * from Employees;




----1
--update Account set Account.Balance = Account.Balance + T.Amount from Transactions as T where Account.AccountId = T.AccountId and T.Type = 'deposit';

----2
--update Account set Account.Balance = Account.Balance - T.Amount from Transactions as T where Account.AccountId = T.AccountId and T.Type = 'withdraw';


----3
--Select Type, Amount, Transaction_Date from Transactions where Transaction_Date between '2024-02-01' and '2024-03-14';

----4
--select * from Customers order by Name DESC;

----5
--select * from Customers where Name Like 'kirtan';

----6
--select * from Employees where Department = 'Finance' OR  Department ='Customer Service';

--7
--select * from Employees where Department IN ('Finance','Customer Service','Marketing');

----8
--insert into Customers values (6,'Dharmik','F-9,pardi ','9510008462','Dharmik@gmail.com');

----9
--update Customers set Address= 'vapi' where CustomerId = 6;

----10
--delete from Customers where Name='Dharmik';

----11
--select Name, Address, Phone_Number from Customers where Name like '%__n%';

----12
--select * from Transactions where Transaction_Date IN ('2024-02-20','2024-03-02');

----13
--Select * from Transactions where Type = 'deposit' AND Amount >= 10000;

----14
--Select * from Employees where Emp_Name NOT Like '__d%';

----15
--select * from Transactions where EmployeeId = 2001;

----16
--select Name,Email,Phone_Number from Customers where Phone_Number Like '951%';

----17
--Select * from Employees where Emp_Name  Like '__d%';

----18
--select * from Transactions where Amount <> 15000 AND Amount <=50000;

----19
--select * from Transactions where NOT Amount Between 15000 and 30000 AND Amount <=5000;

----20
--select * from Employees where Department NOT IN ('Finance');



----JOIN QUERY
--select C.Name, C.Address, C.Email, C.Phone_Number, A.Account_Type , A.Balance from Customers as C inner join Account as A on C.CustomerId = A.CustomerId;

--select C.Name, C.Address, C.Email, C.Phone_Number, A.Account_Type , A.Balance from Customers as C inner join Account as A on C.CustomerId = A.CustomerId where Balance >= 50000.00 and Account_Type = 'saving';



--select distinct TOP 3 C.Name, C.Address, C.Email, C.Phone_Number, A.Account_Type , A.Balance from Customers as C inner join Account as A on C.CustomerId = A.CustomerId where  Account_Type = 'saving' order by Balance DESC;

--select TOP 3 C.Name, C.Address, C.Email, C.Phone_Number, A.Account_Type , A.Balance from Customers as C inner join Account as A on C.CustomerId = A.CustomerId where  Account_Type = 'current' order by Balance DESC;

--select C.Name, C.Address, C.Email, C.Phone_Number, A.Account_Type , A.Balance from Customers as C inner join Account as A on C.CustomerId = A.CustomerId where  Name Like '%a%' AND Account_Type = 'saving' ; 

--4 table join

--select C.Name, C.Address, C.Email, A.Account_Type, T.Type,T.Amount,T.Transaction_Date,E.Emp_Name,E.Department from (((Account As A INNER JOIN Customers as C ON C.CustomerId = A.CustomerId) INNER JOIN Transactions as T ON A.AccountId = T.AccountId ) INNER JOIN Employees as E ON T.EmployeeId = E.EmployeeId) where T.Type = 'deposit';



select  top 2 Max(A.Balance) as maximum, A.Account_Type,C.Name from Customers as C inner join Account as A on C.CustomerId = A.CustomerId 
where Account_Type = 'Saving' or Account_Type='current'
Group by A.Account_Type,name
order by maximum desc
;

select distinct top 3 Customers.name, Account.Account_Type,max(Account.Balance) as Maximum from Customers
join Account on Customers.CustomerId=Account.CustomerId
--where Account_Type ='saving'
group by name,Account_Type
order by Maximum desc

select max(balance) from Account where Account_Type='saving'
select max(balance) from Account where Account_Type='current'

select Max(A.Balance), A.Account_Type  from Customers as C inner join Account as A on C.CustomerId = A.CustomerId Group by A.Account_Type having A.Account_Type = 'saving';

Select C.Name, C.Address, A.Account_Type, A.Balance , C.Phone_Number , C.Email, T.Type, T.Amount,T.Transaction_Date from ((Customers as C inner Join  Account as A on C.CustomerId = A.CustomerId)inner join Transactions as T on A.AccountId = T.AccountId);

Select C.Name, C.Address, A.Account_Type, A.Balance , C.Phone_Number , C.Email, T.Type, T.Amount,T.Transaction_Date from ((Customers as C left outer join  Account as A on C.CustomerId = A.CustomerId)left outer join Transactions as T on A.AccountId = T.AccountId);


Select C.Name, C.Address, A.Account_Type, A.Balance , C.Phone_Number , C.Email, T.Type, T.Amount,T.Transaction_Date from ((Customers as C right outer join  Account as A on C.CustomerId = A.CustomerId)right outer join Transactions as T on A.AccountId = T.AccountId);

Select C.Name, C.Address, A.Account_Type, A.Balance , C.Phone_Number , C.Email, T.Type, T.Amount,T.Transaction_Date from ((Customers as C full outer join  Account as A on C.CustomerId = A.CustomerId) full outer join Transactions as T on A.AccountId = T.AccountId)  where T.Amount IS  NULL;

Select distinct (C.Name), C.Address, A.Account_Type, A.Balance , C.Phone_Number , C.Email, T.Type, T.Amount,T.Transaction_Date from ((Customers as C inner Join  Account as A on C.CustomerId = A.CustomerId)inner join Transactions as T on A.AccountId = T.AccountId);
Select * from Customers;
select * from Account;
select * from Transactions;
select * from Employees;

create table Employees1 
( EmployeeId int,
Emp_Name varchar(50),
Department varchar(50)
);

insert into Employees1 values(2029,'who','HR'),
(2030,'this','Finance'),
(2031,'her','Finance'),
(2032,'his','marketing'),
(2033,'it','HR');

create index topresult on Customers (Phone_Number);
drop index Customers.topresult;

ALTER TABLE Customers​
ADD fingerprint bit;


ALTER TABLE Customers​
DROP COLUMN fingerprint;


ALTER TABLE Customers​
ALTER COLUMN fingerprint varchar(50);

create view [ABC] AS 
select name, address, Phone_Number from Customers 
where CustomerId >= 10;

update ABC set name = 'kirtan' where Phone_Number = '5551234565';
select * from ABC;

begin transaction 

	update Customers set Name='Nick' where CustomerId = 50;
	update Customers set Name='Kirtan' where CustomerId = 49;
	Commit transaction
	
	update Customers set Name='patel' where CustomerId = 50;
	update Customers set Name='Kiasdasd' where CustomerId = 49;
	rollback transaction


Select * from Customers;
select * from Account;
select * from Employees; 
select * from Transactions;












