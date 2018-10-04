use master
go
create database dfjkl
go
use dfjkl
go
create table (
id int primary key, 
test_data char(500)
)
insert into testtable(id,test_data) values (1,3)
go
select * from testtable
go