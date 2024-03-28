create table Department(
Id INT primary key identity(1,1),
Name varchar(50));

create table Employee(
Id INT primary key identity(1,1),
Department_Id INT,
First_name varchar(50),
Last_name varchar(50),
Address varchar(50),
City varchar(50),
State varchar(50),
Email varchar(50)
foreign key (Department_Id) references Department(Id));




select * from Employee;
Select * from Department;

drop table Department;
drop table Employee;

