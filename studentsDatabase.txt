create database StudentsDb
use StudentsDb

create table Student(ID int primary key identity,
            SName nvarchar(50) not null,
			SAge int not null,
			Course nvarchar(50) not null,
			Email nvarchar(50) not null,
			Contact nvarchar(10))
                


insert into Student values('Ram',21,'ECE','ram@123','987654321'),('sam',21,'EEE','Sam@123','789654321')
insert into Student values('naveen',20,'CSE','Naveen@123','897654312')

select * from Student